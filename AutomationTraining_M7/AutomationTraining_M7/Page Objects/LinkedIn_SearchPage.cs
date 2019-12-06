using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class LinkedIn_SearchPage
    {
        /*DRIVER REFERENCE FOR POM*/
        private static IWebDriver _objDriver;

        /*LOCATORS FOR EACH ELEMENT*/
        readonly static string STR_SEARCH_TEXT = "search-global-typeahead__input";
        readonly static string STR_SEARCH_BTN = "//div[@class='search-global-typeahead__controls']";
        readonly static string STR_PEOPLE_BTN = "//button[span[text()='People' or text()='Gente']]";
        readonly static string STR_ALLFILTERS_BTN = "//button[span[text()='All Filters' or text()='Todos los Filtros']]";
        readonly static string STR_MEXICO_CHKBOX = "//label[text()='Mexico' or text()='México']";
        readonly static string STR_SPANISH_CHKBOX = "//label[text()='Spanish' or text()='Español']";
        readonly static string STR_ENGLISH_CHKBOX = "//label[text()='English' or text()='Ingles']";
        readonly static string STR_APPLYFILTERS_BTN = "//button[@data-control-name='all_filters_apply']";
        readonly static string STR_LOCITALY_TEXT = "//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Italy']";
        readonly static string STR_LOCMEXICO_TEXT = "//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Mexico']";
        readonly static string STR_LOCATION_TEXT = "//input[@placeholder='Add a country/region' or @placeholder='Añadir un país o región']";
        readonly static string STR_ITALY_CHKBOX = "//label[text()='Italy' or text()='Italia']";
        readonly static string STR_SEARCHRESULTSNAME_SPAN = "(//span[@class='actor-name'])[1]";
        readonly static string STR_SEARCHRESULTSROLE_SPAN = "(//p[@class='subline-level-1 t-14 t-black t-normal search-result__truncate']//span[@dir='ltr'])[1]";
        readonly static string STR_SEARCHRESULTSURL_A = "(//a[@data-control-name='search_srp_result'])[1]";


        /*CONSTRUCTOR*/
        public LinkedIn_SearchPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }

        /*IWEBELEMEMT OBJECTS*/
        private static IWebElement ObjSearchTxt => _objDriver.FindElement(By.ClassName(STR_SEARCH_TEXT));
        private static IWebElement objSearchBtn => _objDriver.FindElement(By.XPath(STR_SEARCH_BTN));
        private static IWebElement objPeopleBtn => _objDriver.FindElement(By.XPath(STR_PEOPLE_BTN));
        private static IWebElement objAllFiltersBtn => _objDriver.FindElement(By.XPath(STR_ALLFILTERS_BTN));
        private static IWebElement objMexicoChkbox => _objDriver.FindElement(By.XPath(STR_MEXICO_CHKBOX));
        private static IWebElement objSpanishChkbox => _objDriver.FindElement(By.XPath(STR_SPANISH_CHKBOX));
        private static IWebElement objEnglishChkbox => _objDriver.FindElement(By.XPath(STR_ENGLISH_CHKBOX));
        private static IWebElement objApplyFiltersBtn => _objDriver.FindElement(By.XPath(STR_APPLYFILTERS_BTN));
        private static IWebElement objLocationFilterTxt => _objDriver.FindElement(By.XPath(STR_LOCATION_TEXT));
        private static IWebElement objLocationMexicoTxt => _objDriver.FindElement(By.XPath(STR_LOCMEXICO_TEXT));
        private static IWebElement objLocationItalyTxt => _objDriver.FindElement(By.XPath(STR_LOCITALY_TEXT));
        private static IWebElement objNameSpan => _objDriver.FindElement(By.XPath(STR_SEARCHRESULTSNAME_SPAN));
        private static IWebElement objRoleSpan => _objDriver.FindElement(By.XPath(STR_SEARCHRESULTSROLE_SPAN));
        private static IWebElement objUrlA => _objDriver.FindElement(By.XPath(STR_SEARCHRESULTSURL_A));
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
            ObjSearchTxt.SendKeys(Keys.Enter);
        }

        /*Search button*/
        private static IWebElement GetSearchBtn()
        {
            return objSearchBtn;
        }

        public static void fnClickSearchButton()
        {
            objSearchBtn.Click();
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

        //Select region txt filter    
        private static IWebElement GetLocationsFilterfield()
        {
            return objLocationFilterTxt;
        }
        public static void fnEnterLocationCriteria(string strLocationCrt)
        {
            objLocationFilterTxt.Clear();
            objLocationFilterTxt.SendKeys(strLocationCrt);
        }
        /*Location Italy dropdown text*/
        private static IWebElement GetItalyTxt()
        {
            return objLocationItalyTxt;
        }

        internal static void fnClickItalyTxt()
        {
            objLocationItalyTxt.Click();
        }
        /*Location Mexico dropdown text*/
        private static IWebElement GetMexicoTxt()
        {
            return objLocationMexicoTxt;
        }

        internal static void fnClickMexicoTxt()
        {
            objLocationMexicoTxt.Click();
        }
        /*Get name*/
        public static IWebElement GetNameSpan()
        {
            return objNameSpan;
        }
        /*Get role*/
        public static IWebElement GetRoleSpan()
        {
            return objRoleSpan;
        }
        /*Get Url*/
        public static IWebElement GetUrlA()
        {
            return objUrlA;
        }







        //Wait
        internal static void fnWaitPage()
        {
            Thread.Sleep(3000);
        }
    }
}
