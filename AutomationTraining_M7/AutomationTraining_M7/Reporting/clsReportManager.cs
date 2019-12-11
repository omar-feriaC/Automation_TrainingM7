

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
/*

namespace AutomationTraining_M7.Reporting
{
    class clsReportManager
    { 
        //aqui se guardaran los reportes instruccion en html
        public string fnReportPath() {

            //reflection obtiene metadatos que puede contener una clase y que no son visibles.
            //indica en donde se generará el reporte
            var strPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase; // devuelve o identifica la ruta base del proyecto donde esta almacenada
            var strActualPath = strPath.Substring(0, strPath.LastIndexOf("bin"));  //busca la carpeta bin
            var strProjectPath = new Uri(strActualPath).LocalPath; //variable dinamica que crea localpath para meter mas informacion ahi
            Directory.CreateDirectory(strProjectPath.ToString() + "ExtentReports"); //el parametro es la ruta completa donde quiero que se genere el reporte / crea la carpeta
            // no importa el formato que traiga que lo convieerta a cadena
            var strReportPath = strProjectPath + "ExtentReports\\ExtenetReports.html"; // ruta del directorio & ruta del archivo, lo almacena en el variable no crea el archivo aun

            return strReportPath;
        }
        //configuracion
        public void fnReportSetUp (ExtentHtmlReporter phtmlReporter, ExtentReports pExtent) //funcion al ser void no necesita return/ el parametro se encarga de utilizar reports (configurar funcionalidad para indicar el ambiente a utilizar, proyecto, etc) y otro parametro para el extent report (framework)
        {
            phtmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;   //clase y funcionalidad del framework (extent reports), tema que quiere mostrar
            phtmlReporter.Config.DocumentTitle = "Automation Framework";
            pExtent.AttachReporter(phtmlReporter); // utiliza el objeto de extent
            pExtent.AddSystemInfo("Project Name:", "Automation Framework"); //informacion referente al proyecto, o web app (Name, Value)
            pExtent.AddSystemInfo("Application:", "Linkedin");
            pExtent.AddSystemInfo("Browser", "Chrome");
            pExtent.AddSystemInfo("Date", "00/00/2019");
            pExtent.AddSystemInfo("Version", "V1.0");
        }
        //logica para guardar imagenes
        public string fnCaptureImage(IWebDriver pobjDriver, string pstrScreenName ) //parametro a webdriver y como se guardara
        { 
            ITakesScreenshot objITake = (ITakesScreenshot)pobjDriver;   //funcionalidad de selenium, se utiliza la misma clase
            Screenshot objSS = objITake.GetScreenshot();
            //pobjDriver tiene la funcionaldad de la pagina a capturar
            var strSSPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var strActualPath = strSSPath.Substring(0, strSSPath.LastIndexOf("bin"));  //indico carpeta para las capturas de pantalla
            var strReportPath = new Uri(strActualPath).LocalPath; //SE OBTIENE INFORMACION de bin al local path

            //para guardar la imagen, cada vez que falle un scren se genera
            Directory.CreateDirectory(strReportPath.ToString() + "ExtentReports\\Screenshots");
            var strFullPath = strSSPath.Substring(0, strSSPath.LastIndexOf("bin")) + "ExtentReports\\Screenshots";
            var strLocalPath = new Uri(strFullPath).LocalPath;
            objSS.SaveAsFile(strLocalPath, ScreenshotImageFormat.Png);
            return strReportPath;

        }

        public  void fnTestCaseResult(ExtentTest pobjTest, ExtentReports pobjExtent, IWebDriver pobjDriver)//interpretara cada prueba indivivual
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status; //extent para crear reporte, pero para obtener el status de la ejecucion de pass o failed se invoca a NUnit
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)   // trae un valor en la condicion en caso que el test falle
            ? "" : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace); //si falla se llena la varialbe stracktrace
            Status logstatus; //variable extent reports

            switch (status) //trae valor de nUnit
            {
                case TestStatus.Failed // del valor que pasa nUnit 
                    logstatus = Status.Fail; // lo pasa a extent reports
                    DateTime time = DateTime.Now;
                    String strFileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";
                    fnCaptureImage(pobjDriver, strFileName);
                    pobjTest.Log(Status.Fail, "Fail");
                    pobjTest.Log(Status.Fail, "Snapshot below: " + pobjTest.AddScreenCaptureFromPath("Screenshots\\" + strFileName);)
                    Break;
            
            }

        }


    }


}
