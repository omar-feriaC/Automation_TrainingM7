using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
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
        readonly static string strCheckMX = "//input[@id='sf-geoRegion-mx:0']";
        readonly static string strCheckIt = "//input[@id='sf-geoRegion-it:1136']";
        readonly static string strApplicarFiltros = "//button[span[text()='Aplicar' or text()='Apply']]";
        readonly static string strAllFiltersBtn = "//button[span[text()='Todos los filtros' or text()='All filters']]";
       
        readonly static string strname = "//";
        readonly static string strrole = "//";
        readonly static string strUrl = "//";
        private static IWebElement objUrl => _driver.FindElement(By.XPath(strUrl));
        private static IWebElement objRole => _driver.FindElement(By.XPath(strrole));
        private static IWebElement objName => _driver.FindElement(By.XPath(strname));
        private static IWebElement objSearchBox => _driver.FindElement(By.XPath(strSearchBox));
        private static IWebElement objPeopelFilter => _driver.FindElement(By.XPath(strPeopelFilter));
        private static IWebElement objCheckMX => _driver.FindElement(By.XPath(strCheckMX));
        private static IWebElement objCheckIt => _driver.FindElement(By.XPath(strCheckIt));
        private static IWebElement objApplicarFiltros => _driver.FindElement(By.XPath(strApplicarFiltros));
        private static IWebElement objAllFiltersBtn => _driver.FindElement(By.XPath(strAllFiltersBtn));
        //LiLinkedIn_LoginPage(driver);
        public LinkedIn_SearchPage() 
        {
            _driver = LinkedIn_LoginPage.fnDefaultLogIN(_driver);
        }
        public void fnGetSearch(string pobjSearchBox)
        {
            objSearchBox.Clear();
            objSearchBox.SendKeys(pobjSearchBox);
            objSearchBox.SendKeys(Keys.Return);
        }
        public void fnPeopelFilterClick() 
        {
            objPeopelFilter.Click();
        }
        public void fnAllFiltersClick() 
        {
            objAllFiltersBtn.Click();
            objApplicarFiltros.Click();
        }

        public void fnLanguajecheck(string ln) 
        {
            IWebElement objLNMX;
            objLNMX = _driver.FindElement(By.XPath("//input[@id='sf-profileLanguage-"+ ln + "']"));
            objLNMX.Click();
        }
        public void print() 
        { 
         //imprimir consola nombre url rol
        }
        public void fnChecks() 
        {
            objCheckMX.Click();
            objCheckIt.Click();;
        }

    }
}
