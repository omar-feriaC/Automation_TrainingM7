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

        public void fnReportSetup(ExtentV3HtmlReporter phtmlReporter, ExtentReports pExtent)
        {
            //Elegir el Tema del reporte
            phtmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            //Elegir el título del reporte que aparece en la pestaña del navegador
            phtmlReporter.Config.DocumentTitle = "Automation Framework Report";
            //Agregar la información necesaria para el reporte.
            pExtent.AttachReporter(phtmlReporter);
            pExtent.AddSystemInfo("Project Name:", "Automation Framework");
            pExtent.AddSystemInfo("Application:", "LinkedIn");
            pExtent.AddSystemInfo("Environment:", "QA Automation");
            pExtent.AddSystemInfo("Browser:", ConfigurationManager.AppSettings.Get("Browser"));
            pExtent.AddSystemInfo("Date:", time.ToShortDateString());
            pExtent.AddSystemInfo("Version:", "v1.0");
        }

        //Función para tomar y guardar screenshots
        public string fnCaptureImage(IWebDriver pobjDriver, string pstrScreenName)
        {
            /*Create SS Directory*/
            ITakesScreenshot objITake = (ITakesScreenshot)pobjDriver;
            Screenshot objSS = objITake.GetScreenshot();
            var strSSPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var strSSActualPath = strSSPath.Substring(0, strSSPath.LastIndexOf("bin"));
            var strReportPath = new Uri(strSSActualPath).LocalPath;
            Directory.CreateDirectory(strReportPath.ToString() + "ExtentReports\\Screenshots");
            /*Save Image*/
            var strFullPath = strSSPath.Substring(0, strSSPath.LastIndexOf("bin")) + "ExtentReports\\Screenshots\\" + pstrScreenName;
            var strLocalPath = new Uri(strFullPath).LocalPath;
            objSS.SaveAsFile(strLocalPath, ScreenshotImageFormat.Png);
            return strLocalPath;
        }
        //Test case status
        public void fnTestCaseResult(ExtentTest pobjTest, ExtentReports pobjExtent, IWebDriver pobjDriver)
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var StackTrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                ? "" : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            Status logStatus;
            switch (status)
            {
                case TestStatus.Failed:
                    logStatus = Status.Fail;
                    DateTime time = DateTime.Now;
                    string strFileName = "Screenshots_" + time.ToString("h_mm_ss") + ".png";
                    fnCaptureImage(pobjDriver, strFileName);
                    pobjTest.Log(Status.Fail, "Fail");
                    pobjTest.Log(Status.Fail, "Snapshot below: " + pobjTest.AddScreenCaptureFromPath("Screenshots\\" + strFileName));
                    break;

                case TestStatus.Skipped:
                    logStatus = Status.Skip;
                    break;

                case TestStatus.Passed:
                    logStatus = Status.Pass;
                    time = DateTime.Now;
                    strFileName = "Screenshots_" + time.ToString("h_mm_ss") + ".png";
                    fnCaptureImage(pobjDriver, strFileName);
                    pobjTest.Log(Status.Pass, "Pass");
                    pobjTest.Log(Status.Pass, "Snapshot below: " + pobjTest.AddScreenCaptureFromPath("Screenshots\\" + strFileName));
                    break;

                default: logStatus = Status.Warning;
                    Console.WriteLine("The Status: " + status + " is not supported.");
                    break;
            }

            pobjTest.Log(logStatus, "Test end with " + logStatus + StackTrace);
            pobjExtent.Flush();
        }

        public static void fnAddStepLog(ExtentTest pobjTest, string pstrMessage, string pStatus)
        {
            pobjTest.Log(Status.Info, pstrMessage);
            switch (pStatus)
            {
                case "pass":// TestStatus.Passed:
                    pobjTest.Log(Status.Pass, pstrMessage);
                    break;
                case "Skip":
                    pobjTest.Log(Status.Skip, pstrMessage);
                    break;
                case "Warning":
                    pobjTest.Log(Status.Warning, pstrMessage);
                    break;
                case "Error":
                    pobjTest.Log(Status.Error, pstrMessage);
                    break;
                case "Fail":
                    pobjTest.Log(Status.Fail, pstrMessage);
                    break;
                case "Fatal":
                    pobjTest.Log(Status.Fatal, pstrMessage);
                    break;
                case "Info":
                    pobjTest.Log(Status.Info, pstrMessage);
                    break;
                case "Debug":
                    pobjTest.Log(Status.Debug, pstrMessage);
                    break;
                default:
                    pobjTest.Log(Status.Info, pstrMessage);
                    break;
            }

        }

        public void fnAddStepLogScreen(ExtentTest pobjTest, IWebDriver pobjDriver, string pstrMessage, string pstrImageName, string pStatus)
        {
            var strImagePath = fnCaptureImage(pobjDriver, pstrImageName);

            switch (pStatus)
            {
                case "Pass":
                    pobjTest.Pass(pstrMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "Skip":
                    pobjTest.Skip(pstrMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "Warning":
                    pobjTest.Warning(pstrMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "Error":
                    pobjTest.Error(pstrMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "Info":
                    pobjTest.Info(pstrMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "Fail":
                    pobjTest.Fail(pstrMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "Fatal":
                    pobjTest.Fatal(pstrMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "Debug":
                    pobjTest.Debug(pstrMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                default:
                    pobjTest.Info(pstrMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
            }

        }


    }
}
