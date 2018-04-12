using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HFunctionLibrary
{
    public partial class DownloadFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string ServerFilePath = this.Request.QueryString["ServerFilePath"];

                string FileName = this.Request.QueryString["FileName"];

                WebClient wc = new WebClient();

                byte[] b = wc.DownloadData(ServerFilePath);

                FileName = HttpUtility.UrlEncode(Path.GetFileName(FileName));

                Response.Clear();
                //設定標頭檔資訊 attachment 是本文章的關鍵字
                Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
                //開始輸出讀取到的檔案
                Response.BinaryWrite(b);
                //一定要加入這一行，否則會持續把Web內的HTML文字也輸出。
                Response.End();
            }
            catch (Exception ex)
            {

            }
        }
    }
}