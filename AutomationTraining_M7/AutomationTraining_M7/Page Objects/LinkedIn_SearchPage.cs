using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomationTraining_M7.Page_Objects
{
    class LinkedIn_SearchPage : BaseTest
    {
        private static IWebDriver _driver;
        readonly static string strSearchBox = "//input[@placeholder='Buscar' or @placeholder='Search']";
        readonly static string strPeopelFilter = "//button[span[text()='Gente' or text()='People']]";
        //readonly static string strCheckMX = "//input[@id='sf-geoRegion-mx:0']";
        readonly static string strCheckMX = "//input[@placeholder='Añadir un país o región' or @placeholder='Add country or region']";
        readonly static string strApplicarFiltros = "//button[@data-control-name='all_filters_apply']";
        readonly static string strAllFiltersBtn = "//button[span[text()='Todos los filtros' or text()='All filters']]";
        readonly static string strName = "//spam[@class='actor-name']";
        readonly static string strRole = "//spam[@dir='ltr']";
        readonly static string strUrl = "//a[@data-control-name='search_srp_result'";
        private static IWebElement objSearchBox => _driver.FindElement(By.XPath(strSearchBox));
        private static IWebElement objUrl;// => _driver.FindElement(By.XPath(strUrl));
        private static IWebElement objRole;// => _driver.FindElement(By.XPath(strRole));
        private static IWebElement objName;// => _driver.FindElement(By.XPath(strName));

     
        private static IWebElement objPeopelFilter;// => _driver.FindElement(By.XPath(strPeopelFilter));
        private static IWebElement objCheckMX;// => _driver.FindElement(By.XPath(strCheckMX));
        private static IWebElement objApplicarFiltros;// => _driver.FindElement(By.XPath(strApplicarFiltros));
        private static IWebElement objAllFiltersBtn;// => _driver.FindElement(By.XPath(strAllFiltersBtn));
        //LiLinkedIn_LoginPage(driver);
        public LinkedIn_SearchPage() 
        {
            _driver = LinkedIn_LoginPage.fnDefaultLogIN(_driver);
        }
        public LinkedIn_SearchPage(IWebDriver pdriver)
        {
            _driver = pdriver;
        }
        public void fnGetSearch(string pobjSearchBox)
        {
            objSearchBox.Clear();
            objSearchBox.SendKeys(pobjSearchBox);
            objSearchBox.SendKeys(Keys.Return);
            WebDriverWait _driverWait;
            _driverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            IWebElement objValidatior;
            objValidatior = _driverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(strPeopelFilter)));
        }
        public void fnPeopelFilterClick() 
        {
            objPeopelFilter = _driver.FindElement(By.XPath(strPeopelFilter));
            objPeopelFilter.Click();
        }
        public void fnAllFiltersClick() 
        {
            objAllFiltersBtn = _driver.FindElement(By.XPath(strAllFiltersBtn));
            objAllFiltersBtn.Click();
            WebDriverWait _driverWait;
            _driverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            objApplicarFiltros = _driverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(strApplicarFiltros)));
            
        }
        public void fnApply() 
        {
            objApplicarFiltros.Click();
        }
        public void fnLanguajecheck(string ln) 
        {
            IWebElement objLNMX;
            objLNMX = _driver.FindElement(By.XPath("//input[@id='sf-profileLanguage-"+ ln + "']"));
            objLNMX.Click();
        }
        public void print(string pPrint) 
        {
            //imprimir consola nombre url rol
            objUrl = _driver.FindElement(By.XPath(strUrl));
            objRole = _driver.FindElement(By.XPath(strRole));
            objName = _driver.FindElement(By.XPath(strName));
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Technology search:" + pPrint);
            Console.WriteLine("Person Name: " + objRole.Text);
            Console.WriteLine("Person Rol: " + objName.Text);
            Console.WriteLine("Person URL: " + objUrl.GetAttribute("href"));
            
        }
        public void fnChecks() 
        {
            objCheckMX = _driver.FindElement(By.XPath(strCheckMX));
            objCheckMX.SendKeys("Mexico");
            objCheckMX.SendKeys(Keys.Return);
            objCheckMX.SendKeys("Italy");
            objCheckMX.SendKeys(Keys.Return);
        }

    }
}
