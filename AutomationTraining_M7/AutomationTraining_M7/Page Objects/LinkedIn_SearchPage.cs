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
<<<<<<< HEAD

        /*LOCATORS FOR EACH ELEMENT*/
        private static IWebDriver _ObjSrcDriver;
        readonly static string STR_CAPTCHA_CLK = "//div[@class='recaptcha-checkbox-checkmark']";
        readonly static string STR_APPLY_BTN = "//button[@data-control-name='all_filters_apply']";
        readonly static string STR_SEARCH_BTN = "//div[@class='search-global-typeahead__controls']";
        readonly static string STR_SEARCH_TEXT = "//input[@placeholder='Search' or @placeholder='Buscar']";
        readonly static string STR_PEOPLE_BTN = "//button[span[text()='People' or text()='Gente']]";
        readonly static string STR_ALLFILTERS_BTN = "//button[span[text()='All Filters' or text()='Todos los filtros']]";
        readonly static string STR_LANG_ENG_CB = "//label[text()='English' or text()='Ingles']";
        readonly static string STR_LANG_ESP_CB = "//label[text()='Spanish' or text()='Español']";
        readonly static string STR_REGIONMX_CB = "//label[text()='Mexico' or text()='México']";

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

=======
        /*DRIVER REFERENCE FOR POM*/
        private static IWebDriver _objDriver;

        /*LOCATORS FOR EACH ELEMENT*/
        readonly static string STR_SEARCH_TXTBOX = "//input[@placeholder='Buscar' OR @placeholder='Search']";
        readonly static string STR_PEOPLE_FILTER = "//span[text()='Gente' OR span[text()='People']";
        readonly static string STR_ALL_FILTER_BTN = "//span[text()='Todos los filtros' OR text()='All Filters']";
        readonly static string STR_COUNTRY_BTN = "//label[text()='México' OR text()='Mexico']";
        readonly static string STR_LANGUAGE_BTN = "//label[text()='Español' OR text()='Spanish' OR text()='Inglés' OR text()='English']";
        readonly static string STR_APPLY_BTN = "//button[@id='ember1456']//span[text()='Aplicar' OR //span[text()='Apply']";
        readonly static string STR_CAPTCHA_CLK = "//div[@class='recaptcha-checkbox-checkmark']";
        readonly static string STR_COUNTRY2_TXTBOX = "//div[@id='ember3402']//input[@placeholder='Añadir un país o región']";
        //  //input[@placeholder='Buscar'] -- cuadro buscar, aqui escribo cualquier cosa y doy enter
        // //span[text()='Gente'] -- primer filtro, darle click
        // //span[text()='Todos los filtros'] -- opcion "todos los filtros", darle click
        // ------------------------------------------------------------------------------------------
        // //span[text()='Ubicaciones'] -- darle click y luego
        // //span[@class='search-s-facet-value__name t-14 t-black--light t-normal'][text()='México']
        // este es el valor Mexico, darle click

        /*CONSTRUCTOR*/
        public LinkedIn_SearchPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }

        /*IWEBELEMEMT OBJECTS*/
        private static IWebElement objSearchBox => _objDriver.FindElement(By.XPath(STR_SEARCH_TXTBOX));
        //private static IWebElement objSearchText => _objDriver.FindElement(By.XPath(STR_SEARCH_TXTBOX));
        private static IWebElement objPeople => _objDriver.FindElement(By.XPath(STR_PEOPLE_FILTER));
        private static IWebElement objAllFilter => _objDriver.FindElement(By.XPath(STR_ALL_FILTER_BTN));
        //private static IWebElement objLotation   => _objDriver.FindElement(By.XPath(STR_LOCATION_BTN));
        private static IWebElement objCountry => _objDriver.FindElement(By.XPath(STR_COUNTRY_BTN));
        private static IWebElement objLanguage => _objDriver.FindElement(By.XPath(STR_LANGUAGE_BTN));
        private static IWebElement objApply => _objDriver.FindElement(By.XPath(STR_APPLY_BTN));
        private static IWebElement objCountry2 => objCountry2.FindElement(By.XPath(STR_COUNTRY2_TXTBOX));

        /*METHODS*/
        //Search textbox 
        private IWebElement GetSearch()
        {
            return objSearchBox;
        }

        public static void fnEnterSearch(string pstrSearchText)
        {
            objSearchBox.Click();
            objSearchBox.Clear();
            objSearchBox.SendKeys(pstrSearchText);
            objSearchBox.SendKeys(Keys.Enter);
        }

        //Click People Filter
        private IWebElement GetPeople()
        {
            return objPeople;
        }

        public static void fnClickPeople()
        {
            objPeople.Click();
        }

        //Click All Filter Option
        private IWebElement GetAllFilter()
        {
            return objAllFilter;
        }

        public static void fnClickAllFilter()
        {
            objAllFilter.Click();
        }


        /*//Click and Select Location
        private IWebElement GetLocation()
        {
            return objLotation;
        }

        private static void fnGetLocation()
        {
            objLotation.Click();
        }*/


        //Click Mexico
        private IWebElement GetMexico()
        {
            return objCountry;
        }

        public static void fnGetMexico()
        {
            objCountry.Click();
            //objCountry.SendKeys(Keys.Enter);
        }

        //Search for Italy
        private IWebElement GetItaly()
        {
            return objCountry2;
        }

        public static void fnGetItaly(string pstrItaly)
        {
            objCountry2.Click();
            objCountry2.Clear();
            objCountry2.SendKeys(pstrItaly);
            objCountry2.SendKeys(Keys.ArrowDown);
            objCountry2.SendKeys(Keys.Enter);
        }

        // Click Spanish and English
        private IWebElement GetLanguage()
        {
            return objLanguage;
        }

        public static void fnGetLanguage()
        {
            objLanguage.Click();
        }

        // Apply Filters
        private IWebElement GetApply()
        {
            return objApply;
        }

        public static void fnGetApply()
        {
            objApply.Click();
        }


>>>>>>> d775a935586d5c9c14de53cfa0f9f1e1718a14b7
    }
}
