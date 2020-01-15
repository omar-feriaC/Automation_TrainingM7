using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Reporting
{
    class clsReportManager
    {

        public string fnGetReportPath()
        {
            string strExecutionPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string strBaseDirectory = strExecutionPath.Substring(0, strExecutionPath.IndexOf("bin"));
            strBaseDirectory = new Uri(strBaseDirectory).LocalPath;

            string strReportDirectory = strBaseDirectory + "ExtentReports";
            if(!Directory.Exists(strReportDirectory))
            {
                Directory.CreateDirectory(strReportDirectory);
            }

            string strReportPath = strReportDirectory + "\\ExtentReport_" + DateTime.Now.ToString("MMddyyyy_HHmmss") + ".html";

            return strReportPath;
        }

        public void fnReportSetup(ExtentV3HtmlReporter htmlReporter, ExtentReports extent)
        {
            htmlReporter.Config.DocumentTitle = "Automation Framework Report";
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            htmlReporter.Config.ReportName = "Module 9 Exercise";

            extent.AttachReporter(htmlReporter);

            extent.AddSystemInfo("Project Name:", "Module 9 Exercise");
            extent.AddSystemInfo("Application:", "WebPage");
            extent.AddSystemInfo("Environment:", "QA");
            extent.AddSystemInfo("Date:", DateTime.Now.ToShortDateString());
        }

        public string fnCaptureImage(IWebDriver pobjDriver)
        {
            ITakesScreenshot objITake = (ITakesScreenshot)pobjDriver;
            Screenshot objScreenshot = objITake.GetScreenshot();

            string strExecutionPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string strBaseDirectory = strExecutionPath.Substring(0, strExecutionPath.IndexOf("bin"));
            strBaseDirectory = new Uri(strBaseDirectory).LocalPath;

            string strScreenshotDirectory = strBaseDirectory + "ExtentReports\\Screenshots";
            if(!Directory.Exists(strScreenshotDirectory))
            {
                Directory.CreateDirectory(strScreenshotDirectory);
            }

            string strScreenshotPath = strScreenshotDirectory + $"\\{TestContext.CurrentContext.Test.Name}_{DateTime.Now.ToString("HHmmss")}.png";
            objScreenshot.SaveAsFile(strScreenshotPath);

            return strScreenshotPath;

        }
    }
}
