using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class LinkedIn_SearchPage : BaseTest
    {
        public static WebDriverWait wait;

        /*LOCATORS FOR EACH ELEMENT*/
        private static IWebDriver _ObjSrcDriver;
        readonly static string STR_CAPTCHA_CLK = "//div[@class='recaptcha-checkbox-checkmark']";
        readonly static string STR_APPLY_BTN = "//button[@data-control-name='all_filters_apply']";
        readonly static string STR_SEARCH_BTN = "//div[@class='search-global-typeahead__controls']";
        readonly static string STR_SEARCH_TEXT = "//input[@placeholder='Search' or @placeholder='Buscar']";
        readonly static string STR_PEOPLE_BTN = "//button[span[text()='People' or text()='Gente']]";
        readonly static string STR_ALLFILTERS_BTN = "//button[span[text()='All Filters' or text()='Todos los filtros']]";
        readonly static string STR_LANG_ENG_CB = "//label[text()='English' or text()='Ingles' or text()='Inglés']";
        readonly static string STR_LANG_ESP_CB = "//label[text()='Spanish' or text()='Español']";
        readonly static string STR_REGIONMX_CB = "//label[text()='Mexico' or text()='México']";
        readonly static string STR_ADDCOUNTTRY_TEXT = "//input[@placeholder='Add a country/region' or @placeholder='Añadir un país o región'][@aria-label='Add a country/region' or @aria-label='Añadir un país o región']";
        readonly static string STR_SELECT_MEXICO_DD = "//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Mexico' or text()='México']";
        readonly static string STR_CLEAR_FILTERS = "//div[@id='inbug-nav-item']";
        //readonly static string STR_TOTAL_RESULTS_WO = "/html/body/div[5]/div[5]/div[4]/div/div[2]/div/div[2]/div/div/div/div/ul";
        readonly static string STR_TOTAL_RESULTS_WO = "//ul[@class='search-results__list list-style-none ']/li/div/div[1]/div[2]/a/h3/span/span/span[1]";
        readonly static string STR_NAME = "//li[@class='inline t-24 t-black t-normal break-words']";
        readonly static string STR_ROLE = "//h2[@class='mt1 t-18 t-black t-normal']";
        readonly static string STR_LAST_JOB = "(//div[@class='pv-entity__summary-info pv-entity__summary-info--background-section '])[1]";
        readonly static string STR_EXPERIENCE = "//ul[@class='pv-profile-section__section-info section-info pv-profile-section__section-info--has-more']";
        readonly static string STR_SHOW_MORE_BTN = "//button[@class='pv-profile-section__card-action-bar pv-skills-section__additional-skills artdeco-container-card-action-bar artdeco-button artdeco-button--tertiary artdeco-button--3 artdeco-button--fluid']";
        readonly static string STR_SKILLS = "//h2[@class='pv-profile-section__card-heading' and text()='Aptitudes y validaciones']/ol[@class='pv-skill-categories-section__top-skills pv-profile-section__section-info section-info pb1']";
        readonly static string STR_TOOLS = "//ol[@class='pv-skill-category-list__skills_list list-style-none']";

        //test
        /*CONSTRUCTOR*/
        public LinkedIn_SearchPage(IWebDriver pobjSrcDriver)
        {
            _ObjSrcDriver = pobjSrcDriver;
        }

        /*IWEBELEMEMT OBJECTS*/
        private static IWebElement objCaptcha => _ObjSrcDriver.FindElement(By.XPath(STR_CAPTCHA_CLK));
        private static IWebElement objSearchText => _ObjSrcDriver.FindElement(By.XPath(STR_SEARCH_TEXT));
        private static IWebElement objSearchBtn => _ObjSrcDriver.FindElement(By.XPath(STR_SEARCH_BTN));
        private static IWebElement objPeopleBtn => _ObjSrcDriver.FindElement(By.XPath(STR_PEOPLE_BTN));
        private static IWebElement objAllFiltersBtn => _ObjSrcDriver.FindElement(By.XPath(STR_ALLFILTERS_BTN));
        private static IWebElement objRegionMxCb => _ObjSrcDriver.FindElement(By.XPath(STR_REGIONMX_CB));
        private static IWebElement objLangEngCb => _ObjSrcDriver.FindElement(By.XPath(STR_LANG_ENG_CB));
        private static IWebElement objLangEspCb => _ObjSrcDriver.FindElement(By.XPath(STR_LANG_ESP_CB));
        private static IWebElement objApplyBtn => _ObjSrcDriver.FindElement(By.XPath(STR_APPLY_BTN));
        private static IWebElement objAddCountryTxt => _ObjSrcDriver.FindElement(By.XPath(STR_ADDCOUNTTRY_TEXT));
        private static IWebElement objSelectMexicoDD => _ObjSrcDriver.FindElement(By.XPath(STR_SELECT_MEXICO_DD));
        private static IWebElement objClearFilters => _ObjSrcDriver.FindElement(By.XPath(STR_CLEAR_FILTERS));
        //private static List<IWebElement> objAllResultsPage => _ObjSrcDriver.FindElements(By.XPath(STR_TOTAL_RESULTS_WO));
        private static IWebElement objName => _ObjSrcDriver.FindElement(By.XPath(STR_NAME));
        private static IWebElement objRole => _ObjSrcDriver.FindElement(By.XPath(STR_ROLE));
        private static IWebElement objLastJob => _ObjSrcDriver.FindElement(By.XPath(STR_LAST_JOB));
        private static IWebElement objExp => _ObjSrcDriver.FindElement(By.XPath(STR_EXPERIENCE));
        private static IWebElement objShowMore => _ObjSrcDriver.FindElement(By.XPath(STR_SHOW_MORE_BTN));
        private static IWebElement objSkills => _ObjSrcDriver.FindElement(By.XPath(STR_SKILLS));
        private static IWebElement objTools => _ObjSrcDriver.FindElement(By.XPath(STR_TOOLS));

        /*METHODS*/

        //Get Member Info

        public static void fnMemberInfo()
        {
            wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            Actions actions = new Actions(_ObjSrcDriver);
            Console.WriteLine("Name: " + objName.Text);
            Console.WriteLine("Role: " + objRole.Text);
            wait.Until(ExpectedConditions.ElementExists(By.XPath("(//div[@class='pv-entity__summary-info pv-entity__summary-info--background-section '])[1]")));
            actions.MoveToElement(objLastJob);
            actions.Perform();
            if (objLastJob.Displayed) { Console.WriteLine("Last Job: " + objLastJob.Text); } else { Console.WriteLine("Last Job: Info does not exists."); };
            if (objExp.Displayed) { Console.WriteLine("Experience: " + objExp.Text); } else { Console.WriteLine("Experience: Info does not exists."); };
            actions.MoveToElement(objShowMore);
            actions.Perform();
            objShowMore.Click();
            if (objSkills.Displayed) { Console.WriteLine("Skills and Validations: " + objSkills.Text); } else { Console.WriteLine("Skills and Validations: Info does not exists."); };
            if (objTools.Displayed) { Console.WriteLine("Tools and Technologies: " + objTools.Text); } else { Console.WriteLine("Tools and Technologies: Info does not exists."); };
            Console.WriteLine();
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

        //Search Txt
        private IWebElement GetSearchField()
        {
            return objSearchText;
        }

        public static void fnEnterSearchText(string pstrSearchText)
        {
            objSearchText.Click();
            objSearchText.Clear();
            objSearchText.SendKeys(pstrSearchText);
        }

        //Search Button
        private IWebElement GetSearchButton()
        {
            return objSearchBtn;
        }

        public static void fnClickSearchBtn()
        {
            objSearchBtn.Click();
        }

        //People Checkbox
        public static IWebElement GetPeopleCB()
        {
            return objPeopleBtn;
        }

        public static void fnSelectPeople()
        {
            objPeopleBtn.Click();
        }

        //All Filters button
        private IWebElement GetAllFilters()
        {
            return objAllFiltersBtn;
        }

        public static void fnSelectAllFilters()
        {
            objAllFiltersBtn.Click();
        }

        //Location Mexico
        private IWebElement GetRegionMx()
        {
            return objRegionMxCb;
        }

        public static void fnGetRegionMx()
        {
            objRegionMxCb.Click();
        }

        //Language English
        private IWebElement GetLanguageEng()
        {
            return objLangEngCb;
        }
        //private IWebElement GetAllResultsPage()
        //{
        //    return objAllResultsPage;
        //}

        public static void fnLanguageEng()
        {
            objLangEngCb.Click();
        }

        public static void fnSelectLanguage(string pstrLanguage)
        {
            IWebElement objLanguageOption = _ObjSrcDriver.FindElement(By.XPath($"//*[text()='{pstrLanguage}']"));
            objLanguageOption.Click();
        }

        //Language Espanish
        private IWebElement GetLanguageEsp()
        {
            return objLangEspCb;
        }

        public static void fnLanguageEsp()
        {
            objLangEspCb.Click();
        }

        //Apply the Filters
        private IWebElement GetApplybutton()
        {
            return objApplyBtn;
        }

        public static void fnClickApplyBtn()
        {
            objApplyBtn.Click();
        }


        private IWebElement AddCountry()
        {
            return objAddCountryTxt;
        }



        public static void fnAddCountry(string pstrAddCountry)
        {
            objAddCountryTxt.Click();
            objAddCountryTxt.Clear();
            objAddCountryTxt.SendKeys(pstrAddCountry);
        }

        public static IWebElement SelectMexico()
        {
            return objSelectMexicoDD;
        }


        public static void fnSelectMexico()
        {
            objSelectMexicoDD.Click();
        }

        private IWebElement ClearFilters()
        {
            return objClearFilters;
        }

        public static void fnClearFilters()
        {
            objClearFilters.Click();
        }
        public static IList<IWebElement> fnAllResultPage()
        {
            IList<IWebElement> objAllSearchResults = _ObjSrcDriver.FindElements(By.XPath(STR_TOTAL_RESULTS_WO));

            return objAllSearchResults;
        }
        public void fnAllResultPage(IWebElement elementToSearch)
        {
            elementToSearch.Click();            
        }
    }
}
