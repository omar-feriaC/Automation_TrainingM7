using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;

namespace AutomationTraining_M7
{
    //Linkedin Search Pge
    class LinkedIn_SearchPage
    {

        /*LOCATORS FOR EACH ELEMENT*/
        private static IWebDriver _ObjSrcDriver;

        readonly static string STR_LOCATIONS_TEXT = "//input[@arial-label = 'Añadir un país o región']";
        readonly static string STR_CAPTCHA_CLK = "//div[@class='recaptcha-checkbox-checkmark']";
        readonly static string STR_APPLY_BTN = "//button[@data-control-name='all_filters_apply']";
        readonly static string STR_SEARCH_BTN = "//div[@class='search-global-typeahead__controls']";
        readonly static string STR_SEARCH_TEXT = "//input[@class='search-global-typeahead__input]";
        readonly static string STR_PEOPLE_BTN = "//button[span[text()='People' or text()='Gente']]";
        readonly static string STR_ALLFILTERS_BTN = "//button[span[text()='All Filters' or text()='Todos los filtros']]";
        readonly static string STR_LANG_ENG_CB = "//label[text()='English' or text()='Ingles']";
        readonly static string STR_LANG_ESP_CB = "//label[text()='Spanish' or text()='Español']";
        readonly static string STR_REGIONMX_CB = "//label[text()='Mexico' or text()='México']";
        readonly static string STR_RESULTSNAME_SPAN = "(//span[@class = 'name actor-name']) [1]";
        readonly static string STR_RESULTROLE_SPAN = "(//span[@class = 'subline-level-1 t-14 t-black t-normal search-result__truncate']) [1]";
        readonly static string STR_RESULTURL_A = "(//a@class = 'search-result__result-link ember-view']) [1]";

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
        private static IWebElement objLocations => _ObjSrcDriver.FindElement(By.XPath(STR_LOCATIONS_TEXT));
        private static IWebElement objNameSpan => _ObjSrcDriver.FindElement(By.XPath(STR_RESULTSNAME_SPAN));
        private static IWebElement objRoleSpan => _ObjSrcDriver.FindElement(By.XPath(STR_RESULTROLE_SPAN));
        private static IWebElement objURLSpan => _ObjSrcDriver.FindElement(By.XPath(STR_RESULTURL_A));



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
            objSearchText.SendKeys(Keys.Enter);
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
        private IWebElement GetPeopleCB()
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

        public static void fnLanguageEng()
        {
            objLangEngCb.Click();
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

        public static void fnSearchLocations(string strText)
        {
            objLocations.Click();
            objLocations.SendKeys(strText);
            Thread.Sleep(1000);
            objLocations.Click();
            objLocations.SendKeys(Keys.ArrowDown);
            objLocations.SendKeys(Keys.Enter);
        }
        public static IWebElement GetSearchLocations()
        {
            return objLocations;
        }
        public static void fnSelectLanguage(string strText)
        {
            if (strText == "Spanish") { objLangEspCb.Click(); }
            if (strText == "English") { objLangEngCb.Click(); }
        }


        public static IWebElement GetNameSpan()
        {
            return objNameSpan;
        }

        public static IWebElement GetRoleSpan()
        {
            return objRoleSpan;
        }

        public static IWebElement GetUrlA()
        {
            return objURLSpan;
        }
    }

}
