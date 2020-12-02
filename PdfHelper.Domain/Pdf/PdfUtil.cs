using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.Pdf
{
    public class PdfUtil
    {
        public void Agrupar(List<string> files, string outputPdfPath)
        {
            PdfReader reader = null;
            Document sourceDocument = null;
            PdfCopy pdfCopyProvider = null;
            PdfImportedPage importedPage;

            sourceDocument = new Document();
            pdfCopyProvider = new PdfCopy(sourceDocument, new System.IO.FileStream(outputPdfPath, System.IO.FileMode.Create));

            //output file Open  
            sourceDocument.Open();

            //files list wise Loop  
            for (int f = 0; f < files.Count; f++)
            {
                int pages = TotalPageCount(files[f]);

                reader = new PdfReader(files[f]);
                //Add pages in new file  
                for (int i = 1; i <= pages; i++)
                {
                    importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                    pdfCopyProvider.AddPage(importedPage);
                }

                reader.Close();
            }
            //save the output file  
            sourceDocument.Close();
        }

        private int TotalPageCount(string file)
        {
            using (StreamReader sr = new StreamReader(System.IO.File.OpenRead(file)))
            {
                Regex regex = new Regex(@"/Type\s*/Page[^s]");
                MatchCollection matches = regex.Matches(sr.ReadToEnd());

                return matches.Count;
            }
        }
    }
}
