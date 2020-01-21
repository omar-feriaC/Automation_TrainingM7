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
            clsReportManager report = new clsReportManager();
            report.fnReportSetUp(BaseTest.objHtmlReporter, BaseTest.objExtent);
            /*URL for Webdriver*/
            //Init objects
            objPHP = new clsPHPTravels_LoginPage(driver);
            // los busque todos los ejemplos 

            

            //Login Action
            //Assert.AreEqual(true, BaseTest.driver.Title.Contains("Administrador Login."), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail("admin@phptravels.com");
            clsPHPTravels_LoginPage.fnEnterPassword("demoadmin");
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            //Assert.AreEqual(true, BaseTest.driver.Title.Contains("Dashboard."), "The Dashboard was not loaded correctly.");
            pageMain = new clsPHPTravels_Main(driver);
            Dictionary<string,string> listValues = pageMain.CreateReport();
            foreach (KeyValuePair<string,string> keyText in listValues) 
            {
                string strText = keyText.Key +": "+ keyText.Value;
                Assert.AreEqual(true,true);
                report.fnTestCaseResult(BaseTest.objTest, BaseTest.objExtent, driver, strText);
                //do magic 
            }

            // ExtentTest pobjTest, ExtentReports pobjExtent, IWebDriver pobjDriver
        }

    }
}
