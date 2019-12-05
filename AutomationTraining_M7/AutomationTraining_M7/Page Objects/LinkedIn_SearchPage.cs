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
        private static IWebDriver _objDriver;

        /*LOCATORS FOR EACH ELEMENT*/
        readonly static string STR_SEARCH_TXTBOX = "//input[@placeholder='Buscar'] | //input[@placeholder='Search']";
        readonly static string STR_PEOPLE_FILTER = "//span[text()='Gente'] | //span[text()='People']";
        readonly static string STR_ALL_FILTER_BTN = "//span[text()='Todos los filtros'] | //span[text()='All Filters']";
        readonly static string STR_COUNTRY_BTN = "//label[text()='México'] | //label[text()='Mexico']";
        readonly static string STR_LANGUAGE_BTN = "//label[text()='Español' | //label[text()='Spanish' | //label[text()='Inglés' | //label[text()='English']";
        //readonly static string STR_LANGUAGE_ESP_BTN = "//label[text()='Español' OR text()='Spanish]";
        //readonly static string STR_LANGUAGE_ING_BTN = "//label[text()='Inglés' OR text()='English']";
        readonly static string STR_APPLY_BTN = "//button[@id='ember1456']//span[text()='Aplicar'] | //button[@id='ember1456']//span[text()='Apply']";
        //readonly static string STR_CAPTCHA_CLK = "//div[@class='recaptcha-checkbox-checkmark']";
        readonly static string STR_COUNTRY2_TXTBOX = "//div[@id='ember3402']//input[@placeholder='Añadir un país o región']";
        
        /*trash information I used to generate Xpaths*/
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
            Task.Delay(50).Wait();
            objSearchBox.Clear();
            Task.Delay(50).Wait();
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

        public static void fnGetLanguage(string strlanguages)
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




    }
}
