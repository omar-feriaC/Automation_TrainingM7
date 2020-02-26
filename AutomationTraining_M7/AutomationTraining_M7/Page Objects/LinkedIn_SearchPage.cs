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

        /*LOCATORS FOR EACH ELEMENT*/
        private static IWebDriver _ObjSrcDriver;
        readonly static string STR_CAPTCHA_CLK = "//div[@class='recaptcha-checkbox-checkmark']";
        readonly static string STR_APPLY_BTN = "//button[@data-control-name='all_filters_apply']";
        readonly static string STR_SEARCH_BTN = "//div[@class='search-global-typeahead__controls']";
        readonly static string STR_SEARCH_TEXT = "//input[@placeholder='Search' or @placeholder='Buscar']";
        readonly static string STR_PEOPLE_BTN = "//button[span[text()='People' or text()='Gente']]";
        readonly static string STR_ALLFILTERS_BTN = "//button[span[text()='All Filters' or text()='Todos los filtros']]";
        readonly static string STR_LANG_ENG_CB = "//label[text()='English' or text()='Ingles' or text()='Inglés']";
        readonly static string STR_LANG_ESP_CB = "//label[text()='Spanish' or text()='Español']";
        readonly static string STR_REGIONMX_CB = "//label[text()='Mexico' or text()='México']";
        readonly static string STR_ADDCOUNTTRY_TEXT = "//input[@placeholder='Add a country/region' or @placeholder='Añadir un país o región'][@aria-label='Add a country/region' or @aria-label='Añadir un país o región']";
        readonly static string STR_SELECT_MEXICO_DD = "//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Mexico' or 'México']";
        readonly static string STR_CLEAR_FILTERS = "//div[@id='inbug-nav-item']";
        //readonly static string STR_TOTAL_RESULTS_WO = "/html/body/div[5]/div[5]/div[4]/div/div[2]/div/div[2]/div/div/div/div/ul";
        readonly static string STR_TOTAL_RESULTS_WO = "//ul[@class='search-results__list list-style-none ']/li/div/div[1]/div[2]/a/h3/span/span/span[1]";

        //test
        /*CONSTRUCTOR*/
        public LinkedIn_SearchPage(IWebDriver pobjSrcDriver)
        {
            _ObjSrcDriver = pobjSrcDriver;
        }

        /*IWEBELEMEMT OBJECTS*/
        private static IWebElement objCaptcha => _ObjSrcDriver.FindElement(By.XPath(STR_CAPTCHA_CLK));
        private static IWebElement objSearchText => _ObjSrcDriver.FindElement(By.XPath(STR_SEARCH_TEXT));
        private static IWebElement objSearchBtn => _ObjSrcDriver.FindElement(By.XPath(STR_SEARCH_BTN));
        private static IWebElement objPeopleBtn => _ObjSrcDriver.FindElement(By.XPath(STR_PEOPLE_BTN));
        private static IWebElement objAllFiltersBtn => _ObjSrcDriver.FindElement(By.XPath(STR_ALLFILTERS_BTN));
        private static IWebElement objRegionMxCb => _ObjSrcDriver.FindElement(By.XPath(STR_REGIONMX_CB));
        private static IWebElement objLangEngCb => _ObjSrcDriver.FindElement(By.XPath(STR_LANG_ENG_CB));
        private static IWebElement objLangEspCb => _ObjSrcDriver.FindElement(By.XPath(STR_LANG_ESP_CB));
        private static IWebElement objApplyBtn => _ObjSrcDriver.FindElement(By.XPath(STR_APPLY_BTN));
        private static IWebElement objAddCountryTxt => _ObjSrcDriver.FindElement(By.XPath(STR_ADDCOUNTTRY_TEXT));
        private static IWebElement objSelectMexicoDD => _ObjSrcDriver.FindElement(By.XPath(STR_SELECT_MEXICO_DD));
        private static IWebElement objClearFilters => _ObjSrcDriver.FindElement(By.XPath(STR_CLEAR_FILTERS));
        //private static List<IWebElement> objAllResultsPage => _ObjSrcDriver.FindElements(By.XPath(STR_TOTAL_RESULTS_WO));


        /*METHODS*/
        //Captcha
        private IWebElement GetCaptcha()
        {
            return objCaptcha;
        }

        public static void fnClickCaptcha()
        {
            objCaptcha.Click();
        }

        //Search Txt
        private IWebElement GetSearchField()
        {
            return objSearchText;
        }

        public static void fnEnterSearchText(string pstrSearchText)
        {
            objSearchText.Click();
            objSearchText.Clear();
            objSearchText.SendKeys(pstrSearchText);
        }

        //Search Button
        private IWebElement GetSearchButton()
        {
            return objSearchBtn;
        }

        public static void fnClickSearchBtn()
        {
            objSearchBtn.Click();
        }

        //People Checkbox
        public static IWebElement GetPeopleCB()
        {
            return objPeopleBtn;
        }

        public static void fnSelectPeople()
        {
            objPeopleBtn.Click();
        }

        //All Filters button
        private IWebElement GetAllFilters()
        {
            return objAllFiltersBtn;
        }

        public static void fnSelectAllFilters()
        {
            objAllFiltersBtn.Click();
        }

        //Location Mexico
        private IWebElement GetRegionMx()
        {
            return objRegionMxCb;
        }

        public static void fnGetRegionMx()
        {
            objRegionMxCb.Click();
        }

        //Language English
        private IWebElement GetLanguageEng()
        {
            return objLangEngCb;
        }
        //private IWebElement GetAllResultsPage()
        //{
        //    return objAllResultsPage;
        //}

        public static void fnLanguageEng()
        {
            objLangEngCb.Click();
        }

        public static void fnSelectLanguage(string pstrLanguage)
        {
            IWebElement objLanguageOption = _ObjSrcDriver.FindElement(By.XPath($"//*[text()='{pstrLanguage}']"));
            objLanguageOption.Click();
        }

        //Language Espanish
        private IWebElement GetLanguageEsp()
        {
            return objLangEspCb;
        }

        public static void fnLanguageEsp()
        {
            objLangEspCb.Click();
        }

        //Apply the Filters
        private IWebElement GetApplybutton()
        {
            return objApplyBtn;
        }

        public static void fnClickApplyBtn()
        {
            objApplyBtn.Click();
        }


        private IWebElement AddCountry()
        {
            return objAddCountryTxt;
        }



        public static void fnAddCountry(string pstrAddCountry)
        {
            objAddCountryTxt.Click();
            objAddCountryTxt.Clear();
            objAddCountryTxt.SendKeys(pstrAddCountry);
        }

        private IWebElement SelectMexico()
        {
            return objSelectMexicoDD;
        }


        public static void fnSelectMexico()
        {
            objSelectMexicoDD.Click();
        }

        private IWebElement ClearFilters()
        {
            return objClearFilters;
        }

        public static void fnClearFilters()
        {
            objClearFilters.Click();
        }
        public static IList<IWebElement> fnAllResultPage()
        {
            IList<IWebElement> objAllSearchResults = _ObjSrcDriver.FindElements(By.XPath(STR_TOTAL_RESULTS_WO));

            return objAllSearchResults;
        }
        public void fnAllResultPage(IWebElement elementToSearch)
        {
            elementToSearch.Click();            
        }
    }
}
