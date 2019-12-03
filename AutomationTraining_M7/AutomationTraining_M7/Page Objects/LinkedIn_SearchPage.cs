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
        private static IWebDriver _objDriver;

        readonly static string STR_SEARCH_TEXT = "//input[@placeholder='Buscar' or @placeholder='Search']";
        readonly static string STR_SEARCH_BTN = "//div[@class='search-global-typeahead__controls']";
        readonly static string STR_PEOPLE_BTN = "//button[span[text()='People' or text()='Gente']]";
        readonly static string STR_ALLFILTERS_BTN = "//button[span[text()='All Filters' or text()='Todos los filtros']]";
        readonly static string STR_LOCATION_CB = "//label[text()='United States' or text()='Estados Unidos']"; //Problems using DropDown for Mexico
        readonly static string STR_LANGUAGE_ENG_CB = "//label[text()='English' or text()='Ingles']";
        readonly static string STR_LANGUAGE_ESP_CB = "//label[text()='Spanish' or text()='Español']";
        readonly static string STR_APPLY_BTN = "//button[@data-control-name='all_filters_apply']";

        public LinkedIn_SearchPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }

        private static IWebElement objSearchTxt => _objDriver.FindElement(By.XPath(STR_SEARCH_TEXT));
        private static IWebElement objSearchBtn => _objDriver.FindElement(By.XPath(STR_SEARCH_BTN));
        private static IWebElement objPeopleBtn => _objDriver.FindElement(By.XPath(STR_PEOPLE_BTN));
        private static IWebElement objAllFiltersBtn => _objDriver.FindElement(By.XPath(STR_ALLFILTERS_BTN));
        private static IWebElement objLocationCBox => _objDriver.FindElement(By.XPath(STR_LOCATION_CB));
        private static IWebElement objLanguageEngCBox => _objDriver.FindElement(By.XPath(STR_LANGUAGE_ENG_CB));
        private static IWebElement objLanguageEspCBox => _objDriver.FindElement(By.XPath(STR_LANGUAGE_ESP_CB));
        private static IWebElement objApplyBtn => _objDriver.FindElement(By.XPath(STR_APPLY_BTN));

        private static IWebElement GetSearchField()
        {
            return objSearchTxt;
        }

        public static void fnEnterSearchText(string pstrSearchText)
        {
            objSearchTxt.Click();
            objSearchTxt.Clear();
            objSearchTxt.SendKeys(pstrSearchText);
        }

        private static IWebElement GetSearchButton()
        {
            return objSearchBtn;
        }

        public static void fnClickSearchButton()
        {
            objSearchBtn.Click();
        }

        private static IWebElement GetPeopleButton()
        {
            return objPeopleBtn;
        }

        public static void fnClickPeopleButton()
        {
            objPeopleBtn.Click();
        }
        
        private static IWebElement GetAllFiltersButton()
        {
            return objAllFiltersBtn;
        }

        public static void fnClickAllFiltersButton()
        {
            objAllFiltersBtn.Click();
        }

        private static IWebElement GetLocationComboBox()
        {
            return objLocationCBox;
        }

        public static void fnClickLocationComboBox()
        {
            objLocationCBox.Click();
        }

        private static IWebElement GetEnglishLanguageComboBox()
        {
            return objLanguageEngCBox;
        }

        public static void fnClickEnglishLanguageComboBox()
        {
            objLanguageEngCBox.Click();
        }

        private static IWebElement GetSpanishLanguageComboBox()
        {
            return objLanguageEspCBox;
        }

        public static void fnClickSpanishLanguageComboBox()
        {
            objLanguageEspCBox.Click();
        }

        private static IWebElement GetApplyButton()
        {
            return objApplyBtn;
        }

        public static void fnClickApplyButton()
        {
            objApplyBtn.Click();
        }

    }
}
