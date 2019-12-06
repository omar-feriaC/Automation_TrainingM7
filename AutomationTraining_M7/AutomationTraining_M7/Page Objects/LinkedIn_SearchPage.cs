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
        /*DRIVER REFERENCE FOR POM*/
        private static IWebDriver _ObjSrcDriver;

        /*LOCATORS FOR EACH ELEMENT*/
        readonly static string STR_CAPTCHA_CLK = "//div[@class='recaptcha-checkbox-checkmark']";
        readonly static string STR_SEARCH_TEXT = "//input[@placeholder='Search' or @placeholder='Buscar']";
        readonly static string STR_SEARCH_BTN = "//div[@class='search-global-typeahead__controls']";
        readonly static string STR_PEOPLE_BTN = "//button[span[text()='People' or text()='Gente']]";
        readonly static string STR_ALLFILTERS_BTN = "//button[span[text()='All Filters' or text()='Todos los filtros']]";
        readonly static string STR_REGIONMX_CB = "//label[text()='Mexico' or text()='México']";
        readonly static string STR_LANG_ENG_CB = "//label[text()='English' or text()='Ingles']";
        readonly static string STR_LANG_ESP_CB = "//label[text()='Spanish' or text()='Español']";
        readonly static string STR_APPLY_BTN = "//button[@data-control-name='all_filters_apply']";
        readonly static string STR_ADDCOUNTTRY_TEXT = "//input[@placeholder='Add a country/region'][@aria-label='Add a country/region']";
        readonly static string STR_SELECT_ITALY_DD = "//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Italy' or 'Italia']";
        

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
        private static IWebElement objSelectITalyDD => _ObjSrcDriver.FindElement(By.XPath(STR_SELECT_ITALY_DD));
        private static IWebElement objItalyDropdown => _ObjSrcDriver.FindElement(By.XPath("//div[@class='basic-typeahead__triggered-content search-s-add-facet__typeahead-tray']"));
        


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

        //Add new Language
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

        //Select Italy
        private IWebElement SelectItaly() 
        {
            return objSelectITalyDD;
        }

        public static void fnSelectItaly() 
        {
            objSelectITalyDD.Click();
        }

        public static void fnSelectLanguage(string pstrLanguage)
        {
            IWebElement objLanguageOption = _ObjSrcDriver.FindElement(By.XPath($"//*[text()='{pstrLanguage}']"));
            objLanguageOption.Click();
        }

        public static IWebElement GetItalyDropDown()
        {
            return objItalyDropdown;
        }

        public static void fnTechnology() 
        {
            

            IWebElement objName = _ObjSrcDriver.FindElement(By.XPath("//span[@class='actor-name']"));
            IWebElement objRole = _ObjSrcDriver.FindElement(By.XPath("//p[@class='subline-level-1 t-14 t-black t-normal search-result__truncate']"));
            IWebElement objURL = _ObjSrcDriver.FindElement(By.XPath("//div[@class='search-result__info pt3 pb4 ph0']//a[@href]"));

            Console.WriteLine("Name: " + objName.Text);
            Console.WriteLine("Role: " + objRole.Text);
            Console.WriteLine("URL: " + objURL.GetAttribute("href"));
            Console.WriteLine("");
        }



    }
}
