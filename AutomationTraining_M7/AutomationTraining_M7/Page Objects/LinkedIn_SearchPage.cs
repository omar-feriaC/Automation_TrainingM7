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
        /*Driver Reference for POM*/
        private static IWebDriver _objDriver;

        /*Locators for each element*/
        readonly static string STR_SEARCH_TEXT = "//input[@placeholder='Search' or @placeholder='Buscar']";
        readonly static string STR_SEARCH_BTN = "//input[@class=search-global-typeahead__controls";
        readonly static string STR_PEOPLE_BTN = "//span[text()='People' or text()='Gente']";
        readonly static string STR_ALLFILTERS_BTN = "//button[span[text()='All Filters' or text()='Todos los filtros']]";
        readonly static string STR_REGIONMEX_CB = "//label[text()='Mexico']";
        readonly static string STR_LANG_ENG_CB = "//label[text()='Ingles' or text()='English']";
        readonly static string STR_LANG_ESP_CB = "//label[text()='Español' or text()='Spanish']";
        readonly static string STR_APPLY_BTN = "//button[@data-control-name='all_filters_apply']";

        /*Constructor*/
        public LinkedIn_SearchPage(IWebDriver pobjSearchDriver)
        {
            _objDriver = pobjSearchDriver;
        }

        /*IWebElement Objects*/
        private static IWebElement objSearchTxt => _objDriver.FindElement(By.XPath(STR_SEARCH_TEXT));
        private static IWebElement objSearchBtn => _objDriver.FindElement(By.XPath(STR_SEARCH_BTN));
        private static IWebElement objPeopleBtn => _objDriver.FindElement(By.XPath(STR_PEOPLE_BTN));
        private static IWebElement objAllFiltersBtn => _objDriver.FindElement(By.XPath(STR_ALLFILTERS_BTN));
        private static IWebElement objRegionMexCb => _objDriver.FindElement(By.XPath(STR_REGIONMEX_CB));
        private static IWebElement objLangEngCb => _objDriver.FindElement(By.XPath(STR_LANG_ENG_CB));
        private static IWebElement objLangEspCb => _objDriver.FindElement(By.XPath(STR_LANG_ESP_CB));
        private static IWebElement objApplyBtn => _objDriver.FindElement(By.XPath(STR_APPLY_BTN));
       
        /*Methods*/
        //Search Text
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

        //Search Button
        private static IWebElement GetSearchButton()
        {
            return objSearchBtn;
        }

        public static void fnClickSearchButton()
        {
            objSearchBtn.Click();
        }

        //People Button
        private static IWebElement GetPeopleBtn()
        {
            return objPeopleBtn;
        }

        private static void fnClickPeopleBtn()
        {
            objPeopleBtn.Click();
        }

        //All filters Button 
        private static IWebElement GetAllFiltersBtn()
        {
            return objAllFiltersBtn;
        }

        private static void fnClickAllFiltersBtn()
        {
            objAllFiltersBtn.Click();
        }

        //Region Mexico checkbox
        private static IWebElement fnGetRegionMexCb()
        {
            return objRegionMexCb;
        }

        private static void fnClickRegionMexCb()
        {
            objRegionMexCb.Click();
        }

        // Language English checkbox
        private static IWebElement fnGetLangEngCb()
        {
            return objLangEngCb;
        }

        private static void fnClickLangEngCb()
        {
            objLangEngCb.Click();
        }

        // Language Spanish checkbox
        private static IWebElement fnGetLangEspCb()
        {
            return objLangEspCb;
        }

        private static void fnClickLangEspCb()
        {
            objLangEspCb.Click();
        }

        //Apply button
        private static IWebElement fnGetApplyBtn()
        {
            return objApplyBtn;
        }

        private static void fnClickApplyBtn()
        {
            objApplyBtn.Click();
        }
    }

}
