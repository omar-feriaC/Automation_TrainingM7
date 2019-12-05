using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class LinkedIn_SearchPage : BaseTest
    {
        public static string SEARCH_TEXTFIELD = "search-global-typeahead__input";
        public static string GENTE_BUTTON = "//span[text()='People'or text()='Gente']";
        public static string TOODSFILTROS_BUTTON = "//span[text()='All Filters'or text()='Todos los filtros']"
        public static string UBICACION_CHECKBOX = "//label[text()='Mexico' or text()='México']";
        public static string IDIOMAen_CHECKBOX = "//label[text()='English']";
        public static string IDIOMAes_CHECKBOX = "//label[text()='Español']";
        public static string APLICAR_BUTTON = "//button[@data-control-name ='all_filters_apply']";
        public static string ADDCOUNTRY_TextFIELD = "//input[@aria-label ='Add a country/region']";


        private static IWebDriver _objDriver;

        //public  LinkedIn_SearchPage(IWebDriver driver)
        //{

        //    this._driver = driver;
        //}
        public LinkedIn_SearchPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }

        //Define Properties
        public static IWebElement searchTxt => _objDriver.FindElement(By.ClassName(SEARCH_TEXTFIELD));
        public static IWebElement genteBtn => _objDriver.FindElement(By.XPath(GENTE_BUTTON));
        public static IWebElement filtrosBtn => _objDriver.FindElement(By.XPath(TOODSFILTROS_BUTTON));
        public static IWebElement ubicacionChBtn => _objDriver.FindElement(By.XPath(UBICACION_CHECKBOX));
        public static IWebElement idiomaEnChBtn => _objDriver.FindElement(By.XPath(IDIOMAen_CHECKBOX));
        public static IWebElement aplicarBtn => _objDriver.FindElement(By.XPath(APLICAR_BUTTON));
        public static IWebElement idiomaEsChBtn => _objDriver.FindElement(By.XPath(IDIOMAes_CHECKBOX));
        public static IWebElement AddCountry => _objDriver.FindElement(By.XPath(ADDCOUNTRY_TextFIELD));

        //
        public static void fnSearchField(string strSearchString)
        {
            searchTxt.SendKeys(strSearchString);


        }

        public static void fnClickGente()
        {
            genteBtn.Click();
        }

        public static void fnClickAllFilters()
        {
            filtrosBtn.Click();
        }
        public static void fnClickMexico()
        {
            ubicacionChBtn.Click();
        }

        public static void fnAddCountryField(string pstrCountry)
        {
            AddCountry.Click();
            AddCountry.SendKeys(pstrCountry);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            AddCountry.SendKeys(Keys.ArrowDown);
            AddCountry.SendKeys(Keys.Enter);

        }

        public static void fnClickEnglish()
        {
            idiomaEnChBtn.Click();

        }
        

        }
    }
