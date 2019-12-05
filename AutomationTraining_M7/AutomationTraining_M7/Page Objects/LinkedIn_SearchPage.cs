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
        /*DRIVER REFERENCE*/
        private static IWebDriver _objDriver;

        /*ELEMENT LOCATORS*/
        readonly static string STR_SEARCH_BOX_XPATH = "//input[contains(@class,'search-global-typeahead__input')]";
        readonly static string STR_SEARCH_BTN_XPATH = "//button[contains(@class,'search-global-typeahead__button')]";
        readonly static string STR_PEOPLE_BTN_XPATH = "//*[text()='People' or text()='Gente']";
        readonly static string STR_ALLFLTR_BTN_XPATH = "//*[text()='All Filters' or text()='Todos los filtros']";
        readonly static string STR_LOCATIONSRCH_BOX_XPATH = "//*[@class='search-advanced-facets__facets-list']//*[@id='locations-facet-values']//input[@placeholder='Add a country/region' or @placeholder='Añadir un país o región']";
        readonly static string STR_LOCATIONMX_OPT_XPATH = $"//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'México' or text()='Mexico']";
        readonly static string STR_LOCATIONITA_OPT_XPATH = $"//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Italy' or 'Italia']";
        readonly static string STR_APPLYBTN_XPATH = "//*[@role='dialog']//*[text()='Apply']";

        /*CONSTRUCTOR*/
        public LinkedIn_SearchPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }

        /*PAGE ELEMENT OBJECTS*/
        private static IWebElement objSearchBoxInput => _objDriver.FindElement(By.XPath(STR_SEARCH_BOX_XPATH));
        private static IWebElement objSearchButton => _objDriver.FindElement(By.XPath(STR_SEARCH_BTN_XPATH));
        private static IWebElement objPeopleButton => _objDriver.FindElement(By.XPath(STR_PEOPLE_BTN_XPATH));
        private static IWebElement objAllFiltersButton => _objDriver.FindElement(By.XPath(STR_ALLFLTR_BTN_XPATH));
        private static IWebElement objLocationBoxInput => _objDriver.FindElement(By.XPath(STR_LOCATIONSRCH_BOX_XPATH));
        private static IWebElement objLocationMexicoOption => _objDriver.FindElement(By.XPath(STR_LOCATIONMX_OPT_XPATH));
        private static IWebElement objLocationItalyOption => _objDriver.FindElement(By.XPath(STR_LOCATIONITA_OPT_XPATH));
        private static IWebElement objApplyButton => _objDriver.FindElement(By.XPath(STR_APPLYBTN_XPATH));

        /*METHODS*/
        //Get page elements
        public IWebElement GetSearchBoxField()
        {
            return objSearchBoxInput;
        }
        public IWebElement GetSearchButton()
        {
            return objSearchButton;
        }
        public IWebElement GetPeopleButton()
        {
            return objPeopleButton;
        }
        public IWebElement GetAllFiltersButton()
        {
            return objAllFiltersButton;
        }
        public IWebElement GetLocationBoxInput()
        {
            return objLocationBoxInput;
        }
        public IWebElement GetMexicoOption()
        {
            return objLocationMexicoOption;
        }
        public IWebElement GetItalyOption()
        {
            return objLocationItalyOption;
        }

        /*PAGE ACTIONS*/
        //Click the search box
        public void fnClickSearchBox()
        {
            objSearchBoxInput.Click();
        }
        //Enter text to search
        public void fnEnterSearchText(string pstrSearchText)
        {
            objSearchBoxInput.Clear();
            objSearchBoxInput.SendKeys(pstrSearchText);
        }
        //Click the search button
        public void fnClickSearchButton()
        {
            objSearchButton.Click();
        }
        //Click the people button
        public void fnClickPeopleButton()
        {
            objPeopleButton.Click();
        }
        //Click the all filters button
        public void fnClickAllFiltersButton()
        {
            objAllFiltersButton.Click();
        }
        //Enter location to search
        public void fnEnterLocationText(string pstrLocationText)
        {
            objLocationBoxInput.Clear();
            objLocationBoxInput.SendKeys(pstrLocationText);
        }
        //Select 'México' or 'Mexico' location.
        public void fnClickMexicoOption()
        {
            objLocationMexicoOption.Click();
        }
        //Select 'Italy' or 'Italia' location.
        public void fnClickItayOption()
        {
            objLocationItalyOption.Click();
        }
        //Select profile language
        public void fnSelectProfileLanguate(string pstrProfileLanguage)
        {
            IWebElement objProfileLanguageOption = _objDriver.FindElement(By.XPath($"//*[text()='{pstrProfileLanguage}']"));
            objProfileLanguageOption.Click();
        }
        //Click Apply button
        public void fnClickApplyButton()
        {
            objApplyButton.Click();
        }
    }
}
