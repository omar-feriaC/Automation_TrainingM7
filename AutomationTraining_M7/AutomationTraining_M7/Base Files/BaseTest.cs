
using AutomationTraining_M7.Reporting;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Base_Files
{
    class BaseTest
    {
        //**************************************************
        //*                V A R I A B L E S
        //**************************************************
        
        /*Webdriver Instance*/
        public static IWebDriver driver;
        /*URL for Webdriver*/
        private static string strBrowserName = ConfigurationManager.AppSettings.Get("url");
        /*Extent Reports Framework*/
        public static clsReportManager objRM = new clsReportManager();
        public static ExtentV3HtmlReporter objHtmlReporter;
        public static ExtentReports objExtent;
        public static ExtentTest objTest;






        //**************************************************
        //                  M E T H O D S 
        //**************************************************
        //OneTimeSetUp before each class test
        [OneTimeSetUp]
        public static void fnBeforeClass()
        {
            /*Init ExtentHtmlReporter object*/
            if (objHtmlReporter == null)
            {
                objHtmlReporter = new ExtentV3HtmlReporter(objRM.fnReportPath());
            }

            /*Init ExtentReports object*/

            if (objExtent == null)
            {
                objExtent = new ExtentReports();
                objRM.fnReportSetUp(objHtmlReporter, objExtent);
            }
        }

        //OneTimeTearDown before each class test
        [OneTimeTearDown]
        public static void fnAfterClass()
        {
            objExtent.Flush();
        }


        [SetUp]
        //SetUp Before each Test Case
        /*Initialize the driver and indicates the url*/
        public static void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = strBrowserName;
        }

       
        [TearDown]
        //TearDown Before each Test Case
        /*Close the browser and quit the selenium instance*/
        public static void AfterTest()
        {

           objRM.fnTestCaseResult(objTest, objExtent, driver);
           driver.Close();
           driver.Quit();
        }
        

        /*Clear and Send text to specific field*/
        public static void FnSendkeyAndClear(By by, string pstrText)
        {
            driver.FindElement(by).Clear();
            driver.FindElement(by).SendKeys(pstrText);
        }




    }
}
