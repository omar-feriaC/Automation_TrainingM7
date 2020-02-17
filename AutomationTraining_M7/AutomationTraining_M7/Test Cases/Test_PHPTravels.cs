using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AutomationTraining_M7.Reporting;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {
        clsPHPTravels_LoginPage objPHP;
        clsPHPTravels_Main pageMain;


        [Test]
        public void Test_M9Exercise()
        {
            objPHP = new clsPHPTravels_LoginPage(driver);
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            clsPHPTravels_LoginPage.fnEnterEmail("admin@phptravels.com");
            clsPHPTravels_LoginPage.fnEnterPassword("demoadmin");
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            pageMain = new clsPHPTravels_Main(driver);
            Dictionary<string,string> listValues = pageMain.CreateReport();
            foreach (KeyValuePair<string,string> keyText in listValues) 
            {
                string strText = keyText.Key +": "+ keyText.Value;
                Assert.AreEqual(true,true);
                objRM.fnTestCaseResult(BaseTest.objTest, BaseTest.objExtent, driver, strText);
            }

        }

    }
}
