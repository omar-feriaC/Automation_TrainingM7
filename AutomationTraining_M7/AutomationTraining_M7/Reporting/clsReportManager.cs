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
        private DateTime time = DateTime.Now;
        public string fnReportPath()
        {
            var strPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var strActualPath = strPath.Substring(0, strPath.LastIndexOf("bin"));
            var strProjectPath = new Uri(strActualPath).LocalPath;
            Directory.CreateDirectory(strProjectPath.ToString() + "ExtentReports");
            var strReportPath = strProjectPath + "ExtentReports\\ExtentReports_" + time.ToString("MMddyyyy_HHmmss") + ".html";
            return strReportPath;
        }
        //public void fnReportSetUp(ExtentHtmlReporter phtmlReporter, ExtentReports pExtent)
        public void fnReportSetUp(ExtentV3HtmlReporter phtmlReporter, ExtentReports pExtent)
        {
            phtmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            phtmlReporter.Config.DocumentTitle = "Automation Framework Report";
            pExtent.AttachReporter(phtmlReporter);
            pExtent.AddSystemInfo("Project Name:", "Automation Framework");
            pExtent.AddSystemInfo("Application:", "LinkedIn");
            pExtent.AddSystemInfo("Environment:", "QAA");
            pExtent.AddSystemInfo("Browser:", ConfigurationManager.AppSettings.Get("browser"));
            pExtent.AddSystemInfo("Date:", time.ToShortDateString());
            pExtent.AddSystemInfo("Version:", "v1.0");
        }
        public string fnCaptureImage(IWebDriver pobjDriver, string pstrScreenName)
        {
            // Create SS directory
            ITakesScreenshot objITake = (ITakesScreenshot)pobjDriver;
            Screenshot objSS = objITake.GetScreenshot();
            var strSSPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var strActualPath = strSSPath.Substring(0, strSSPath.LastIndexOf("bin"));
            var strReportPath = new Uri(strActualPath).LocalPath;
            Directory.CreateDirectory(strReportPath.ToString() + "ExtentReports\\Screenshots");
            // Save Image
            var strFullPath = strSSPath.Substring(0, strSSPath.LastIndexOf("bin")) + "ExtentReports\\Screenshots\\" + pstrScreenName;
            var strLocalPath = new Uri(strFullPath).LocalPath;
            objSS.SaveAsFile(strLocalPath, ScreenshotImageFormat.Png);
            return strLocalPath;
        }
        public void fnTestCaseResult(ExtentTest pobjTest, ExtentReports pobjExtent, IWebDriver pobjDriver)
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
           ? "" : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            Status logstatus;
            switch (status)
            {
                case TestStatus.Failed:
                    logstatus = Status.Fail;
                    //DateTime time = DateTime.Now;
                    //string strFileName = "Screenshot_" + time.ToShortDateString() + ".png";
                    string strFileName = "Screenshot_" + time.ToString("hh_mm_ss") + ".png";
                    var strImagePath = fnCaptureImage(pobjDriver, strFileName);
                    pobjTest.Log(Status.Fail, "Fail");
                    pobjTest.Fail("Snapshot below: ", MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    //pobjTest.Log(Status.Fail, "Snapshot below: " + pobjTest.AddScreenCaptureFromPath("Screenshots\\" + strFileName));
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    break;
                case TestStatus.Passed:
                    logstatus = Status.Pass;
                    break;
                default:
                    logstatus = Status.Warning;
                    Console.WriteLine("The status: " + status + " is not supported.");
                    break;
            }
            pobjTest.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            pobjExtent.Flush();
        }
        // Add Each Step to Log
        public void fnAddLogStep(ExtentTest pobjTest, string pstrMsg, string pStatus)
        {
            pobjTest.Log(Status.Info, pstrMsg);
            switch (pStatus)
            {
                case "Passed":// TestStatus.Passed:
                    pobjTest.Log(Status.Pass, pstrMsg);
                    break;
                case "Skip":
                    pobjTest.Log(Status.Skip, pstrMsg);
                    break;
                case "Warning":
                    pobjTest.Log(Status.Warning, pstrMsg);
                    break;
                case "Error":
                    pobjTest.Log(Status.Error, pstrMsg);
                    break;
                case "Fail":
                    pobjTest.Log(Status.Fail, pstrMsg);
                    break;
                case "Fatal":
                    pobjTest.Log(Status.Fatal, pstrMsg);
                    break;
                case "Info":
                    pobjTest.Log(Status.Info, pstrMsg);
                    break;
                case "Debug":
                    pobjTest.Log(Status.Debug, pstrMsg);
                    break;
                default:
                    pobjTest.Log(Status.Info, pstrMsg);
                    break;
            }
        }
        public void fnAddLogStepScreen(ExtentTest pobjTest, IWebDriver pobjDriver, string pstrMsg, string pstrImageName, string pStatus)
        {
            var strImagePath = fnCaptureImage(pobjDriver, pstrImageName);

            switch (pStatus)
            {
                case "Passed":
                    pobjTest.Pass(pstrMsg, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "Skip":
                    pobjTest.Skip(pstrMsg, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "Warning":
                    pobjTest.Warning(pstrMsg, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "Error":
                    pobjTest.Error(pstrMsg, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "Info":
                    pobjTest.Info(pstrMsg, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "Fail":
                    pobjTest.Fail(pstrMsg, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "Fatal":
                    pobjTest.Fatal(pstrMsg, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "Debug":
                    pobjTest.Debug(pstrMsg, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                default:
                    pobjTest.Info(pstrMsg, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
            }
        }
    }
}
