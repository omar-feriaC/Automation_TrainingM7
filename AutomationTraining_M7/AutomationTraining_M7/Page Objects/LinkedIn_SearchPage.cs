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
    class LinkedIn_SearchPage
    {
        /*DRIVER REFERENCE FOR POM*/
        private static IWebDriver _objDriver;

        /*LOCATORS FOR EACH ELEMENT*/
        readonly static string STR_SEARCHBOX_TEXT = "//input[@class = 'search-global-typeahead__input']";
        readonly static string STR_LOCATIONS_TEXT = "//input[@aria-label='Add a country/region']";
        readonly static string STR_PEOPLE_BTN = "//span[text()='People']";
        readonly static string STR_ALLFILTERS_BTN = "//span[text()='All Filters' or text()='Todos los Filtros']";
        readonly static string STR_MEXICO_CHK = "//label[text()='Mexico' or text()='México']";
        readonly static string STR_SPANISH_CHK = "//label[text()='Spanish' or text()='Español']";
        readonly static string STR_ENGLISH_CHK = "//label[text()='English' or text()='Inglés']";
        readonly static string STR_APPLYFILTERS_BTN = "//button[@class='search-advanced-facets__button--apply ml4 mr2 artdeco-button artdeco-button--3 artdeco-button--primary ember-view']";


        /*CONSTRUCTOR*/
        public LinkedIn_SearchPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }

        /*IWEBELEMEMT OBJECTS*/
        private static IWebElement objSearchBox => _objDriver.FindElement(By.XPath(STR_SEARCHBOX_TEXT));
        private static IWebElement objPeopleButton => _objDriver.FindElement(By.XPath(STR_PEOPLE_BTN));
        private static IWebElement objAllFiltersButton => _objDriver.FindElement(By.XPath(STR_ALLFILTERS_BTN));
        private static IWebElement objMexicoCheckbox => _objDriver.FindElement(By.XPath(STR_MEXICO_CHK));
        private static IWebElement objSpanishCheckbox => _objDriver.FindElement(By.XPath(STR_SPANISH_CHK));
        private static IWebElement objEnglishCheckbox => _objDriver.FindElement(By.XPath(STR_ENGLISH_CHK));
        private static IWebElement objLocations => _objDriver.FindElement(By.XPath(STR_LOCATIONS_TEXT));
        private static IWebElement objApplyFiltersButton => _objDriver.FindElement(By.XPath(STR_APPLYFILTERS_BTN));

        //Search Box
        public static void fnClickSearchBox()
        {
            objSearchBox.Click();
        }

        public static void fnSearchText(string strText)
        {
            objSearchBox.Click();
            objSearchBox.SendKeys(strText);
            objSearchBox.SendKeys(Keys.Enter);
        }
        public static IWebElement GetSearchBox()
        {
            return objSearchBox;
        }

        //People button
        public static void fnClickPeopleButton()
        {
            objPeopleButton.Click();
        }

        private IWebElement GetPeopleButton()
        {
            return objPeopleButton;
        }
        public static void fnSelectAllFilltersButton()
        {
            objAllFiltersButton.Click();
        }

        private IWebElement GetAllFiltersbutton()
        {
            return objAllFiltersButton;
        }

        public static void fnSelectMexicoCheckbox()
        {
            objMexicoCheckbox.Click();
        }

        private IWebElement GetMexicoCheckbox()
        {
            return objMexicoCheckbox;
        }

        public static void fnSelectSpanishCheckbox()
        {
            objSpanishCheckbox.Click();
        }

        private IWebElement GetSpanishCheckbox()
        {
            return objSpanishCheckbox;
        }

        public static void fnSelectEnglishCheckbox()
        {
            objEnglishCheckbox.Click();
        }

        private IWebElement GetEnglishCheckbox()
        {
            return objEnglishCheckbox;
        }

        public static void fnSearchLocations(string strText)
        {
            objLocations.Click();
            objLocations.SendKeys(strText);
            Thread.Sleep(5000);
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
            if (strText == "Spanish")
            {
                objSpanishCheckbox.Click();
            }
            if (strText == "English")
            {
                objEnglishCheckbox.Click();
            }
        }

        public static void fnClickApplyFiltersButton()
        {
            objApplyFiltersButton.Click();
        }

        private IWebElement GetApplyFiltersButton()
        {
            return objApplyFiltersButton;
        }
    }
}
