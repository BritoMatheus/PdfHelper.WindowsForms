using FreeImageAPI;
using iTextSharp.text.exceptions;
using iTextSharp.text.pdf;
using PdfHelper.Compressor.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace PdfHelper.Compressor
{
    public class PdfCompressor
    {
        private string SourceFolder { get; set; }
        private string DestinationFolder { get; set; }

        public void Start(List<string> files, string output)
        {
            foreach (var filePatch in files)
            {
                var fileName = Path.GetFileName(filePatch);
                var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePatch);
                var source = $"{Path.GetDirectoryName(filePatch)}\\";
                Run(fileName, source, output, fileNameWithoutExtension);
            }
        }

        private void Run(string filename, string sourceFolder, string destinationFolder, string fileNameWithoutExtension)
        {
            SourceFolder = sourceFolder;
            DestinationFolder = destinationFolder;

            var sourcePath = SourceFolder + filename;
            if (!File.Exists(sourcePath))
            {
                throw new ArgumentException(string.Format("PDF file doesn't exist in file system. Validate the full path: \"{0}\"", sourcePath));
            }

            var destinationPath = $"{DestinationFolder}{fileNameWithoutExtension} comprimido.pdf";
            if (!FreeImage.IsAvailable())
            {
                throw new ApplicationException("FreeImage library isn't available");
            }
            var _factory = new ImageCompressorFactory();

            Logger.LogInfo(string.Format("Start processing of file \"{0}\"", filename));
            var timing = Stopwatch.StartNew();

            var pdfReader = new PdfReader(sourcePath);
            using (var fs = new FileStream(destinationPath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (var pdfStamper = new PdfStamper(pdfReader, fs))
                {
                    var wasCompressed = false;
                    var totalPages = pdfReader.NumberOfPages + 1;
                    Logger.LogInfo(string.Format("Total number of pages is: {0}", totalPages - 1));
                    for (int i = 1; i < totalPages; i++)
                    {
                        PdfDictionary page = pdfReader.GetPageN(i);
                        PdfDictionary resources = (PdfDictionary)PdfReader.GetPdfObject(page.Get(PdfName.RESOURCES));
                        PdfDictionary xobject = (PdfDictionary)PdfReader.GetPdfObject(resources.Get(PdfName.XOBJECT));

                        if (xobject != null)
                        {
                            foreach (var name in xobject.Keys)
                            {
                                var obj = xobject.Get(name);
                                if (obj.IsIndirect())
                                {
                                    var imgObject = (PdfDictionary)PdfReader.GetPdfObject(obj);

                                    if (imgObject != null && imgObject.Get(PdfName.SUBTYPE).Equals(PdfName.IMAGE))
                                    {
                                        var filter = imgObject.Get(PdfName.FILTER);

                                        Logger.LogDebug(string.Format("page num: {0}. Filter {1}", i, filter));

                                        var compressor = _factory.Create(filter, filename, compressionLevel);
                                        if (compressor != null)
                                        {
                                            try
                                            {
                                                compressor.Compress(obj, imgObject, pdfStamper, i);
                                            }
                                            catch (UnsupportedPdfException ex)
                                            {
                                                Logger.LogError(string.Format("Exception at file \"{0}\" on page {1}. {2}", filename, i, ex));
                                            }
                                            catch (KeyNotFoundException ex)
                                            {
                                                Logger.LogError(string.Format("Exception at file \"{0}\" on page {1}. {2}", filename, i, ex));
                                            }
                                            catch (InvalidImageException ex)
                                            {
                                                Logger.LogError(string.Format("Exception at file \"{0}\" on page {1}. {2}", filename, i, ex));
                                            }
                                        }
                                        else
                                        {
                                            Logger.LogWarning(string.Format("Skip compression for {0} type of image", filter));
                                        }

                                        Logger.Log(TraceEventType.Information, string.Format("Image on page {0} compressed successfully", i));
                                        wasCompressed = true;
                                    }
                                }
                            }
                        }
                        else
                        {
                            pdfReader.SetPageContent(i, pdfReader.GetPageContent(i), PdfStream.BEST_COMPRESSION, true);
                        }
                    }

                    if (!wasCompressed)
                    {
                        pdfReader.RemoveUnusedObjects();
                        pdfReader.RemoveAnnotations();
                    }
                }
            }

            Logger.LogInfo(string.Format("Compression of file \"{0}\" completed on \"{1}\"", filename, timing.Elapsed));
            var compression = CalculateCompression(sourcePath, destinationPath);
            Logger.LogInfo(string.Format("File was compressed on {0} %", compression));

            pdfReader.Close();
        }

        /// <summary>
        /// Here the parameter you worth to play with:
        /// Accepted values are: [0.01, ..., 0.99]
        /// The value closer to Zero - higher compression, lower quality
        /// The value closer to One - lower compression, higher quality
        /// </summary>
        private float compressionLevel = 0.37f;

        private int CalculateCompression(string source, string dest)
        {
            FileInfo fi = new FileInfo(source);
            var sourcFileLength = fi.Length;
            fi = new FileInfo(dest);
            var destFileLength = fi.Length;
            return (int)(sourcFileLength / destFileLength) * 100;
        }
    }
}
