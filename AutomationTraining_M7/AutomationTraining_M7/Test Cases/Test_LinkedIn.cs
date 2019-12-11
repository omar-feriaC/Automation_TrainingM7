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
    class Test_LinkedIn : BaseTest
    {
        WebDriverWait wait;
        private const string XpathToFind = "x";
        LinkedIn_LoginPage objLILP;
        LinkedIn_SearchPage objLISP;

        [Test, Order(0)]
        public void Login_LinkedIn()
        {
            //driver.Url = ConfigurationManager.AppSettings.Get("urlLinkedIn");
            objLILP = new LinkedIn_LoginPage(driver);

            Assert.AreEqual(true, driver.Title.Contains("Login"), "Title does not match");

            LinkedIn_LoginPage.fnEnterUsername(ConfigurationManager.AppSettings.Get("userLinkedIn"));
            LinkedIn_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("passwordLinkedIn"));
            LinkedIn_LoginPage.fnClickSignInButton();
            Thread.Sleep(3000);
            Assert.AreNotEqual(true, driver.Title.Contains("Login"), "Title does not match");
            Assert.IsTrue(driver.Title.Contains("LinkedIn"));

        }
        [Test, Order(1)]
        public void SearchLinkedIn()
        {
            wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            wait.Until(ExpectedConditions.TitleContains(""));
            int intFilterCount = 0;
            string[] arrTechnologies = { "Java", "C#", "C++", "Pega", "Cobol" };
            string[] arrLanguages = { "Spanish", "English" };

            //driver.Url = ConfigurationManager.AppSettings.Get("urlLinkedIn");
            objLILP = new LinkedIn_LoginPage(driver);
            //Login
            LinkedIn_LoginPage.fnEnterUsername(ConfigurationManager.AppSettings.Get("userLinkedIn"));
            LinkedIn_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("passwordLinkedIn"));
            LinkedIn_LoginPage.fnClickSignInButton();
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[text()='Welcome, Edmundo!']")));
            
            //Login asserts
            Assert.AreNotEqual(true, driver.Title.Contains("Login"), "Title does not match");
            Assert.IsTrue(driver.Title.Contains("LinkedIn"));
            
            //Initialize Search driver
            objLISP = new LinkedIn_SearchPage(driver);
            
            //Search
            LinkedIn_SearchPage.fnEnterSearchCriteria(ConfigurationManager.AppSettings.Get("searchCriteria"));
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//button[span[text()='People' or text()='Gente']]")));
            //Assert.IsTrue(driver.Title.Contains("Search/results"));
            
            //Select people filter
            LinkedIn_SearchPage.fnClickPeopleButton();
            //wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='All Filters' or text()='Todos los Filtros']")));
            LinkedIn_SearchPage.fnWaitPage();
            //INSERT Assert.something here

            //Select all filters
            LinkedIn_SearchPage.fnClickAllFiltersButton();
            LinkedIn_SearchPage.fnWaitPage();
           
            //select location Mexico 
            //INSERT Assert.something here
            LinkedIn_SearchPage.fnClickMexicoCheckbox();
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='"+ ++intFilterCount + "']")));

            //select location Italy
            LinkedIn_SearchPage.fnEnterLocationCriteria(ConfigurationManager.AppSettings.Get("searchLocationCriteria"));
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='" + ++intFilterCount + "']")));
            
            //select lenguages
            foreach (string strvalue in arrLanguages)
            {
                switch (strvalue)
                {
                    case "Spanish":
                        LinkedIn_SearchPage.fnClickSpanishCheckbox();
                        wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='" + ++intFilterCount + "']")));
                        break;
                    case "English":
                        LinkedIn_SearchPage.fnClickEnglishCheckbox();
                        wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='" + ++intFilterCount + "']")));
                        break;
                }                
            }

            //Apply all filters
            LinkedIn_SearchPage.fnClickApplyFiltersButton();
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='4']")));

            string strPrevURL;
            foreach (string strvalue in arrTechnologies)
            {
                //Search technology
                LinkedIn_SearchPage.fnEnterSearchCriteria(strvalue);
                wait.Until(ExpectedConditions.TitleContains(strvalue));
                
                //Print technology first result
                Console.WriteLine("Technology "+strvalue+" :");
                Console.WriteLine("Name: "+LinkedIn_SearchPage.GetNameSpan().Text);
                Console.WriteLine("Role: "+LinkedIn_SearchPage.GetRoleSpan().Text);
                Console.WriteLine("LinkedIn URL: "+LinkedIn_SearchPage.GetUrlA().GetAttribute("href"));
                Console.WriteLine("-----------");
                strPrevURL = LinkedIn_SearchPage.GetUrlA().GetAttribute("href");
            }
        }
    }
}
