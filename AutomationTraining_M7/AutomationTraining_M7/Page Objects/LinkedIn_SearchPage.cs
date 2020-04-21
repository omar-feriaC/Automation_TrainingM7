﻿using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Data_Model;
using NUnit.Framework;
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
        readonly static string STR_LAST_JOB = "(//div[contains(@class,'pv-entity__summary-info pv-entity__summary-info--background-section')])[1]";
        readonly static string STR_EXPERIENCE = "//section[@id='experience-section']";
        readonly static string STR_SHOW_MORE_BTN = "//button[@data-control-name='skill_details']";
        readonly static string STR_SKILLS = "//ol[@class='pv-skill-categories-section__top-skills pv-profile-section__section-info section-info pb1']";
        readonly static string STR_TOOLS = "//div[@class='pv-skill-category-list pv-profile-section__section-info mb6 ember-view']/h3[text()='Herramientas y tecnologías']/following-sibling::ol";
        readonly static string STR_LAST_PROFILE = "(//span[@class='name actor-name'])[10]";

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
        private static IWebElement objShowMore => _ObjSrcDriver.FindElement(By.XPath(STR_SHOW_MORE_BTN));
        private static IList<IWebElement> objName => _ObjSrcDriver.FindElements(By.XPath(STR_NAME));
        private static IList<IWebElement> objRole => _ObjSrcDriver.FindElements(By.XPath(STR_ROLE));

        private static IList<IWebElement> objLastJob => _ObjSrcDriver.FindElements(By.XPath(STR_LAST_JOB));
        private static IList<IWebElement> objExp => _ObjSrcDriver.FindElements(By.XPath(STR_EXPERIENCE));
        private static IList<IWebElement> objSkills => _ObjSrcDriver.FindElements(By.XPath(STR_SKILLS));
        private static IList<IWebElement> objTools => _ObjSrcDriver.FindElements(By.XPath(STR_TOOLS));
        private static IWebElement objLProfileBtn => _ObjSrcDriver.FindElement(By.XPath(STR_LAST_PROFILE));
        /*METHODS*/



        //Get Member Info
        public static IList<IWebElement> GetLastJob()
        {
            return objLastJob;
        }

        public static IWebElement GetShowMore()
        {
            return objShowMore;
        }

        public static void fnScrollDownToSkills()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("window.scrollTo(50, document.body.scrollHeight/3)");
            js.ExecuteScript("window.scrollBy(0,50)");
        }

        //public static void fnScrollElement(By by) 
        //{
        //    do {
        //        fnScrollDownToSkills(
        //    }
        //    while (fnElemetExit(By by));
        //}

        //EDSP
        public static void fnScrollUp()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,-200)");
        }


        public static Candidates fnMemberInfo()
        {
            List<string> objURL = new List<string>();
            Candidates InfoCandidate = new Candidates();
            //objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);

            for (int i = 0; i < objName.Count; i++)
            {
                int height = _ObjSrcDriver.Manage().Window.Size.Height;
                int actual = 0;
                wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
                Actions actions = new Actions(_ObjSrcDriver);
                Console.WriteLine("Name: " + objName[i].Text);
                
                Console.WriteLine();
                Console.WriteLine("Role: " + objRole[i].Text);
                
                Console.WriteLine();
                objURL.Add(_ObjSrcDriver.Url);
                Console.WriteLine("URL: " + objURL[i]);
                
                Console.WriteLine();
                do
                {
                    fnScrollDownToSkills();
                    GetLastJob();
                }
                while (objLastJob.Count == 0);
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LAST_JOB)));
                try 
                { 
                    Console.WriteLine("Last Job: " + objLastJob[i].Text); 
                }
                catch(Exception)
                {
                    continue;
                }
                Console.WriteLine();
                
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_EXPERIENCE)));
                try 
                { 
                    Console.WriteLine("Experience: " + objExp[i].Text); 
                }
                catch(Exception)
                {
                    continue;
                }

                Console.WriteLine();
                do
                {
                    fnScrollDownToSkills();
                    actual += 10;
                    height = _ObjSrcDriver.Manage().Window.Size.Height;
                    try
                    {

                        GetShowMore();
                        objShowMore.Click();
                        break;
                    }
                    catch(Exception)
                    {
                        continue;
                    }
                }
                while (actual < height);
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_SHOW_MORE_BTN)));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_SKILLS)));
                try 
                { 
                    Console.WriteLine("Skills and Validations: " + objSkills[i].Text); 
                }
                catch(Exception)
                {
                    continue;
                }
                Console.WriteLine();
                
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_TOOLS)));
                try 
                { 
                    Console.WriteLine("Tools and Technologies: " + objTools[i].Text); 
                }
                catch(Exception)
                {
                    continue;
                }
                
                Console.WriteLine("____________________________________________________");

                //Export ifno to CSV file
                //CODE TO  GET CANDIDATE DATA
                InfoCandidate = new Candidates
                {
                    ActorName = objName[i].Text,
                    ProfileRole = objRole[i].Text,
                    LinkedInUrl = objURL[i],
                    LastJob = objLastJob[i].Text,
                    Experience = objExp[i].Text,                   
                    SkillsValidations = objSkills[i].Text,
                    ToolsTechnologies = objTools[i].Text
                };
            }
            return InfoCandidate;
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
            //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_TOTAL_RESULTS_WO)));
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
            bool flag;
            do
            {
                fnScrollDownToSkills();
                try
                {
                    GetElement(By.XPath(STR_LAST_PROFILE));
                    flag = true;
                    break;
                }
                catch (NoSuchElementException)
                {
                    flag = false;
                    continue;
                }
            }
            while (!flag);

            IList<IWebElement> objAllSearchResults = _ObjSrcDriver.FindElements(By.XPath(STR_TOTAL_RESULTS_WO));
            return objAllSearchResults;
        }

        public static IWebElement GetElement(By by)
        {
            return _ObjSrcDriver.FindElement(by);
        }
        public void fnAllResultPage(IWebElement elementToSearch)
        {
            elementToSearch.Click();            
        }
    }
}
