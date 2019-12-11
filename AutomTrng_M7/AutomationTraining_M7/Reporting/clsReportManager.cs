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
            var strPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var strActualPath = strPath.Substring(0, strPath.LastIndexOf("bin"));
            var strProjectPath = new Uri(strActualPath).LocalPath;
            Directory.CreateDirectory(strProjectPath.ToString() + "ExtentReports");
            var strReportPath = strProjectPath + "ExtentReports\\ExtentReports.html";
            return strReportPath;
        }

        public void fnReportSetup(ExtentHtmlReporter phtmlReporter, ExtentReports pExtent)
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
            pExtent.AddSystemInfo("Browser:", "Chrome");
            pExtent.AddSystemInfo("Date:", "01/01/2019");
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
            var strFullPath = strSSPath.Substring(0, strSSPath.LastIndexOf("bin")) + "ExtentReports\\Screenshots";
            var strLocalPath = new Uri(strFullPath).LocalPath;
            objSS.SaveAsFile(strLocalPath, ScreenshotImageFormat.Png);
            return strReportPath;
        }

        public void fnTestCaseResult( ExtentTest pobjTest, ExtentReports pobjExtent, IWebDriver pobjDriver)
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
                    string strFileName = "Screenshots_" + time.ToString("h_mm-ss") + ".png";
                    fnCaptureImage(pobjDriver, strFileName);
                    pobjTest.Log(Status.Fail, "Fail");
                    pobjTest.Log(Status.Fail, "Snapshot below: " + pobjTest.AddScreenCaptureFromPath("Screenshots\\" + strFileName));
                    break;
            }
        }


    }
}
