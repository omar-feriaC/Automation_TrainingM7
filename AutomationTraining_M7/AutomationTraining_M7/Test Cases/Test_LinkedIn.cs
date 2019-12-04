using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        private const string XpathToFind = "x";
        LinkedIn_LoginPage objLILP;
        LinkedIn_SearchPage objLISP;
        public WebDriverWait _driverWait;
        [Test, Order(0)]
        public void Login_LinkedIn()
        {
            driver.Url = ConfigurationManager.AppSettings.Get("urlLinkedIn");
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

            string[] arrTechnologies = { "Java", "C#", "C++", "Pega", "Cobol" };
            string[] arrLanguages = { "Spanish", "English" };

            driver.Url = ConfigurationManager.AppSettings.Get("urlLinkedIn");
            objLILP = new LinkedIn_LoginPage(driver);
            //Login
            LinkedIn_LoginPage.fnEnterUsername(ConfigurationManager.AppSettings.Get("userLinkedIn"));
            LinkedIn_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("passwordLinkedIn"));
            LinkedIn_LoginPage.fnClickSignInButton();
            LinkedIn_SearchPage.fnWaitPage();
            Assert.AreNotEqual(true, driver.Title.Contains("Login"), "Title does not match");
            Assert.IsTrue(driver.Title.Contains("LinkedIn"));
            //Initialize Search driver
            objLISP = new LinkedIn_SearchPage(driver);
            //Search
            LinkedIn_SearchPage.fnEnterSearchCriteria(ConfigurationManager.AppSettings.Get("serchCriteria"));
            LinkedIn_SearchPage.fnClickSearchButton();
            LinkedIn_SearchPage.fnWaitPage();
            //Assert.IsTrue(driver.Title.Contains("search/results"));
            LinkedIn_SearchPage.fnClickPeopleButton();
            LinkedIn_SearchPage.fnWaitPage();
            //INSERT Assert.something here
            LinkedIn_SearchPage.fnClickAllFiltersButton();
            LinkedIn_SearchPage.fnWaitPage();
            //INSERT Assert.something here
            LinkedIn_SearchPage.fnClickMexicoCheckbox();
            LinkedIn_SearchPage.fnClickSpanishCheckbox();
            LinkedIn_SearchPage.fnClickEnglishCheckbox();
            LinkedIn_SearchPage.fnClickApplyFiltersButton();
            LinkedIn_SearchPage.fnWaitPage();

            foreach (string strvalue in arrTechnologies)
            {
                LinkedIn_SearchPage.fnEnterSearchCriteria(strvalue);
                LinkedIn_SearchPage.fnClickSearchButton();
            }

        }
        

    }
}
