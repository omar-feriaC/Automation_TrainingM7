using AutomationTraining_M7.Base_Files;
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
        /*DRIVER REFERENCE FOR POM*/
        private static IWebDriver _objDriver2;

        /*LOCATORS FOR EACH ELEMENT*/
        readonly static string STR_SEARCH_TEXT = "//*[@id='ember31']/input"; //Searchbar
        readonly static string STR_PEOPLE_TEXT = "//button[span[text()='People' or text()='Gente']]"; //People o Gente
        readonly static string STR_ALLFILTERS_BTN = "//button[span[text()='All Filters' or text()='Todos los filtros']]"; //Todos los filtros
        readonly static string STR_APPLYFILTERS_BTN = "//button[@data-control-name='all_filters_apply']";

        /*CONSTRUCTOR*/
        public LinkedIn_SearchPage(IWebDriver pobjDriver)
        {
            _objDriver2 = pobjDriver;
        }

        /*IWEBELEMEMT OBJECTS*/
        private static IWebElement objSearchField => _objDriver2.FindElement(By.XPath(STR_SEARCH_TEXT));
        private static IWebElement objPeopleButton => _objDriver2.FindElement(By.XPath(STR_PEOPLE_TEXT));
        private static IWebElement objAllFiltersButton => _objDriver2.FindElement(By.XPath(STR_ALLFILTERS_BTN));
        private static IWebElement objApplyFiltersButton => _objDriver2.FindElement(By.XPath(STR_APPLYFILTERS_BTN));












        /*METHODS*/
        //User Name Txt
        private static IWebElement GetSearch()
        {
            return objSearchField;
        }

        public static void fnSendInfo(string pstrInfo)
        {
            objSearchField.Clear();
            objSearchField.SendKeys(pstrInfo);
            objSearchField.SendKeys(Keys.Return);
        }

        private IWebElement getPeopleBtn()
        {
            return objPeopleButton;
        }
        public static void fnClickPeopleButton()
        {
            objPeopleButton.Click();

        }


        //All Filters Button
        private IWebElement GetAllFiltersButton()
        {
            return objAllFiltersButton;
        }

        public static void fnClickAllFiltersButton()
        {
            objAllFiltersButton.Click();

        }

       


        //English Option
       // private IWebElement GetEnglishCheckbox()
       // {
       //     return objEnglishChcbx;
       // }
       //
       // public static void fnClickEnglishCheckbox()
       // {
       //     objEnglishChcbx.Click();
       //
       // }
       //
       // //Spanish Option
       // private IWebElement GetSpanishCheckbox()
       // {
       //     return objSpanishChcbx;
       // }
       //
       // public static void fnClickSpanishCheckbox()
       // {
       //     objSpanishChcbx.Click();
       //
       // }
       //

        //Apply All Filters Button
        private IWebElement GetApplyAllFiltersButton()
        {
            return objApplyFiltersButton;
        }

        public static void fnApplyFiltersButton()
        {
            objApplyFiltersButton.Click();

        }

    }
}
