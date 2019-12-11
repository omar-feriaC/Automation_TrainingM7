using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Reporting
{
    class clsReportManager
    {
        public string fnReportPath()
        {
            /*Create report directory*/
            string strPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string strActualPath = strPath.Substring(0, strPath.LastIndexOf("bin"));
            string strProjectPath = new Uri(strActualPath).LocalPath;
            Directory.CreateDirectory(strProjectPath + "ExtentReports");
            string strReportPath = strProjectPath + "ExtentReports\\ExtentReports.html";

            return strReportPath;
        }

        public void fnReportSetup(ExtentHtmlReporter phtmlReporter, ExtentReports pExtent) 
        {
            phtmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            phtmlReporter.Config.DocumentTitle = "Automation Framework";
            pExtent.AttachReporter(phtmlReporter);
            pExtent.AddSystemInfo("Project name", "Automation Framework");
            pExtent.AddSystemInfo("Application", "LinkedIn");
            pExtent.AddSystemInfo("Environment", "QAA");
            pExtent.AddSystemInfo("Browser", "Chrome");
            pExtent.AddSystemInfo("Date", "12/10/2019");
            pExtent.AddSystemInfo("Version", "v1.0");
        }

        public string fnCaptureImage(IWebDriver pObjDriver, string pstrScreenName) 
        {
            /*Create screenshots directory*/
            ITakesScreenshot objITake = (ITakesScreenshot)pObjDriver;
            Screenshot objScreenshot = objITake.GetScreenshot();
            string strScreenshotPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string strScreenshotActualPath = strScreenshotPath.Substring(0, strScreenshotPath.LastIndexOf("bin"));
            string strProjectPath = new Uri(strScreenshotActualPath).LocalPath;
            Directory.CreateDirectory(strProjectPath + "ExtentReports\\Screenshots");
            /*Save Image*/
            string strFullPath = strScreenshotPath.Substring(0, strScreenshotPath.LastIndexOf("bin")) + "ExtentReports\\Screenshots";
            string strLocalPath = new Uri(strFullPath).LocalPath;
            objScreenshot.SaveAsFile(strLocalPath, ScreenshotImageFormat.Png);

            return strProjectPath;
        }

        public void fnTestCaseResult(ExtentTest pObjExtTest, ExtentReports pObjExtReports, IWebDriver pObjDriver)
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = (string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                ? "" : string.Format("0", TestContext.CurrentContext.Result.StackTrace));
            Status logstatus;
            switch (status)
            {
                case TestStatus.Failed :
                    logstatus = Status.Fail;
                    DateTime time = DateTime.Now;
                    string strFileName = "Screenshot_" + time.ToShortDateString() + ".png";
                    fnCaptureImage(pObjDriver, strFileName);
                    pObjExtTest.Log(Status.Fail, "");
                    pObjExtTest.Log(Status.Fail, "Snapshot bellow: " + pObjExtTest.AddScreenCaptureFromPath("Screenshots\\" + strFileName));
                    break;
            }
        }
    }
}
