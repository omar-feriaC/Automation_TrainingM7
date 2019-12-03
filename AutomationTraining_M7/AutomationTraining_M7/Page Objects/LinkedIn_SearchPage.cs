using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class LinkedIn_SearchPage
    {
        /*DRIVER REFERENCE FOR POM*/
        private static IWebDriver _objDriver;

        /*LOCATORS FOR EACH ELEMENT*/
        readonly static string STR_SEARCH_TEXT = "search-global-typeahead__input";
        //readonly static string STR_PASSWORD_TEXT = "password";
        readonly static string STR_SEARCH_BTN = "search-typeahead-v2__button search-global-typeahead__button";
        readonly static string STR_PEOPLE_BTN = "//button[span[text()='People' or text()='Gente']]";
        readonly static string STR_ALLFILTERS_BTN = "//button[span[text()='All Filters' or text()='Todos los Filtros']]";
        readonly static string STR_MEXICO_CHKBOX = "//label[text()='Mexico']";
        readonly static string STR_SPANISH_CHKBOX = "//input[@ value = 'es']";
        readonly static string STR_ENGLISH_CHKBOX = "//input[@ value = 'en']";
        readonly static string STR_APPLYFILTERS_BTN = "//button[@data-control-name='all_filters_apply']";

        /*CONSTRUCTOR*/
        public LinkedIn_SearchPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }

        /*IWEBELEMEMT OBJECTS*/
        private static IWebElement ObjSearchTxt => _objDriver.FindElement(By.ClassName(STR_SEARCH_TEXT));
        private static IWebElement objSearchBtn => _objDriver.FindElement(By.ClassName(STR_SEARCH_BTN));
        private static IWebElement objPeopleBtn => _objDriver.FindElement(By.XPath(STR_PEOPLE_BTN));
        private static IWebElement objAllFiltersBtn => _objDriver.FindElement(By.XPath(STR_ALLFILTERS_BTN));
        private static IWebElement objMexicoChkbox => _objDriver.FindElement(By.XPath(STR_MEXICO_CHKBOX));
        private static IWebElement objSpanishChkbox => _objDriver.FindElement(By.XPath(STR_SPANISH_CHKBOX));
        private static IWebElement objEnglishChkbox => _objDriver.FindElement(By.XPath(STR_ENGLISH_CHKBOX));
        private static IWebElement objApplyFiltersBtn => _objDriver.FindElement(By.XPath(STR_APPLYFILTERS_BTN));
        public new static IWebDriver objDriver { get => _objDriver; set => _objDriver = value; }

        /*METHODS*/
        /*Search field*/
        private static IWebElement GetSearchField()
        {
            return ObjSearchTxt;
        }

        public static void fnEnterSearchCriteria(string strSearchCrt)
        {
            ObjSearchTxt.Clear();
            ObjSearchTxt.SendKeys(strSearchCrt);
        }
        /*Search button*/
        private static IWebElement GetSearchBtn()
        {
            return objSearchBtn;
        }

        public static void fnClickSearchButton()
        {
            ObjSearchTxt.Click();
        }
        /*Filter People button*/
        private static IWebElement GetPeopleBtn()
        {
            return objPeopleBtn;
        }
        
        internal static void fnClickPeopleButton()
        {
            objPeopleBtn.Click();
        }
        /*All filters button*/
        private static IWebElement GetAllFiltersBtn()
        {
            return objAllFiltersBtn;
        }

        internal static void fnClickAllFiltersButton()
        {
            objAllFiltersBtn.Click();
        }
        /*Location Mexico checkbox*/
        private static IWebElement GetMexicoChekbox()
        {
            return objMexicoChkbox;
        }

        internal static void fnClickMexicoCheckbox()
        {
            objMexicoChkbox.Click();
        }
        /*Spanish language checkbox*/
        private static IWebElement GetSpanishChekbox()
        {
            return objSpanishChkbox;
        }

        internal static void fnClickSpanishCheckbox()
        {
            objSpanishChkbox.Click();
        }
        /*English language checkbox*/
        private static IWebElement GetEnglishChekbox()
        {
            return objEnglishChkbox;
        }

        internal static void fnClickEnglishCheckbox()
        {
            objEnglishChkbox.Click();
        }
        /*Apply all filters button*/
        private static IWebElement GetApplyFiltersBtn()
        {
            return objApplyFiltersBtn;
        }

        internal static void fnClickApplyFiltersButton()
        {
            objApplyFiltersBtn.Click();
        }
    }
}
