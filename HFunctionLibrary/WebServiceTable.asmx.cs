using HFunctionLibrary.Class;
using HFunctionLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace HFunctionLibrary
{
    /// <summary>
    ///WebServiceTable 的摘要描述
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允許使用 ASP.NET AJAX 從指令碼呼叫此 Web 服務，請取消註解下列一行。
     [System.Web.Script.Services.ScriptService]
    public class WebServiceTable : System.Web.Services.WebService
    {
        ModelContext dbContext = new ModelContext();

        [WebMethod]
        [ScriptMethod]
        public string GetListOfPersons()
        {
            var User = dbContext.UserTable.ToList();

            List<UserTable> persons = User;
            return Newtonsoft.Json.JsonConvert.SerializeObject(
                new PagedList(persons, persons.Count, 1, persons.Count));
        }
    }
}
