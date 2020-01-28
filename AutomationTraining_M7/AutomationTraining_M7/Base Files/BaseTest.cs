using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Reporting;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

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
            //objHtmlReporter = new ExtentHtmlReporter(objRM.fnReportPath());
        }
        /*Init ExtentReports object*/
        if (objExtent == null)
        {
            objExtent = new ExtentReports();
            objRM.fnReportSetUp(objHtmlReporter, objExtent);
        }
    }

    //OneTimeTearDown after each class test
    [OneTimeTearDown]
    public static void fnAfterClass()
    {
        objExtent.Flush();
    }

    [SetUp]
    //SetUp Before each test case
    public static void SetUp()
    {
        driver = new ChromeDriver();
        driver.Url = strBrowserName;
        driver.Manage().Window.Maximize();
        objclsDriver = new clsDriver(driver);

    }

    [TearDown]
    //TearDown After each test case
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