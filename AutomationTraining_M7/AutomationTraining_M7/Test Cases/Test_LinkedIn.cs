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
            //Reusing the Login Page functionality
            Login_LinkedIn();
            objSearch = new LinkedIn_SearchPage(driver);

            //*****Step 2*****//
            LinkedIn_SearchPage.fnSendInfo("4th Source");

            //Giving some time for the results and People button to load
            Task.Delay(5000).Wait();

            //Verifying that Initial Search executed successfully by checking if the filter bar is present or not
            Boolean isPresent = driver.FindElements(By.XPath("//div[contains(@class,'search-filters-bar')]")).Count() > 0;
            Assert.AreEqual(true, isPresent);


            //*****Step 3*****//
            LinkedIn_SearchPage.fnClickPeopleButton();

            //Giving some time for the page to reload
            Task.Delay(10000).Wait();

            // Verifying that People Filter was selected by checking if the filter Jobs dissapeared
            Boolean isPresent2 = driver.FindElements(By.XPath("//button[contains(@aria-label,'View only Jobs results')]")).Count() > 0;
            Assert.AreEqual(false, isPresent2);


            //*****Step 4*****//
            LinkedIn_SearchPage.fnClickAllFiltersButton();

            //Giving some time for the page to reload
            Task.Delay(5000).Wait();

            // Verifying that All Filter was selected by checking if the "All People Filters" Header is displayed
            Boolean isPresent3 = driver.FindElements(By.XPath("//h2[@id='advanced-facets-modal-header' and text()='All people filters']")).Count() > 0;
            Assert.AreEqual(true, isPresent3);


            //*****Step 5*****//
            LinkedIn_SearchPage.fnClickMexicoCheckbox();

            //Giving some time for the page to reload
            Task.Delay(5000).Wait();

            // Verifying that Mexico Checkbox was selected by checking if the counter of checked options is enabled and equal to 1
            Boolean isPresent4 = driver.FindElements(By.XPath("//span[@class= 'search-advanced-facets__selected-counts mv0 ml1' and text() ='1']")).Count > 0;
            Assert.AreEqual(true, isPresent4);


            //*****Step 6*****//
            LinkedIn_SearchPage.fnClickEnglishCheckbox();

            // Verifying that English Checkbox was selected by checking if the counter of checked options is enabled and equal to 2
            Boolean isPresent5 = driver.FindElements(By.XPath("//span[@class= 'search-advanced-facets__selected-counts mv0 ml1' and text() ='2']")).Count > 0;
            Assert.AreEqual(true, isPresent5);


            LinkedIn_SearchPage.fnClickSpanishCheckbox();

            // Verifying that English Checkbox was selected by checking if the counter of checked options is enabled and equal to 3
            Boolean isPresent6 = driver.FindElements(By.XPath("//span[@class= 'search-advanced-facets__selected-counts mv0 ml1' and text() ='3']")).Count > 0;
            Assert.AreEqual(true, isPresent6);


            //*****Step 7*****//
            LinkedIn_SearchPage.fnApplyAllFiltersButton();

            //Giving some time for the page to reload
            Task.Delay(5000).Wait();

            // Verifying that All Filters were applied by checking if the Main Page Filter has Mexico Selected
            Boolean isPresent7 = driver.FindElements(By.XPath("//span[@class='artdeco-button__text' and text()='Mexico']")).Count > 0;
            Assert.AreEqual(true, isPresent7);


            //*****Step 8*****//
            LinkedIn_SearchPage.fnSendInfo("Selenium");

            //Giving some time for the results and People button to load
            Task.Delay(3000).Wait();

            // Verifying that Technology search is successful by checking that there were results retrieved
            Boolean isPresent8 = driver.FindElements(By.XPath("//span[contains(text(),'Selenium')]")).Count > 0;
            Assert.AreEqual(true, isPresent8);


            LinkedIn_SearchPage.fnSendInfo("Java");

            //Giving some time for the results and People button to load
            Task.Delay(3000).Wait();

            // Verifying that Technology search is successful by checking that there were results retrieved
            Boolean isPresent9 = driver.FindElements(By.XPath("//span[contains(text(),'Java')]")).Count > 0;
            Assert.AreEqual(true, isPresent9);


            LinkedIn_SearchPage.fnSendInfo("Python");

            //Giving some time for the results and People button to load
            Task.Delay(3000).Wait();

            // Verifying that Technology search is successful by checking that there were results retrieved
            Boolean isPresent10 = driver.FindElements(By.XPath("//span[contains(text(),'Python')]")).Count > 0;
            Assert.AreEqual(true, isPresent10);


            LinkedIn_SearchPage.fnSendInfo("Delphi");

            //Giving some time for the results and People button to load
            Task.Delay(3000).Wait();

            // Verifying that Technology search is successful by checking that there were results retrieved
            Boolean isPresent11 = driver.FindElements(By.XPath("//span[contains(text(),'Delphi')]")).Count > 0;
            Assert.AreEqual(true, isPresent11);


            LinkedIn_SearchPage.fnSendInfo("Ruby");

            //Giving some time for the results and People button to load
            Task.Delay(3000).Wait();

            // Verifying that Technology search is successful by checking that there were results retrieved
            Boolean isPresent12 = driver.FindElements(By.XPath("//span[contains(text(),'Ruby')]")).Count > 0;
            Assert.AreEqual(true, isPresent12);
        }
    }
}
