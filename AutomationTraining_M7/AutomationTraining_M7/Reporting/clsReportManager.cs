using AutomationTraining_M7.Base_Files;
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
    class clsReportManager : BaseTest 
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

        public void fnReportSetUp(ExtentV3HtmlReporter phtmlReporter, ExtentReports pExtent)
        {
            phtmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            phtmlReporter.Config.DocumentTitle = "Automation Framework Report";
            pExtent.AttachReporter(phtmlReporter);
            pExtent.AddSystemInfo("Project Name:", ConfigurationManager.AppSettings.Get("project"));
            pExtent.AddSystemInfo("Application:", ConfigurationManager.AppSettings.Get("application"));
            pExtent.AddSystemInfo("Environment:", ConfigurationManager.AppSettings.Get("environment"));
            pExtent.AddSystemInfo("Browser:", ConfigurationManager.AppSettings.Get("browser"));
            pExtent.AddSystemInfo("Date:", time.ToShortDateString());
            pExtent.AddSystemInfo("Version:", ConfigurationManager.AppSettings.Get("version"));
        }

        public string fnCaptureImage(IWebDriver pobjDriver, string pstrScreenName)
        {
            /*Create SS directory*/
            ITakesScreenshot objITake = (ITakesScreenshot)pobjDriver;
            Screenshot objSS = objITake.GetScreenshot();
            var strSSPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var strActualPath = strSSPath.Substring(0, strSSPath.LastIndexOf("bin"));
            var strReportPath = new Uri(strActualPath).LocalPath;
            Directory.CreateDirectory(strReportPath.ToString() + "ExtentReports\\Screenshots");
            /*Save Image*/
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
                    string strFileName = "Screenshot_" + time.ToString("MMddyyyy_HHmmss") + ".png";
                    var strImagePath = fnCaptureImage(pobjDriver, strFileName);
                    pobjTest.Log(Status.Fail, "Fail");
                    pobjTest.Fail("Snapshot below: ", MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    string strFileName2 = "Screenshot_" + time.ToString("MMddyyyy_HHmmss") + ".png";
                    var strImagePath2 = fnCaptureImage(pobjDriver, strFileName2);
                    pobjTest.Log(Status.Skip, "Fail");
                    pobjTest.Skip("Snapshot below: ", MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath2).Build());
                    break;
                case TestStatus.Passed:
                    logstatus = Status.Pass;
                    string strFileName3 = "Screenshot_" + time.ToString("MMddyyyy_HHmmss") + ".png";
                    var strImagePath3 = fnCaptureImage(pobjDriver, strFileName3);
                    pobjTest.Log(Status.Pass, "Fail");
                    pobjTest.Pass("Snapshot below: ", MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath3).Build());
                    break;
                default:
                    logstatus = Status.Warning;
                    Console.WriteLine("The status: " + status + " is not supported.");
                    string strFileName4 = "Screenshot_" + time.ToString("MMddyyyy_HHmmss") + ".png";
                    var strImagePath4 = fnCaptureImage(pobjDriver, strFileName4);
                    pobjTest.Log(Status.Warning, "Fail");
                    pobjTest.Warning("Snapshot below: ", MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath4).Build());
                    break;
            }
            pobjTest.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            pobjExtent.Flush();
        }

        public void fnStepCaptureImage(ExtentReports pobjExtent, ExtentTest pobjTest, IWebDriver pobjDriver, string pMessage, string pstatus, string pImageName)
        {
            string strFileName;
            switch (pstatus)
            {
                case "Failed":

                    strFileName = "Screenshot_" + pImageName + "_Fail_" + time.ToString("MMddyyyy_HHmmss") + ".png";
                    fnCaptureImage(pobjDriver, strFileName);
                    pobjTest.Log(Status.Fail, pMessage + "_Fail", MediaEntityBuilder.CreateScreenCaptureFromPath("Screenshots\\" + strFileName).Build());
                    break;


                case "Passed":

                    strFileName = "Screenshot_" + pImageName + "_Pass_" + time.ToString("MMddyyyy_HHmmss") + ".png";
                    fnCaptureImage(pobjDriver, strFileName);
                    pobjTest.Log(Status.Pass, pMessage + "_Pass", MediaEntityBuilder.CreateScreenCaptureFromPath("Screenshots\\" + strFileName).Build());
                    break;
            }
        }


    }
}
