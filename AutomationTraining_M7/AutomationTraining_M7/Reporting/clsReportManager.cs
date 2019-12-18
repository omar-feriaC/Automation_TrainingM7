﻿using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.Configuration;
>>>>>>> master
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace AutomationTraining_M7.Reporting {
    class clsReportManager {
=======
namespace AutomationTraining_M7.Reporting
{
    class clsReportManager
    {
        private DateTime time = DateTime.Now;
        private string strImagePath;

>>>>>>> master
        public string fnReportPath()
        {
            var strPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var strActualPath = strPath.Substring(0, strPath.LastIndexOf("bin"));
            var strProjectPath = new Uri(strActualPath).LocalPath;
            Directory.CreateDirectory(strProjectPath.ToString() + "ExtentReports");
<<<<<<< HEAD
            var strReportPath = strProjectPath + "ExtentReports\\ExtentReports.html";
            return strReportPath;
        }

        public void fnReportSetUp(ExtentHtmlReporter phtmlReporter,ExtentReports pExtent)
=======
            var strReportPath = strProjectPath + "ExtentReports\\ExtentReports_" + time.ToString("MMddyyyy_HHmmss") + ".html";
            return strReportPath;
        }

        //public void fnReportSetUp(ExtentHtmlReporter phtmlReporter, ExtentReports pExtent)
        public void fnReportSetUp(ExtentV3HtmlReporter phtmlReporter, ExtentReports pExtent)
>>>>>>> master
        {
            phtmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            phtmlReporter.Config.DocumentTitle = "Automation Framework Report";
            pExtent.AttachReporter(phtmlReporter);
            pExtent.AddSystemInfo("Project Name:", "Automation Framework");
<<<<<<< HEAD
            pExtent.AddSystemInfo("Application:", "LinkeIn");
            pExtent.AddSystemInfo("Environment", "QAA");
            pExtent.AddSystemInfo("Browser:", "Chrome");
            pExtent.AddSystemInfo("Date:", "00/00/2019");
            pExtent.AddSystemInfo("Version:", "v1.0");
        }

        public string fnCaptureImage(IWebDriver pobjDriver, string ptrScreenName)
        {
            //Create Directory
=======
            pExtent.AddSystemInfo("Application:", "LinkedIn");
            pExtent.AddSystemInfo("Environment:", "QAA");
            pExtent.AddSystemInfo("Browser:", ConfigurationManager.AppSettings.Get("browser"));
            pExtent.AddSystemInfo("Date:", time.ToShortDateString());
            pExtent.AddSystemInfo("Version:", "v1.0");
        }

        public string fnCaptureImage(IWebDriver pobjDriver, string pstrScreenName)
        {
            /*Create SS directory*/
>>>>>>> master
            ITakesScreenshot objITake = (ITakesScreenshot)pobjDriver;
            Screenshot objSS = objITake.GetScreenshot();
            var strSSPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var strActualPath = strSSPath.Substring(0, strSSPath.LastIndexOf("bin"));
            var strReportPath = new Uri(strActualPath).LocalPath;
            Directory.CreateDirectory(strReportPath.ToString() + "ExtentReports\\Screenshots");
<<<<<<< HEAD
            //Save Image
            var strFullPath = strSSPath.Substring(0, strSSPath.LastIndexOf("bin")) + "ExtentReports\\Screenshots";
            var strLocalPath = new Uri(strFullPath).LocalPath;
            objSS.SaveAsFile(strLocalPath, ScreenshotImageFormat.Png);
            return strReportPath;
        }

        public void fnTestCaseResult(ExtentTest pobjTest, ExtentReports pobExtent, IWebDriver pobjDriver)
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                ? "" : string.Format("{0}",TestContext.CurrentContext.Result.StackTrace);
=======
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
>>>>>>> master
            Status logstatus;
            switch (status)
            {
                case TestStatus.Failed:
                    logstatus = Status.Fail;
<<<<<<< HEAD
                    DateTime time = DateTime.Now;
                    string strFileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";
                    fnCaptureImage(pobjDriver, strFileName);
                    pobjTest.Log(Status.Fail, "Fail");
                    pobjTest.Log(Status.Fail, "Snapshot below: " 
                        + pobjTest.AddScreenCaptureFromPath("Screenshots\\" + strFileName));
=======
                    //DateTime time = DateTime.Now;
                    //string strFileName = "Screenshot_" + time.ToShortDateString() + ".png";
                    string strFileName = "Screenshot_" + time.ToString("hh_mm_ss") + ".png";
                    var strImagePath = fnCaptureImage(pobjDriver, strFileName);
                    pobjTest.Log(Status.Fail, "Fail");
                    pobjTest.Fail("Snapshot below: ", MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    //pobjTest.Log(Status.Fail, "Snapshot below: " + pobjTest.AddScreenCaptureFromPath("Screenshots\\" + strFileName));
>>>>>>> master
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    break;
                case TestStatus.Passed:
                    logstatus = Status.Pass;
                    break;
                default:
                    logstatus = Status.Warning;
<<<<<<< HEAD
                    Console.WriteLine("The statuus: " + status + " is not supported.");
                    break;

            }
            pobjTest.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            
        }
=======
                    Console.WriteLine("The status: " + status + " is not supported.");
                    break;
            }
            pobjTest.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            pobjExtent.Flush();
        }

>>>>>>> master
    }
}
