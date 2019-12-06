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
        //Xpath object references
        readonly static string strSearchBox = "//input[@placeholder='Buscar' or @placeholder='Search']";
        readonly static string strPeopelFilter = "//*[span[text()='Gente' or text()='People']]";
        readonly static string strCheckMX = "//input[@placeholder='Añadir un país o región' or @placeholder='Add country or region']";
        readonly static string strApplicarFiltros = "//button[@data-control-name='all_filters_apply']";
        readonly static string strAllFiltersBtn = "//button[span[text()='Todos los filtros' or text()='All filters']]";
        readonly static string strName = "//span[@class='actor-name']";
        readonly static string strRole = "//p[contains(@class,'result__truncate')]";
        readonly static string strUrl = "//a[span[@class='actor-name']]";
        //Base search text box
        private static IWebElement objSearchBox => _driver.FindElement(By.XPath(strSearchBox));
        //Search Result Objects
        private static IWebElement objUrl;
        private static IWebElement objRole;
        private static IWebElement objName;
        //Filter Objects
        private static IWebElement objPeopelFilter;
        private static IWebElement objCheckLocation;
        private static IWebElement objApplicarFiltros;
        private static IWebElement objAllFiltersBtn;
        
        public LinkedIn_SearchPage() 
        {
            _driver = LinkedIn_LoginPage.fnDefaultLogIN(_driver);
        }
        public IWebDriver fnGetDriver()
        {
            return _driver;
        }
        public LinkedIn_SearchPage(IWebDriver pdriver)
        {
            _driver = pdriver;
            WebDriverWait _driverWait;
            _driverWait = new WebDriverWait(_driver, new TimeSpan(0, 0, 60));
            IWebElement objValidatior;
            objValidatior = _driverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(strSearchBox)));
        }
        public void fnSetDriver(IWebDriver pdriver)
        {
            _driver = pdriver;
        }
        public void fnDoASearch(string pstrSearchBox)
        {
            //Type the tx in the text box end with enter key
            objSearchBox.Clear();
            objSearchBox.SendKeys(pstrSearchBox);
            objSearchBox.SendKeys(Keys.Enter);
            //Wait until the page refresh
            WebDriverWait _driverWait;
            _driverWait = new WebDriverWait(_driver, new TimeSpan(0, 0, 60));
            IWebElement objValidatior;
            objValidatior = _driverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(strPeopelFilter)));
        }
        public void fnPeopelFilterClick() 
        {
            //find the object 
            objPeopelFilter = _driver.FindElement(By.XPath(strPeopelFilter));
            objPeopelFilter.Click();
        }
        public void fnAllFiltersClick() 
        {
            objAllFiltersBtn = _driver.FindElement(By.XPath(strAllFiltersBtn));
            objAllFiltersBtn.Click();
            WebDriverWait _driverWait;
            _driverWait = new WebDriverWait(_driver, new TimeSpan(0, 0, 60));
            objApplicarFiltros = _driverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(strApplicarFiltros)));
            
        }
        public void fnApplyFilters() 
        {
            objApplicarFiltros.Click();
        }
        public void fnLanguageCheck(string ln) 
        {
            IWebElement objLNMX;
            string strl;
            switch (ln) 
            {
                case "Spanish": strl = "es"; break;
                case "English": strl = "en"; break;
                default: strl = "es"; break;
            }
            objLNMX = _driver.FindElement(By.XPath("//label[@for='sf-profileLanguage-" + strl + "']"));
            objLNMX.Click();
        }
        public void fnPrintResults(string pPrint) 
        {
            //Print results in console 
            objUrl = _driver.FindElement(By.XPath(strUrl));
            objRole = _driver.FindElement(By.XPath(strRole));
            objName = _driver.FindElement(By.XPath(strName));
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Technology search: " + pPrint);
            Console.WriteLine("Person Name: " + objRole.Text);
            Console.WriteLine("Person Rol: " + objName.Text);
            Console.WriteLine("Person URL: " + objUrl.GetAttribute("href"));
            
        }
        public void fnLocationChecks() 
        {
            objCheckLocation = _driver.FindElement(By.XPath(strCheckMX));
            objCheckLocation.Clear();
            objCheckLocation.SendKeys("México");
            objCheckLocation.SendKeys(Keys.ArrowDown);
            objCheckLocation.SendKeys(Keys.Enter);
            //-----------------------------------------------------------
            objCheckLocation.Clear();
            objCheckLocation.SendKeys("Italy");
            objCheckLocation.SendKeys(Keys.ArrowDown);
            objCheckLocation.SendKeys(Keys.Enter);
            
        }

    }
}
