using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace HFunctionLibrary
{
    #region 影像相關功能

    public class ImageHandler
    {
        private int getPageCount(String fileName)
        {
            int pageCount = -1;
            try
            {
                Image img = Bitmap.FromFile(fileName);
                pageCount = img.GetFrameCount(FrameDimension.Page);
                img.Dispose();

            }
            catch (Exception ex)
            {
                pageCount = 0;
            }
            return pageCount;
        }

        private int getPageCount(Image img)
        {
            int pageCount = -1;
            try
            {
                pageCount = img.GetFrameCount(FrameDimension.Page);
            }
            catch (Exception ex)
            {
                pageCount = 0;
            }
            return pageCount;
        }

        private Image getTiffImage(String sourceFile, int pageNumber)
        {
            Image returnImage = null;

            try
            {
                Image sourceIamge = Bitmap.FromFile(sourceFile);
                returnImage = getTiffImage(sourceIamge, pageNumber);
                sourceIamge.Dispose();
            }
            catch (Exception ex)
            {
                returnImage = null;
            }

            return returnImage;
        }

        private Image getTiffImage(Image sourceImage, int pageNumber)
        {
            MemoryStream ms = null;
            Image returnImage = null;

            try
            {
                ms = new MemoryStream();
                Guid objGuid = sourceImage.FrameDimensionsList[0];
                FrameDimension objDimension = new FrameDimension(objGuid);
                sourceImage.SelectActiveFrame(objDimension, pageNumber);
                sourceImage.Save(ms, ImageFormat.Tiff);
                returnImage = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                returnImage = null;
            }
            return returnImage;
        }

        /// <summary>
        /// TifToPDF
        /// <param name="FilePath">FilePath FilePath檔案位置，多筆用;區隔</param>
        /// </summary>
        public bool TIFtoPDF(List<string> FilePath)
        {
            ImageHandler tiff = new ImageHandler();

            bool res = false;

            try
            {
                foreach (var path in FilePath)
                {
                    string PDFPath = path.Substring(0, path.Length - 4) + ".pdf";

                    if (File.Exists(path))
                    {
                        PdfDocument doc = new PdfDocument();

                        int pageCount = tiff.getPageCount(path);

                        for (int i = 0; i < pageCount; i++)
                        {
                            PdfPage page = new PdfPage();

                            Image tiffImg = tiff.getTiffImage(path, i);

                            XImage img = XImage.FromGdiPlusImage(tiffImg);

                            page.Width = img.PointWidth;
                            page.Height = img.PointHeight;
                            doc.Pages.Add(page);

                            XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[i]);

                            xgr.DrawImage(img, 0, 0);
                        }

                        doc.Save(PDFPath);

                        doc.Close();
                    }
                    else
                        throw new Exception(string.Format("UtilityFunctions.TIFtoPDF :{0}檔案不存在", path));
                }

                res = true;
            }
            catch (Exception ex)
            {

            }
            return res;
        }
    }

    #endregion

}
