using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
namespace HFunctionLibrary.UtilityFunctions.Tests
{
    [TestClass()]
    public class DateTransTests
    {
        public string ToFullTaiwanDate(DateTime datetime)
        {
            TaiwanCalendar taiwanCalendar = new TaiwanCalendar();

            return string.Format("{0}/{1}/{2}",
                                    taiwanCalendar.GetYear(datetime),
                                    datetime.Month,
                                    datetime.Day);
        }

        [TestMethod()]
        public void ToFullTaiwanDateTest()
        {
            //arrange
            
            DateTime datetime = DateTime.Now.Date;
            
            string expected = "107/3/26";

            string actual;

            //act

            actual = ToFullTaiwanDate(datetime);

            //assert

            Assert.AreEqual(expected, actual);
        }
    }
}
