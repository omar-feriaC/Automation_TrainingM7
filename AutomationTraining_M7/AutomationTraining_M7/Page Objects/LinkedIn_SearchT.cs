using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class LinkedIn_SearchT : BaseTest
    {
        private static IWebDriver _objDriver;

        readonly static string STR_SEARCH_FIELD = "//input[@placeholder='Search' or @placeholder='Buscar']";
        readonly static string STR_PEOPLE_FILTER = "//span[text()='Gente' or text()='People']";
        readonly static string STR_ALL_FILTERS = "//span[text()='Todos los filtros' or text()='All Filters']";
        readonly static string STR_LOCATION_FILTER = "//label[text()='México' or text()='Mexico']";
        readonly static string STR_LOCATION_FILTER2 = "//input[@placeholder='Añadir un país o región']";
        readonly static string STR_LANGUAGE_FILTER1 = "//label[text()='Inglés']";
        readonly static string STR_LANGUAGE_FILTER2 = "//label[text()='Español']";
        readonly static string STR_APPLY_BUTTON = "//button[@data-control-name ='all_filters_apply']";



        public LinkedIn_SearchT(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }

        /*IWEBELEMEMT OBJECTS*/
        private static IWebElement objSearchField => _objDriver.FindElement(By.XPath(STR_SEARCH_FIELD));
        private static IWebElement objPeopleFilter => _objDriver.FindElement(By.XPath(STR_PEOPLE_FILTER));
        private static IWebElement objAllFilters => _objDriver.FindElement(By.XPath(STR_ALL_FILTERS));
        private static IWebElement objLocationFilter => _objDriver.FindElement(By.XPath(STR_LOCATION_FILTER));
        private static IWebElement objLocationField => _objDriver.FindElement(By.XPath(STR_LOCATION_FILTER2));
        private static IWebElement objLanguageFilter1 => _objDriver.FindElement(By.XPath(STR_LANGUAGE_FILTER1));
        private static IWebElement objLanguageFilter2 => _objDriver.FindElement(By.XPath(STR_LANGUAGE_FILTER2));
        private static IWebElement objApplyBtn => _objDriver.FindElement(By.XPath(STR_APPLY_BUTTON));


        /*METHODS*/
        //User Name Txt
        private IWebElement GetSearchField()
        {
            return objSearchField;
        }

        public static void fnEnterSearchValue(string pstrSearchValue)
        {
            objSearchField.Clear();
            objSearchField.SendKeys(pstrSearchValue);
            objSearchField.SendKeys(Keys.Return);
            Task.Delay(1000).Wait();

        }
        
        private IWebElement GetPeopleFilter()
        {
            return objPeopleFilter;
        }

        public static void fnClickPeopleButton()
        {
            objPeopleFilter.Click();
        }

        private IWebElement GetAllFilters()
        {
            return objAllFilters;
        }

        public static void fnClickAllFiltersButton()
        {
            objAllFilters.Click();
        }

        private IWebElement GetLocationFilter()
        {
            return objLocationFilter;
        }

        public static void fnClickLocationButton()
        {
            objLocationFilter.Click();
        }

        private IWebElement GetLocationFilter2()
        {
            return objLocationField;
        }

        public static void fnEnterLocationValue(string pstrLocationValue)
        {
            objLocationField.Clear();
            objLocationField.SendKeys(pstrLocationValue);
            Task.Delay(2000).Wait();
            objLocationField.SendKeys(Keys.Down);
            objLocationField.SendKeys(Keys.Return);

        }

        private IWebElement GetLanguageButton1()
        {
            return objLanguageFilter1;
        }

        public static void fnClickLanguageButton1()
        {
            objLanguageFilter1.Click();
        }

        
        private IWebElement GetApplyButton()
        {
            return objApplyBtn;
        }

        public static void fnClickApplyButton()
        {
            objApplyBtn.Click();
        }

        
    }
}
    

