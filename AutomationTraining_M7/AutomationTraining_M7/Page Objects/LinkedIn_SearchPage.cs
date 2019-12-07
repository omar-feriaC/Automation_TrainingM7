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
        /*Driver Reference for POM*/
        private static IWebDriver _objDriver;

        /*Locators for each element*/
        readonly static string STR_SEARCH_TEXT = "//input[@placeholder='Search' or @placeholder='Buscar']";
        readonly static string STR_SEARCH_BTN = "//div[@class='search-global-typeahead__controls']";
        readonly static string STR_PEOPLE_BTN = "//span[text()='People' or text()='Gente']";
        readonly static string STR_ALLFILTERS_BTN = "//button[span[text()='All Filters' or text()='Todos los filtros']]";
        readonly static string STR_REGIONMEX_TEXT = "//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Mexico']";
        readonly static string STR_REGIONADD_TEXT = "//input[@placeholder='Add a country/region'][@aria-label='Add a country/region']";
        readonly static string STR_REGIONITA_TEXT = "//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Italy']";
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
        private static IWebElement objRegionAddTxt => _objDriver.FindElement(By.XPath(STR_REGIONADD_TEXT));
        private static IWebElement objRegionMexTxt => _objDriver.FindElement(By.XPath(STR_REGIONMEX_TEXT));
        private static IWebElement objRegionItaTxt => _objDriver.FindElement(By.XPath(STR_REGIONITA_TEXT));        
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

        public static void fnClickApplyBtn()
        {
            objApplyBtn.Click();
        }

        /* ***************************************************************** */
        //Select Region Mexico 
        private static IWebElement fnGetRegionTxt()
        {
            return objRegionAddTxt;
        }

        public static void fnAddRegionMexTxt(string pstrAddRegionMx)
        {
            objRegionAddTxt.SendKeys(pstrAddRegionMx);
        }

        /*  ********************************************************************* */
        //Enter Mexico
        private static IWebElement EnterRegionMexText()
        {
            return objRegionMexTxt;
        }

        public static void fnEnterRegionMexText()
        {
            objRegionMexTxt.Click();
        }

               /* ***************************************************************** */
        //Select Region Italy         
        
        public static void fnAddRegionItaTxt(string pstrAddRegionIta)
        {
            
            objRegionAddTxt.Clear();
            objRegionAddTxt.SendKeys(pstrAddRegionIta);                       
            
        }
        
        /*  ********************************************************************* */
        //Enter Italy
        private static IWebElement EnterRegionMItaText()
        {
            return objRegionItaTxt;
        }

        public static void fnEnterRegionMItaText()
        {
            objRegionItaTxt.Click();           
        }

        /* *********************************************************************** */
        // Language array checkbox
        
        public static void fnClickLanguageCb(string pstringLanguage)
        {
            IWebElement objClickLanguageCb = _objDriver.FindElement(By.XPath($"//*[text()='{pstringLanguage}']"));
            objClickLanguageCb.Click();
        }
              
        //Apply button
        private static IWebElement fnGetApplyBtn()
        {
            return objApplyBtn;
        }

        /* *********************************************************************** */
        // technologies array checkbox
        
        public static void fnGetTechResultsTxt()
        {
            IList<IWebElement> objGetTechResultsName = _objDriver.FindElements(By.XPath("//*[@class='search-results__list list-style-none ']/li//*[@class='actor-name']"));
            IList<IWebElement> objGetTechResultsTitle = _objDriver.FindElements(By.XPath("//*[@class='search-results__list list-style-none ']//*[contains(@class,'level-1')]//*[@dir='ltr']"));
            IList<IWebElement> objGetTechResultsLink = _objDriver.FindElements(By.XPath("//*[@class='search-results__list list-style-none ']//*[contains(@class,'search-result__info')]//a"));

          foreach (var vName in objGetTechResultsName)
            {
                Console.WriteLine("Name: " + vName.Text);
            }

           foreach (var vTitle in objGetTechResultsTitle)
            {
                Console.WriteLine("Title: " + vTitle.Text);
            }

           foreach (var VLink in objGetTechResultsLink)
            {
                Console.WriteLine("Link: " + VLink.GetAttribute("href"));
            }
           
        }
                          
    }

}
