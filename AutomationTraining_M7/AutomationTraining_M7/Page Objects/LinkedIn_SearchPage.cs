using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        readonly static string STR_SEARCH_TXTBOX = "//input[@placeholder='Buscar'] | //input[@placeholder='Search']";
        readonly static string STR_PEOPLE_FILTER = "//span[text()='Gente'] | //span[text()='People']";
        readonly static string STR_ALL_FILTER_BTN = "//span[text()='Todos los filtros'] | //span[text()='All Filters']";
        readonly static string STR_MEXICO_BTN = "//label[text()='México'] | //label[text()='Mexico']";
        readonly static string STR_COUNTRY_BTN = "//div[@id='ember3402']//input[@placeholder='Añadir un país o región']";
        readonly static string STR_ITALY_BTN = "//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Italy' or 'Italia']";
        readonly static string STR_LANGUAGE_BTN = "//label[text()='Español' | //label[text()='Spanish' | //label[text()='Inglés' | //label[text()='English']";
        readonly static string STR_APPLY_BTN = "//button[@id='ember1456']//span[text()='Aplicar'] | //button[@id='ember1456']//span[text()='Apply']";
        readonly static string STR_CAPTCHA_CLK = "//div[@class='recaptcha-checkbox-checkmark']";
        readonly static string STR_TECH_RESULTS = "//div[@class='blended-srp-results-js pt0 pb4 ph0 container-with-shadow']";
        //readonly static string STR_ARROW_BTN = "//button[@id='ember263']";


        /*CONSTRUCTOR*/
        public LinkedIn_SearchPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }

        /*IWEBELEMEMT OBJECTS*/
        private static IWebElement objSearchBox => _objDriver.FindElement(By.XPath(STR_SEARCH_TXTBOX));
        private static IWebElement objPeople => _objDriver.FindElement(By.XPath(STR_PEOPLE_FILTER));
        private static IWebElement objAllFilter => _objDriver.FindElement(By.XPath(STR_ALL_FILTER_BTN));
        private static IWebElement objMexico => _objDriver.FindElement(By.XPath(STR_MEXICO_BTN));
        private static IWebElement objCountry => _objDriver.FindElement(By.XPath(STR_COUNTRY_BTN));
        private static IWebElement objItaly => _objDriver.FindElement(By.XPath(STR_ITALY_BTN));
        private static IWebElement objLanguage => _objDriver.FindElement(By.XPath(STR_LANGUAGE_BTN));
        private static IWebElement objApply => _objDriver.FindElement(By.XPath(STR_APPLY_BTN));
        private static IWebElement objCaptcha => _objDriver.FindElement(By.XPath(STR_CAPTCHA_CLK));
        private static IWebElement objTechResults => objTechResults.FindElement(By.XPath(STR_TECH_RESULTS));
        //private static IWebElement objArrowBtn => objArrowBtn.FindElement(By.XPath(STR_ARROW_BTN));

        /*METHODS*/
        //Get Results of Technologies Found
        public static void fnTechResults()
        {
            IList<IWebElement> objName = _objDriver.FindElements(By.XPath("//span[@class='actor-name']"));
            IList<IWebElement> objRole = _objDriver.FindElements(By.XPath("//p[@class='subline-level-1 t-14 t-black t-normal search-result__truncate']"));
            IList<IWebElement> objURL = _objDriver.FindElements(By.XPath("//div[@class='search-result__info pt3 pb4 ph0']//a[@href]"));


            for (int i = 0; i < objName.Count; i++)
            {
                Console.WriteLine("Name: " + objName[i].Text);
                Console.WriteLine("Role: " + objRole[i].Text);
                Console.WriteLine("URL: " + objURL[i].GetAttribute("href"));
                Console.WriteLine("--===================================================--");
            }
        }

        //Search textbox 
        private IWebElement GetSearch()
        {
            return objSearchBox;
        }

        public static void fnEnterSearch(string pstrSearchText)
        {
            objSearchBox.Click();
            objSearchBox.Clear();
            objSearchBox.SendKeys(pstrSearchText);
            objSearchBox.SendKeys(Keys.Enter);
            //objSearchBox.Submit();
        }

        //Click People Filter
        private IWebElement GetPeople()
        {
            return objPeople;
        }

        public static void fnClickPeople()
        {
            objPeople.Click();
        }

        //Click All Filter Option
        private IWebElement GetAllFilter()
        {
            return objAllFilter;
        }

        public static void fnClickAllFilter()
        {
            objAllFilter.Click();
        }

        //Click Mexico
        private IWebElement GetMexico()
        {
            return objMexico;
        }

        public static void fnGetMexico()
        {
            objCountry.Click();
        }

        //Search for Italy
        private IWebElement WriteCountry()
        {
            return objCountry;
        }

        public static void fnWriteCountry(string pstrCountry)
        {
            objCountry.Click();
            objCountry.Clear();
            objCountry.SendKeys(pstrCountry);
        }

        private IWebElement GetItaly()
        {
            return objItaly;
        }

        public static void fnGetItaly()
        {
            objItaly.Click();
        }

         // Click Spanish and English
        private IWebElement GetLanguage()
        {
            return objLanguage;
        }

        public static void fnGetLanguage(string strlanguages)
        {
            objLanguage.Click();
        }

        // Apply Filters
        private IWebElement GetApply()
        {
            return objApply;
        }

        public static void fnGetApply()
        {
            objApply.Click();
        }

        //Captcha
        private IWebElement GetCaptcha()
        {
            return objCaptcha;
        }

        public static void fnClickCaptcha()
        {
            objCaptcha.Click();
        }

        /*//Arrow button
        private IWebElement GetArrow()
        {
            return objArrowBtn;
        }

        public static void fnGetArrow()
        {
            objArrowBtn.Click();
        }*/
    }
}
