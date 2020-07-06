using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_LinkedIn_DataDriven : BaseTest
    {
        LinkedIn_LoginPage objLogin;
        clsLibData objLibData = new clsLibData();
        DataTable tblTable;


        [Test]
        public void Login_LinkedIn_DB()
        {
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            objLogin = new LinkedIn_LoginPage(driver);
            tblTable = objLibData.fnExecuteQueryData2("select * from UserCredentials");
            LinkedIn_LoginPage.fnLoginLikedInPage(tblTable, "3");

        }


    }
}
