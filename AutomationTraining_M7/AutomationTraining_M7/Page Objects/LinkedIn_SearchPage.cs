using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

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
        readonly static string STR_LANG_ENG_CB = "//label[@for='sf-profileLanguage-en']";
        readonly static string STR_LANG_ESP_CB = "//label[@for='sf-profileLanguage-es']";
        readonly static string STR_APPLY_BTN = "//button[@data-control-name='all_filters_apply']";
        readonly static string STR_ADDCOUNTTRY_TEXT = "//input[@placeholder='Add a country/region'][@aria-label='Add a country/region']";
        readonly static string STR_SELECT_ITALY_DD = "//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Italy' or text()='Italia']";
        readonly static string STR_REGIONSEARCH_TEXT = "//input[@placeholder='Añadir un país o región' and @role='combobox']";
        readonly static string STR_SEARCHTECH_TEXT = "//span[@class='actor-name']\"[0]";
        readonly static string STR_URLTECH_TEXT = "//a[@data-control-name='search_srp_result']/@href";


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

        private static IWebElement objSearchTextIt => _ObjSrcDriver.FindElement(By.XPath(STR_REGIONSEARCH_TEXT));
        private static IWebElement objSearchTech => _ObjSrcDriver.FindElement(By.XPath(STR_SEARCHTECH_TEXT));

        private static IWebElement objURLTech => _ObjSrcDriver.FindElement(By.XPath(STR_URLTECH_TEXT));

        /*METHODS*/


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
            objSearchText.SendKeys(Keys.Return);
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

        //Location Italia
        private IWebElement GetFieldItaly()
        {
            return objSearchTextIt;
            
        }


        public static void fnSearchItaly(string pstrSearchTextIt)
        {
            objSearchTextIt.Click();
            objSearchTextIt.Clear();
            objSearchTextIt.SendKeys(Keys.Down);
            objSearchTextIt.SendKeys(pstrSearchTextIt);
        }

        
        
        public static void fnSelectItaly()
        {
            
            objSelectITalyDD.Click();
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

        public static void fnSearchTech(string pstrTech)
        {

            //objSearchText.Click();
            objSearchText.Clear();
            objSearchText.SendKeys(pstrTech);
            objSearchText.SendKeys(Keys.Return);
        }


        public static void fnGetTechResultsTxt()
        {
            IList<IWebElement> objGetTechResultsName = _ObjSrcDriver.FindElements(By.XPath("//*[@class='search-results__list list-style-none ']/li//*[@class='actor-name']"));
            IList<IWebElement> objGetTechResultsTitle = _ObjSrcDriver.FindElements(By.XPath("//*[@class='search-results__list list-style-none ']//*[contains(@class,'level-1')]//*[@dir='ltr']"));
            IList<IWebElement> objGetTechResultsLink = _ObjSrcDriver.FindElements(By.XPath("//*[@class='search-results__list list-style-none ']//*[contains(@class,'search-result__info')]//a"));

            objGetTechResultsName = _ObjSrcDriver.FindElements(By.XPath("//*[@class='search-results__list list-style-none ']/li//*[@class='actor-name']"));
            objGetTechResultsTitle = _ObjSrcDriver.FindElements(By.XPath("//*[@class='search-results__list list-style-none ']//*[contains(@class,'level-1')]//*[@dir='ltr']"));
            objGetTechResultsLink = _ObjSrcDriver.FindElements(By.XPath("//*[@class='search-results__list list-style-none ']//*[contains(@class,'search-result__info')]//a"));

            foreach (var vName in objGetTechResultsName)
            {
                
                Console.WriteLine("Name: " + vName.Text);
                
            }

            foreach (var vTitle in objGetTechResultsTitle)
            {
                
                Console.WriteLine("Title: " + vTitle.Text);
                
            }

            foreach (var VLink in objGetTechResultsLink)
            {
                
                Console.WriteLine("Link: " + VLink.GetAttribute("href"));
                
            }
            objGetTechResultsName = _ObjSrcDriver.FindElements(By.XPath("//*[@class='search-results__list list-style-none ']/li//*[@class='actor-name']"));
            objGetTechResultsTitle = _ObjSrcDriver.FindElements(By.XPath("//*[@class='search-results__list list-style-none ']//*[contains(@class,'level-1')]//*[@dir='ltr']"));
            objGetTechResultsLink = _ObjSrcDriver.FindElements(By.XPath("//*[@class='search-results__list list-style-none ']//*[contains(@class,'search-result__info')]//a"));
        }

    }




}
    
