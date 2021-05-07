using System.Drawing.Imaging;
using iTextSharp.text.pdf;

namespace PdfHelper.Compressor
{
    internal interface ICompressElement
    {
        void Compress(PdfObject pdfObject, PdfDictionary pdfImageObject, PdfStamper stamper, int pageNum);
        void SetCompressionPercent(float compressionPercent);
        void SetPreferredOutputImageType(ImageFormat format);
    }
}
