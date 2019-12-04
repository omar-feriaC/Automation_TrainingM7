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
        private static IWebDriver _objDriver;

        readonly static string SearchBox = "global-nav-typeahead";
        readonly static string SearchOptionOne = "//span[text()='Gente']";
        readonly static string SearchBtn = "//button[@class='search-typeahead-v2__button search-global-typeahead__button']";
        readonly static string SearchFilterBtn = "//span[text()='Todos los filtros']";
        readonly static string CountryBox = "//div[@class='ember-view']//input[@placeholder='Añadir un país o región']";
        readonly static string MexicoBtn = "//label[text()='México']";
        readonly static string ItalyBtn = "//label[text()='Italy']";
        readonly static string AplicarBtn = "//button[@class='search-advanced-facets__button--apply ml4 mr2 artdeco-button artdeco-button--3 artdeco-button--primary ember-view']//span[text()='Aplicar']";
        readonly static string NameLbl = "//span[contains(@class,'name actor-name')]";
        string Name;


        public LinkedIn_SearchPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }
        private static IWebElement objSearchBox => _objDriver.FindElement(By.Id(SearchBox));
        private static IWebElement objSearchOption => _objDriver.FindElement(By.XPath(SearchOptionOne));
        private static IWebElement objSearchBtn => _objDriver.FindElement(By.XPath(SearchBtn));
        private static IWebElement objSearchFilterBtn => _objDriver.FindElement(By.XPath(SearchFilterBtn));
        private static IWebElement objSearchCountryBox => _objDriver.FindElement(By.XPath(CountryBox));
        private static IWebElement objSearchMexicoChk => _objDriver.FindElement(By.XPath(MexicoBtn));
        private static IWebElement objSearchItalyChk => _objDriver.FindElement(By.XPath(ItalyBtn));
        private static IWebElement objAplicarBtn => _objDriver.FindElement(By.XPath(AplicarBtn));
        private static IWebElement objNameLbl => _objDriver.FindElement(By.XPath(NameLbl));

        public static void fnSearch(string strSearch)
        {
            objSearchBox.Clear();
            objSearchBox.SendKeys(strSearch);
            objSearchBtn.Click();
        }
        public static void fnSelectGente()
        {
            objSearchOption.Click();
        }
        public static void fnSelectFilters()
        {
            objSearchFilterBtn.Click();
        }
        public static void fnSelectCountry()
        {
            fnSelectFilters();
            objSearchCountryBox.SendKeys("Italy");
            objSearchCountryBox.SendKeys(Keys.Enter);
            objSearchMexicoChk.Click();
            //objSearchItalyChk.Click();
        }
        public static void fnAplicar()
        {
            objAplicarBtn.Click();
        }
        //private IWebElement GetName()
        //{
        //    Name = objNameLbl.ToString();
        //    return Name;
        //}



    }
}
