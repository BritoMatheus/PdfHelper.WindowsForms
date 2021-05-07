using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace Domain.Pdf
{
    public class PdfUtil
    {
        public void Group(List<string> files, string outputPdfPath)
        {
            PdfImportedPage importedPage;

            var sourceDocument = new Document();
            var pdfCopyProvider = new PdfCopy(sourceDocument, new System.IO.FileStream(outputPdfPath, System.IO.FileMode.Create));

            //output file Open  
            sourceDocument.Open();

            //files list wise Loop  
            for (int f = 0; f < files.Count; f++)
            {
                int pages = TotalPageCount(files[f]);

                var reader = new PdfReader(files[f]);
                //Add pages in new file  
                for (int i = 1; i <= pages; i++)
                {
                    importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                    pdfCopyProvider.AddPage(importedPage);
                }

                reader.Close();
            }
            pdfCopyProvider.Close();
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

        public void Image(List<string> files, string outputPdfPath)
        {
            foreach (string filePatch in files)
            {
                iTextSharp.text.Rectangle pageSize = null;

                using (var srcImage = new Bitmap(filePatch))
                {
                    pageSize = new iTextSharp.text.Rectangle(0, 0, srcImage.Width, srcImage.Height);
                }

                using (var ms = new MemoryStream())
                {
                    var document = new Document(pageSize, 0, 0, 0, 0);
                    PdfWriter.GetInstance(document, ms).SetFullCompression();
                    document.Open();
                    var image = iTextSharp.text.Image.GetInstance(filePatch);
                    document.Add(image);
                    document.Close();

                    var fileName = Path.GetFileNameWithoutExtension(filePatch);

                    File.WriteAllBytes($"{outputPdfPath}{fileName}.pdf", ms.ToArray());
                }
            }
        }
    }
}
