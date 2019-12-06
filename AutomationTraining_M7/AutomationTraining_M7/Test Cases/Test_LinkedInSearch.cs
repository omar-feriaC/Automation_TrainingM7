using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_SearchLinkedIn : BaseTest
    {
        LinkedIn_LoginPage objLogin;
        LinkedIn_SearchPage objSearch;
        //Webdriver wait
        WebDriverWait wait;

        [Test]
        public void Search_LinkedIn()
        {
            // VARIABLES
            string[] arrTechnologies = { "Java", "C#", "C++", "Pega", "Cobol" };
            string[] arrLanguages = { "Español", "Inglés" };
            
            objLogin = new LinkedIn_LoginPage(driver);
            Assert.AreEqual(true, driver.Title.Contains("Login"), "Title not match");
            LinkedIn_LoginPage.fnEnterUserName(ConfigurationManager.AppSettings.Get("username"));
            LinkedIn_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            LinkedIn_LoginPage.fnClickSignInButton();

            objSearch = new LinkedIn_SearchPage(driver);

            LinkedIn_SearchPage.fnEnterSearchText(ConfigurationManager.AppSettings.Get("search1"));
            LinkedIn_SearchPage.fnClickSearchButton();           
            wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='People' or text()='Gente']")));

            LinkedIn_SearchPage.fnClickPeopleBtn();
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@class='search-vertical-filter__dropdown-trigger-text mr1'][text()='Gente']")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='All Filters' or text()='Todos los filtros']]")));

            LinkedIn_SearchPage.fnClickAllFiltersBtn();
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@placeholder='Añadir un país o región'][@aria-label='Añadir un país o región']")));
            
            //Region Mexico
            LinkedIn_SearchPage.fnAddRegionMexTxt(ConfigurationManager.AppSettings.Get("regionMMx"));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'México']")));
            LinkedIn_SearchPage.fnEnterRegionMexText();
            // driver.FindElement(By.XPath("//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'México']")).Click();
            

            //Region Italy
            LinkedIn_SearchPage.fnAddRegionItaTxt(ConfigurationManager.AppSettings.Get("regionIta"));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Italy']")));
            LinkedIn_SearchPage.fnEnterRegionMItaText();

            foreach (string language in arrLanguages)
            {
                LinkedIn_SearchPage.fnClickLanguageCb(language);
            }

            wait.Until(ExpectedConditions.ElementExists(By.XPath("//button[@data-control-name='all_filters_apply']")));
            LinkedIn_SearchPage.fnClickApplyBtn();
            Thread.Sleep(5000);

            LinkedIn_SearchPage.fnEnterSearchText(ConfigurationManager.AppSettings.Get("search2"));
            LinkedIn_SearchPage.fnClickSearchButton();
            Thread.Sleep(5000);

            LinkedIn_SearchPage.fnEnterSearchText(ConfigurationManager.AppSettings.Get("search3"));
            LinkedIn_SearchPage.fnClickSearchButton();
            Thread.Sleep(5000);

            LinkedIn_SearchPage.fnEnterSearchText(ConfigurationManager.AppSettings.Get("search4"));
            LinkedIn_SearchPage.fnClickSearchButton();
            Thread.Sleep(5000);

            LinkedIn_SearchPage.fnEnterSearchText(ConfigurationManager.AppSettings.Get("search5"));
            LinkedIn_SearchPage.fnClickSearchButton();
            Thread.Sleep(5000);

        }
    }
}