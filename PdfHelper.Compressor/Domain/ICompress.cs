using System.IO;

namespace PdfHelper.Compressor
{
    internal interface ICompress
    {
        void CompressFile(string sourcePath, string destinationPath, string filename, double? compressionLevel);
        Stream CompressFile(Stream fileStream, string destinationPath, string filename, double? compressionLevel);
        void ReportStatistics();
    }
}
