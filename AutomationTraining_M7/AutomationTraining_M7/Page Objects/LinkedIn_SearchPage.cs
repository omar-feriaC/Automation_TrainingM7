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
        private static IWebDriver _objDriver;

        readonly static string SearchBox = "search-global-typeahead__input";
        //readonly static string SearchOptionOne = "//span[text()='Gente'] or //span[text()='People']";
        readonly static string SearchOptionOne = "//span[text()='People']";
        readonly static string SearchBtn = "//button[@class='search-typeahead-v2__button search-global-typeahead__button']";
        readonly static string SearchFilterBtn = "//span[text()='Todos los filtros'] | //span[text()='All Filters']";
        readonly static string CountryBox = "//input[@placeholder='Add a country/region']";
        readonly static string MexicoBtn = "//label[text()='Mexico' or text()='México']";
        readonly static string ItalyBtn = "//label[text()='Italy']";
        readonly static string EnglishChkbx = "//label[text()='English']";
        readonly static string SpanishChkbx = "//label[text()='Spanish']";
        readonly static string AplicarBtn = "//button[@data-control-name ='all_filters_apply']";
        readonly static string NameLbl = "//span[@class = 'actor-name']";
        readonly static string TitleLbl = "//p[@class = 'subline-level-1 t-14 t-black t-normal search-result__truncate']";
        readonly static string LocationLbl = "//p[@class = 'subline-level-2 t-12 t-black--light t-normal search-result__truncate']";


        public LinkedIn_SearchPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }
        private static IWebElement objSearchBox => _objDriver.FindElement(By.ClassName(SearchBox));
        private static IWebElement objSearchOption => _objDriver.FindElement(By.XPath(SearchOptionOne));
        private static IWebElement objSearchFilterBtn => _objDriver.FindElement(By.XPath(SearchFilterBtn));
        private static IWebElement objSearchCountryBox => _objDriver.FindElement(By.XPath(CountryBox));
        private static IWebElement objSearchMexicoChk => _objDriver.FindElement(By.XPath(MexicoBtn));
        private static IWebElement objSearchItalyChk => _objDriver.FindElement(By.XPath(ItalyBtn));
        private static IWebElement objSearchEnglishChk => _objDriver.FindElement(By.XPath(EnglishChkbx));
        private static IWebElement objSearchSpanishChk => _objDriver.FindElement(By.XPath(SpanishChkbx));
        private static IWebElement objAplicarBtn => _objDriver.FindElement(By.XPath(AplicarBtn));
        private static IWebElement objNameLbl => _objDriver.FindElement(By.XPath(NameLbl));
        private static IWebElement objTitleLbl => _objDriver.FindElement(By.XPath(TitleLbl));
        private static IWebElement objLocationLbl => _objDriver.FindElement(By.XPath(LocationLbl));

        public static void fnSearch(string strSearch)
        {
            objSearchBox.Clear();
            objSearchBox.SendKeys(strSearch);
            objSearchBox.SendKeys(Keys.Enter);
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
            objSearchCountryBox.SendKeys("Italy");
            objSearchCountryBox.SendKeys(Keys.ArrowDown);
            objSearchCountryBox.SendKeys(Keys.Enter);
            objSearchMexicoChk.Click();
            //objSearchItalyChk.Click();
        }
        public static void fnSelectLanguage(string[] arrLanguage)
        {
            foreach(string i in arrLanguage)
            {
                if (i == "Spanish")
                    objSearchSpanishChk.Click();
                else if (i == "English")
                    objSearchEnglishChk.Click();
            }
        }
        public static void fnAplicar()
        {
            objAplicarBtn.Click();
        }
        public static string fnGetName()
        {
            string strName = objNameLbl.Text;
            return strName;
        }
        public static string fnGetTitle()
        {
            string strTitle = objTitleLbl.Text;
            return strTitle;
        }
        public static string fnGetLocation()
        {
            string strLocation = objLocationLbl.Text;
            return strLocation;
        }



    }
}
