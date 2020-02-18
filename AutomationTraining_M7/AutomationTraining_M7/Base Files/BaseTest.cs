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

        /*Webdriver Intance*/
        public static clsDriver objclsDriver;
        public static IWebDriver driver;
        /*URL for Webdriver*/
        private static string strBrowserName = ConfigurationManager.AppSettings.Get("url");

        //public static ExtentHtmlReporter objHtmlReporter; //Old Version of HTML

        public string url;
        public string username;
        public string password;

        public clsReportManager manager;
        public ExtentV3HtmlReporter htmlReporter;
        public ExtentReports extent;

        public ExtentTest exTestSuite;
        public ExtentTest exTestCase;
        public ExtentTest exTestStep;


        //**************************************************
        //                  M E T H O D S 
        //**************************************************
        //OneTimeSetUp before each class test
        [OneTimeSetUp]
        public void fnBeforeClass()
        {
            manager = new clsReportManager();

            extent = new ExtentReports();
            htmlReporter = new ExtentV3HtmlReporter(manager.fnGetReportPath());

            manager.fnReportSetup(htmlReporter, extent);

            exTestSuite = extent.CreateTest(TestContext.CurrentContext.Test.Name);

        }

        [SetUp]
        //SetUp Before each test case
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = strBrowserName;
            driver.Manage().Window.Maximize();
            objclsDriver = new clsDriver(driver);

            exTestCase = exTestSuite.CreateNode(TestContext.CurrentContext.Test.Name);
        }


        /*Clear and Send text to specific field*/
        public void FnSendkeyAndClear(By by, string pstrText)
        {
            driver.FindElement(by).Clear();
            driver.FindElement(by).SendKeys(pstrText);
        }

        [TearDown]
        //TearDown After each test case
        public void AfterTest()
        {
            driver.Close();
            driver.Quit();
        }

        //OneTimeTearDown after each class test
        [OneTimeTearDown]
        public void fnAfterClass()
        {
            extent.Flush();
        }
    }
}