using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_LinkedIn : BaseTest
    {
        LinkedIn_LoginPage objLogin;
        LinkedIn_SearchPage objSearch;

        [Test]
        public void Login_LinkedIn()
        {
            objLogin = new LinkedIn_LoginPage(driver);

            //Verifying the Log in page opened
            Assert.AreEqual(true, driver.Title.Contains("Login"), "Login page was not displayed");

            LinkedIn_LoginPage.fnEnterUserName(ConfigurationManager.AppSettings.Get("username"));
            LinkedIn_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            LinkedIn_LoginPage.fnClickSignInButton();
            

            //Verifying the Log in was successful by checking if the feed page opened
            Assert.AreEqual("https://www.linkedin.com/feed/", driver.Url) ;  


         
        }


        [Test]
                                                                                                                                                                             
        public void Search_LinkedIn()
        {
            Login_LinkedIn();
            objSearch = new LinkedIn_SearchPage(driver);

            LinkedIn_SearchPage.fnSendInfo("4th Source");

            //Giving some time for the results and People button to load
            Task.Delay(10000).Wait();


            //Verifying that Initial Search executed successfully by checking if the filter bar is present or not
            Boolean isPresent = driver.FindElements(By.XPath("//div[contains(@class,'search-filters-bar')]")).Count() > 0;
            Assert.AreEqual(true, isPresent);
           

            LinkedIn_SearchPage.fnClickPeopleButton();

            //Giving some time for the page to reload
            Task.Delay(10000).Wait();

            // Verifying that People Filter was selected by checking if the filter Jobs dissapeared
            Boolean isPresent2 = driver.FindElements(By.XPath("//button[contains(@aria-label,'View only Jobs results')]")).Count() > 0;
            Assert.AreEqual(false, isPresent2);
            

            LinkedIn_SearchPage.fnClickAllFiltersButton();

            //Giving some time for the page to reload
            Task.Delay(5000).Wait();

            // Verifying that All Filter was selected by checking if the "All People Filters" 
            Boolean isPresent3 = driver.FindElements(By.XPath("//h2[@id='advanced-facets-modal-header']")).Count() > 0;
            Assert.AreEqual(true, isPresent3);


            LinkedIn_SearchPage.fnClickMexicoCheckbox();


            //Giving some time for the page to reload
            Task.Delay(5000).Wait();

            // Verifying that Mexico Checkbox was selected by checking if the counter of checked options is enabled
            Boolean isPresent4 = driver.FindElements(By.XPath("//span[@class='search-advanced-facets__selected-counts mv0 ml1']")).Count() > 0;
            Assert.AreEqual(true, isPresent4);


        }
    }
}
