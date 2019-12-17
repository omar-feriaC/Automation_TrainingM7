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

        readonly static string STR_SEARCH_FIELD = "//input[@class = 'search-global-typeahead__input always-show-placeholder']";
        public readonly static string STR_PEOPLE_BTN = "//span[text()='People'or text()='Gente']";
        public readonly static string STR_ALLFILTERS_BTN = "//span[text()='All Filters'or text()='Todos los filtros']";
        public  readonly static string STR_MEXICO_CHCBX = "//label[text()='Mexico' or text()='México']";
        readonly static string STR_ADD_COUNTRY_FIELD = "//input[@aria-label ='Add a country/region']";
        readonly static string STR_ENGLISH_CHCBX = "//label[text()='English']";
        readonly static string STR_SPANISH_CHCBX = "//label[text()='Spanish']";
        readonly static string STR_APPLYFILTERS_BTN = "//button[@data-control-name ='all_filters_apply']";

     

        /*CONSTRUCTOR*/
        public LinkedIn_SearchPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }



        /*IWEBELEMEMT OBJECTS*/
        private static IWebElement objSearchField => _objDriver.FindElement(By.XPath(STR_SEARCH_FIELD));
        private static IWebElement objPeopleButton => _objDriver.FindElement(By.XPath(STR_PEOPLE_BTN));
        private static IWebElement objAllFiltersButton => _objDriver.FindElement(By.XPath(STR_ALLFILTERS_BTN));
        private static IWebElement objMexicoChcbx => _objDriver.FindElement(By.XPath(STR_MEXICO_CHCBX));
        private static IWebElement objAddCountryField => _objDriver.FindElement(By.XPath(STR_ADD_COUNTRY_FIELD));
        private static IWebElement objEnglishChcbx => _objDriver.FindElement(By.XPath(STR_ENGLISH_CHCBX));
        private static IWebElement objSpanishChcbx => _objDriver.FindElement(By.XPath(STR_SPANISH_CHCBX));
        private static IWebElement objApplyAllFiltersButton => _objDriver.FindElement(By.XPath(STR_APPLYFILTERS_BTN));
        

        /*METHODS*/
        //Search Field
        private IWebElement GetSearchField()
        {
            return objSearchField;
        }

        public static void fnSendInfo(string pstrInfo)
        {
            objSearchField.Clear();
            objSearchField.SendKeys(pstrInfo);
            objSearchField.SendKeys(Keys.Enter);
        }

        //People Button
        public  IWebElement GetPeopleButton()
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


    

        //Mexico Checkbox
        private IWebElement GetMexicoCheckbox()
        {
            return objMexicoChcbx;
        }

        public static void fnClickMexicoCheckbox()
        {
            objMexicoChcbx.Click();

        }


        //Add Country Field
        private IWebElement GetAddCountryField()
        {
            return objAddCountryField;
        }

        public static void fnAddCountryField(string pstrCountry)
        {
            objAddCountryField.Click();
            objAddCountryField.SendKeys(pstrCountry);
            Task.Delay(4000).Wait();
            objAddCountryField.SendKeys(Keys.ArrowDown);
            objAddCountryField.SendKeys(Keys.Enter);

        }


    

        //English Checkbox
        private IWebElement GetEnglishCheckbox()
        {
            return objEnglishChcbx;
        }

        public static void fnClickEnglishCheckbox()
        {
            objEnglishChcbx.Click();

        }

        //Spanish Checkbox
        private IWebElement GetSpanishCheckbox()
        {
            return objSpanishChcbx;
        }

        public static void fnClickSpanishCheckbox()
        {
            objSpanishChcbx.Click();

        }

        public static void fnSelectandClickLanguage(string pstrlanguage)
        {
            string strlanguage = pstrlanguage;

            if (strlanguage == "Spanish")
            {

                objSpanishChcbx.Click();
            }

            if (strlanguage == "English")
            {

                objEnglishChcbx.Click();
            }


        }

        //Apply All Filters Button
        private IWebElement GetApplyAllFiltersButton()
        {
            return objApplyAllFiltersButton;
        }

        public static void fnApplyAllFiltersButton()
        {
            objApplyAllFiltersButton.Click();

        }




        public static void fnSearchTechnologies(string pstrSearchTech)
        {
           
            objSearchField.Clear();
            objSearchField.SendKeys(pstrSearchTech);
            objSearchField.SendKeys(Keys.Enter);
           
        }
    }
}
 