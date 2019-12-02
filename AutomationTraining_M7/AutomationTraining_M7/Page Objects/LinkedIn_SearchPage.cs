using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTraining_M7.Base_Files;

namespace AutomationTraining_M7.Page_Objects
{
    class LinkedIn_SearchPage : BaseTest
    {
        /*DRIVER REFERENCE*/
        private static IWebDriver _objDriver;

        /*ELEMENT LOCATORS*/
        readonly static string strSearchBoxXpath = "//input[contains(@class,'search-global-typeahead__input')]";
        readonly static string strSearchBtnXpath = "//button[contains(@class,'search-global-typeahead__button')]";
        readonly static string strPeopleButtonId = "ember6499";
        readonly static string strPeopleFilterDropDownId = "ember5164";
        readonly static string strPeopleFilterDropDownContentsXpath = "//*[@id='ember5164']/artdeco-dropdown-content/div/ul/li";
        readonly static string strAllFiltersButtonId = "ember5322";

        public LinkedIn_SearchPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }

        /*PAGE ELEMENT OBJECTS*/
        private static IWebElement objSearchBoxInput => _objDriver.FindElement(By.XPath(strSearchBoxXpath));
        private static IWebElement objSearchButton => _objDriver.FindElement(By.XPath(strSearchBtnXpath));
        private static IWebElement objPeopleButton => _objDriver.FindElement(By.Id(strPeopleButtonId));
        private static IWebElement objPeopleFilterDropDown => _objDriver.FindElement(By.Id(strPeopleFilterDropDownId));
        private static IList<IWebElement> lstPeopleFilterDropDown => _objDriver.FindElements(By.XPath(strPeopleFilterDropDownContentsXpath));
        private static IWebElement objAllFiltersButton => _objDriver.FindElement(By.Id(strAllFiltersButtonId));

        /*METHODS*/
        //Get page elements
        private IWebElement GetSearchBoxField()
        {
            return objSearchBoxInput;
        }
        private IWebElement GetSearchButton()
        {
            return objSearchButton;
        }
        private IWebElement GetPeopleButton()
        {
            return objPeopleButton;
        }
        private IWebElement GetPeopleFilterButton()
        {
            return objPeopleFilterDropDown;
        }
        private IList<IWebElement> GetPeopleFilterContents()
        {
            return lstPeopleFilterDropDown;
        }
        private IWebElement GetAllFiltersButton()
        {
            return objAllFiltersButton;
        }
        /*PAGE ACTIONS*/
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

        //Click the people filter button
        public void fnClickPeopleFilterButton()
        {
            objPeopleFilterDropDown.Click();
        }

        //Click the all filters button
        public void fnClickAllFiltersButton()
        {
            objAllFiltersButton.Click();
        }

        //Select the option from drop down
        public void fnSelectDropDownOption(int iIndex)
        {
            lstPeopleFilterDropDown[iIndex].Click();
        }
    }
}
