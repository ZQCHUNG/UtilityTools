using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace HFunctionLibrary
{
    public class SQLClass
    {
        //不確定是否會用，EF應該居多

        #region DBConn

        //For查詢
        public DataTable ConnDB(string sqlStr)
        {
            string Connstr = string.Empty;
            try
            {
                DataTable dt = new DataTable();

                Connstr = System.Web.Configuration.WebConfigurationManager.AppSettings["MsConnStr"];

                using (SqlConnection conn = new SqlConnection(Connstr))
                {
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    cmd.ExecuteNonQuery();
                }
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //For查詢
        public int ConnDB_ReturnNum(string sqlStr)
        {
            string Connstr = string.Empty;
            try
            {
                DataTable dt = new DataTable();

                Connstr = System.Web.Configuration.WebConfigurationManager.AppSettings["MsConnStr"];
                //string connStr = string.Format("Data Source={0}; Initial Catalog={1}; User id={2}; Password={3};",Data_Source,Provider,UserID,Password);

                using (SqlConnection conn = new SqlConnection(Connstr))
                {
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    cmd.ExecuteNonQuery();
                }
                return dt.Rows.Count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        //For查詢某一欄位結果
        public string ConnDB_GetOneValue(string sqlStr)
        {
            string ResultValue = "";

            string Connstr = string.Empty;
            try
            {
                DataTable dt = new DataTable();

                Connstr = System.Web.Configuration.WebConfigurationManager.AppSettings["MsConnStr"];
                //string connStr = string.Format("Data Source={0}; Initial Catalog={1}; User id={2}; Password={3};",Data_Source,Provider,UserID,Password);

                using (SqlConnection conn = new SqlConnection(Connstr))
                {
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    cmd.ExecuteNonQuery();
                }

                ResultValue = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return ResultValue;
            }

            return ResultValue;
        }

        //For新增修改刪除
        public bool ConnDBUID(string sqlStr)
        {
            string Connstr = string.Empty;
            try
            {
                DataTable dt = new DataTable();

                Connstr = System.Web.Configuration.WebConfigurationManager.AppSettings["MsConnStr"];

                using (SqlConnection conn = new SqlConnection(Connstr))
                {
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        /*
         * 1. Oracle 取得DataTable
         * 2. 兩張Table Left_Join
         * 3. 兩張Table Inner_Join
         * 4. Oracle 取得影響數量
         * 5. Oracle 取得單一值
         * 6. Oracle 取得是否存在
         */
    }
}
