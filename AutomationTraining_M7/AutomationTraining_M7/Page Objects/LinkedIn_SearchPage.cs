﻿using AutomationTraining_M7.Base_Files;
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
        /*Driver Reference for POM*/
        private static IWebDriver _objDriver;

        /*Locators for each element*/
        readonly static string STR_SEARCH_TEXT = "//input[@placeholder='Search' or @placeholder='Buscar']";
        readonly static string STR_SEARCH_BTN = "//div[@class='search-global-typeahead__controls']";
        readonly static string STR_PEOPLE_BTN = "//span[text()='People' or text()='Gente']";
        readonly static string STR_ALLFILTERS_BTN = "//button[span[text()='All Filters' or text()='Todos los filtros']]";
        readonly static string STR_REGIONMEX_CB = "//label[text()='México' or text()='Mexico']";        
        readonly static string STR_LANG_ENG_CB = "//label[text()='Inglés' or text()='English']";
        readonly static string STR_LANG_ESP_CB = "//label[text()='Español' or text()='Spanish']";
        readonly static string STR_APPLY_BTN = "//button[@data-control-name='all_filters_apply']";
        readonly static string STR_REGIONADD_TEXT = "//input[@placeholder='Añadir un país o región'][@aria-label='Añadir un país o región']";
        readonly static string STR_REGIONITA_CB = "//label[text()='Italia' or text()='Italy']";

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

        private static IWebElement objRegionAddTxt => _objDriver.FindElement(By.XPath(STR_REGIONADD_TEXT));
        private static IWebElement objRegionItaCb => _objDriver.FindElement(By.XPath(STR_REGIONITA_CB));

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

        public static void fnClickPeopleBtn()
        {
            objPeopleBtn.Click();
        }

        //All filters Button 
        private static IWebElement GetAllFiltersBtn()
        {
            return objAllFiltersBtn;
        }

        public static void fnClickAllFiltersBtn()
        {
            objAllFiltersBtn.Click();
        }

        //Region Mexico checkbox
        private static IWebElement fnGetRegionMexCb()
        {
            return objRegionMexCb;
        }

        public static void fnClickRegionMexCb()
        {
            objRegionMexCb.Click();
        }

        // Language English checkbox
        private static IWebElement fnGetLangEngCb()
        {
            return objLangEngCb;
        }

        public static void fnClickLangEngCb()
        {
            objLangEngCb.Click();
        }

        // Language Spanish checkbox
        private static IWebElement fnGetLangEspCb()
        {
            return objLangEspCb;
        }

        public static void fnClickLangEspCb()
        {
            objLangEspCb.Click();
        }

        //Apply button
        private static IWebElement fnGetApplyBtn()
        {
            return objApplyBtn;
        }

        public static void fnClickApplyBtn()
        {
            objApplyBtn.Click();
        }

        /* ***************************************************************** */
        //Select Region Italy 
        private static IWebElement fnGetRegionTxt()
        {
            return objRegionAddTxt;
        }

        public static void fnClickRegionTxt(string pstrAddRegion)
        {
            objRegionAddTxt.Click();
            objRegionAddTxt.Clear();
            objRegionAddTxt.SendKeys(pstrAddRegion);
            objRegionAddTxt.SendKeys(Keys.ArrowDown);
            objRegionAddTxt.SendKeys(Keys.Enter);
        }



    }

}
