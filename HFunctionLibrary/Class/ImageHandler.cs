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

        /// <summary>
        /// Gray 轉灰階
        /// <param name="SourceBitmap">SourceBitmap SourceBitmap:來源圖檔</param>
        /// </summary>
        public Bitmap ImageToGray(Bitmap SourceBitmap)
        {
            try
            {
                BitmapData bmData = SourceBitmap.LockBits(new Rectangle(0, 0, SourceBitmap.Width, SourceBitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                int stride = bmData.Stride;

                System.IntPtr Scan0 = bmData.Scan0;

                unsafe
                {
                    byte* p = (byte*)bmData.Scan0;

                    int offset = stride - SourceBitmap.Width * 3;

                    byte red, green, blue;

                    for (int y = 0; y < SourceBitmap.Height; y++)
                    {
                        for (int x = 0; x < SourceBitmap.Width; x++)
                        {
                            blue = p[0];
                            green = p[1];
                            red = p[2];

                            p[0] = p[1] = p[2] = (byte)(.299 * red + .587 * green + .114 * blue);

                            p += 3;
                        }
                    }
                    p += offset;
                }

                SourceBitmap.UnlockBits(bmData);
            }
            catch (Exception ex)
            {

            }

            return SourceBitmap;
        }

        /// <summary>
        /// Binarization_固定筏值 二值化_自適應閥值
        /// <param name="SourceBitmap">SourceBitmap SourceBitmap:來源圖檔</param>
        /// </summary>
        /// 
        public Bitmap Binarization_FixThreshoding(Bitmap b, byte threshold)
        {
            try
            {
                int width = b.Width;

                int height = b.Height;

                BitmapData bmdata = b.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

                unsafe
                {
                    byte* p = (byte*)bmdata.Scan0;

                    int offset = bmdata.Stride - width * 4;

                    byte R, G, B, gray;

                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            R = p[2];
                            G = p[1];
                            B = p[0];
                            gray = (byte)((R * 19595 + G * 38469 + B * 7472) >> 16);

                            if (gray >= threshold)
                            {
                                p[0] = p[1] = p[2] = 255;
                            }
                            else
                            {
                                p[0] = p[1] = p[2] = 0;
                            }
                            p += 4;
                        }
                        p += offset;
                    }

                    b.UnlockBits(bmdata);
                }
            }
            catch (Exception ex)
            {

            }

            return b;
        }

        /// <summary>
        /// Binarization_OTSU 二值化_自適應閥值
        /// <param name="SourceBitmap">SourceBitmap SourceBitmap:來源圖檔</param>
        /// </summary>
        /// 
        /*
         　 ω0 = N0/M×N    (1)
　　　　　　ω1= N1/M×N    (2)
　　　　　　N0+N1 = M×N    (3)
　　　　　　ω0+ω1=1　　　 (4)
　　　　　　μ=ω0*μ0+ω1*μ1 (5)
　　　　　　g=ω0(μ0-μ)^2+ω1(μ1-μ)^2 (6)
　　　　　　g=ω0ω1(μ0-μ1)^2   (7)　最佳閥值
         */
        public Bitmap Binarization_OTSU(Bitmap b)
        {
            int width = b.Width;
            int height = b.Height;

            byte threshold = 0;

            int[] hist = new int[256];

            int AllpixelNumber = 0, PixelNumberSmall = 0, PixelNumberBig = 0;

            double MaxValue, AllSum = 0, SumSmall = 0, SumBig, ProbabilitySmall, ProbabilityBig, Probability;

            BitmapData bmData = b.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            unsafe
            {
                byte* p = (byte*)bmData.Scan0;

                int offset = bmData.Stride - width * 4;


                for (int j = 0; j < height; j++)
                {
                    for (int i = 0; i < width; i++)
                    {
                        hist[p[0]]++;

                        p += 4;
                    }

                    p += offset;
                }

                b.UnlockBits(bmData);
            }


            //計算灰度為I的像素出現的機率
            for (int i = 0; i < 256; i++)
            {
                AllSum += i * hist[i];

                AllpixelNumber += hist[i];
            }

            MaxValue = -1.0;

            for (int i = 0; i < 256; i++)
            {
                PixelNumberSmall += hist[i];
                PixelNumberBig = AllpixelNumber - PixelNumberSmall;

                if (PixelNumberBig == 0)
                {
                    break;
                }

                SumSmall += i * hist[i];

                SumBig = AllSum - SumSmall;

                ProbabilitySmall = SumSmall / PixelNumberSmall;

                ProbabilityBig = SumBig / PixelNumberBig;

                Probability = PixelNumberSmall * ProbabilitySmall * ProbabilitySmall + PixelNumberBig * ProbabilityBig * ProbabilityBig;

                if (Probability > MaxValue)
                {
                    MaxValue = Probability;
                    threshold = (byte)i;
                }

            }

            return Binarization_FixThreshoding(b, threshold); ;
        }
    }

    #endregion

}
