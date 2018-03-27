using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Web;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Drawing;
using System.Drawing.Imaging;
using Ionic.Zip;
using System.Net;
using System.Globalization;

namespace HFunctionLibrary
{
    public class UtilityFunctions
    {
        /* 已完成
         * DirectoryHandler
         * 目錄&目錄檔案(含壓縮等)相關功能
         * GetWebInfomation
         * 取得網頁基本資訊 httpType、serverName、serverPort、mainPath、FullURL (Ex:http://192.168.1.45:80/CTHCIS_XD/)
         * DateTrans
         * 日期、時間相關轉換
         * 待完成 
         * 1. 日期轉換(西元轉民國)
         * 2. 日期轉換(民國轉西元)
         * 3. 給路徑，取得檔案Base64的值
         * 4. 製作下載頁面
         * 5. 取得本機基本資訊
         * 6. 從URL取得檔案
         */

        public class DateTrans
        {
            public string ToFullTaiwanDate(DateTime datetime)
            {
                TaiwanCalendar taiwanCalendar = new TaiwanCalendar();

                return string.Format("{0}/{1}/{2}", 
                                        taiwanCalendar.GetYear(datetime), 
                                        datetime.Month, 
                                        datetime.Day);
            }
        }

        #region  取得網頁基本資訊：

        public class GetWebInfomation : System.Web.UI.Page
        {
            /// <summary>
            /// 取得網頁走Http或Https
            /// </summary>
            public string GetHttpType()
            {
                 string httpType = this.Request.ServerVariables["Https"].ToString();

                 string httpLink = httpType.ToLower() == "on" ? " https" : "http";

                 return httpLink;
            }

            /// <summary>
            /// 取得網頁ServerName(IP or DNS)
            /// </summary>
            public string GetServerName()
            {
                string serverName = this.Request.ServerVariables["SERVER_NAME"].ToString();

                return serverName;
            }

            /// <summary>
            /// 取得網頁serverPort
            /// </summary>
            public string GetServerPort()
            {
                string serverName = this.Request.ServerVariables["SERVER_NAME"].ToString();

                return serverName;
            }


            /// <summary>
            /// 取得網頁WebSiteName
            /// </summary>
            public string GetWebSiteName()
            {
               string serverMainPath = this.Request.ServerVariables["SCRIPT_NAME"].ToString();

               string mainPath = serverMainPath.Substring(serverMainPath.IndexOf('/') + 1, serverMainPath.LastIndexOf('/'));

               return mainPath;
            }

            /// <summary>
            /// 取得網頁完整Url(Ex:http://192.168.1.45:80/CTHCIS_XD/)
            /// </summary>
            public string GetWebFullURL()
            {
                string url = string.Format("{0}://{1}:{2}/{3}", GetHttpType(), GetServerName(), GetServerPort(), GetWebSiteName());

                return url;
            }
        }

        #endregion

        #region 目錄&目錄檔案(含壓縮等)相關功能

        public class DirectoryHandler
        {
            /// <summary>
            /// 將檔案進行壓縮
            /// <param name="FilePath">FilePath FilePath檔案位置，多筆用;區隔</param>
            /// <param name="FilePath">SavePath SavePath壓縮檔存放位置</param>
            /// </summary>
            public bool CompressedFile(List<string> FilePath, string SavePath)
            {
                bool res = false;
                try
                {
                    using (ZipFile zip = new ZipFile())
                    {
                        foreach (var path in FilePath)
                        {
                            zip.AddFile(path, "Files");
                        }

                        zip.Save(SavePath);
                    }
                    res = true;
                }
                catch (Exception ex)
                {

                }
                return res;
            }

            /// <summary>
            /// 儲存要壓縮的檔案路徑
            /// <param name="FilePath">FilePath FilePath檔案位置，多筆用;區隔</param>
            /// </summary>
            public List<string> GetDownLoadFileList(string FilePath)
            {
                List<string> FilesPath = new List<string>();
                try
                {
                    if (string.IsNullOrEmpty(FilePath))
                    {
                        return null;
                    }

                    string[] tmpFilePath = FilePath.Split(';');

                    foreach (var s in tmpFilePath)
                    {
                        FilesPath.Add(s);
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }

                return FilesPath;
            }

            /// <summary>
            /// 建立目錄
            /// <param name="DirPath">DirPath DirPath想建立的目錄路徑</param>
            /// </summary>
            public void CreateDirectory(string DirPath)
            {
                try
                {
                    if (!Directory.Exists(DirPath))
                    {
                        Directory.CreateDirectory(DirPath);
                    }
                }
                catch (Exception ex)
                {

                }
            }

            /// <summary>
            /// 刪除目錄下所有檔案
            /// <param name="DirPath">DirPath DirPath想刪除的目錄路徑</param>
            /// </summary>
            public void DeleteDirectoryFile(string DirPath)
            {
                try
                {
                    if (Directory.Exists(DirPath))
                    {
                        string[] files = Directory.GetFiles(DirPath);

                        foreach (string file in files)
                        {
                            File.Delete(file);
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }

            /// <summary>
            /// 刪除目錄下某類型檔案
            /// <param name="DirPath">DirPath DirPath想刪除的目錄路徑</param>
            /// <param name="DeleteType">DeleteType DeleteType想刪除的種類(例如：*.xml)</param>
            /// </summary>
            public void DeleteDirectoryFile(string DirPath, string DeleteType)
            {
                try
                {
                    if (Directory.Exists(DirPath))
                    {
                        string[] files = Directory.GetFiles(DirPath, DeleteType);

                        foreach (string file in files)
                        {
                            File.Delete(file);
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }

            /// <summary>
            /// 複製檔案
            /// <param name="sourcePath ">sourcePath  sourcePath 檔案位置，多筆用;區隔</param>
            /// <param name="targetPath">targetPath targetPath想將檔案搬到哪個目錄</param>
            /// </summary>
            public void CopyFile(List<string> sourcePath, string targetPath)
            {
                try
                {
                    if (!Directory.Exists(targetPath))
                    {
                        Directory.CreateDirectory(targetPath);
                    }

                    string destFile = "";

                    foreach(var path in sourcePath)
                    {
                        var FileName = path.Split('\\');

                        destFile =  System.IO.Path.Combine(targetPath, FileName[FileName.Length - 1]);

                        System.IO.File.Copy(path, destFile, true);
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
        #endregion
    }
}