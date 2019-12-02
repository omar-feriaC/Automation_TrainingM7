using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class LinkedIn_SearchPage : Base_Files.LinkedIn_LoginPage
    {
        /*DRIVER REFERENCE FOR POM*/
        private static IWebDriver _objDriver;

        /*LOCATORS FOR EACH ELEMENT*/
        readonly static string STR_SEARCH_TXTBOX  = "//input[@placeholder='Buscar' OR @placeholder='Search']";

        internal static void fnEnterSearch(string v)
        {
            throw new NotImplementedException();
        }

        //readonly static string STR_SEARCH_TEXT    = "Jose";
        readonly static string STR_PEOPLE_FILTER  = "//span[text()='Gente' OR span[text()='People']";
        readonly static string STR_ALL_FILTER_BTN = "//span[text()='Todos los filtros' OR text()='All Filters']";
       // readonly static string STR_LOCATION_BTN   = "//span[text()='Ubicaciones' OR span[text()='Location']";
        readonly static string STR_COUNTRY_BTN    = "//label[text()='México' OR text()='Mexico']";
                                                    //"//span[@class='search-s-facet-value__name t-14 t-black--light t-normal']" +
                                                    //"[text()='México'OR text()='Mexico']";
        readonly static string STR_LANGUAGE_BTN   = "//label[text()='Español' OR text()='Spanish' OR text()='Inglés' OR text()='English']";
        readonly static string STR_APPLY_BTN      = "//button[@id='ember1456']//span[text()='Aplicar' OR //span[text()='Apply']";
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
        private static IWebElement objSearchBox     => _objDriver.FindElement(By.XPath(STR_SEARCH_TXTBOX));
        //private static IWebElement objSearchText => _objDriver.FindElement(By.XPath(STR_SEARCH_TXTBOX));
        private static IWebElement objPeople     => _objDriver.FindElement(By.XPath(STR_PEOPLE_FILTER));
        private static IWebElement objAllFilter  => _objDriver.FindElement(By.XPath(STR_ALL_FILTER_BTN));
        //private static IWebElement objLotation   => _objDriver.FindElement(By.XPath(STR_LOCATION_BTN));
        private static IWebElement objCountry    => _objDriver.FindElement(By.XPath(STR_COUNTRY_BTN));
        private static IWebElement objLanguage   => _objDriver.FindElement(By.XPath(STR_LANGUAGE_BTN));
        private static IWebElement objApply      => _objDriver.FindElement(By.XPath(STR_APPLY_BTN));

        /*METHODS*/
        //Search textbox 
        private IWebElement GetSearch()
        {
            return objSearchBox;
        }

        private static void fnEnterSearch(string pstrSearchText)
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

        private static void fnClickPeople()
        {
            objPeople.Click();
        }

        //Click All Filter Option
        private IWebElement GetAllFilter()
        {
            return objAllFilter;
        }

        private static void fnClickAllFilter()
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

        private static void fnGetMexico()
        {
            objCountry.Click();
            //objCountry.SendKeys(Keys.Enter);
        }

        // Click Spanish and English
        private IWebElement GetLanguage()
        {
            return objLanguage;
        }

        private static void fnGetLanguage()
        {
            objLanguage.Click();
        }



    }
}
