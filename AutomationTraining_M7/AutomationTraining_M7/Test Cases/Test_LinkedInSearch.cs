using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
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
    class Test_LinkedInSearch : BaseTest
    {
        LinkedIn_LoginPage objLogin;
        LinkedIn_SearchPage objSearch;

        [Test]
        public void Search_LinkedIn_Java()
        {
            objLogin = new LinkedIn_LoginPage(driver);
            Assert.AreEqual(true, driver.Title.Contains("Login"), "Title not mach");
            LinkedIn_LoginPage.fnEnterUserName(ConfigurationManager.AppSettings.Get("username"));
            LinkedIn_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            LinkedIn_LoginPage.fnClickSignInButton();
            Thread.Sleep(5000);

            objSearch = new LinkedIn_SearchPage(driver);
            Assert.AreEqual(true, driver.Title.Contains("Security"), "Title not mach");
            LinkedIn_SearchPage.fnClickCaptcha();
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnEnterSearchText(ConfigurationManager.AppSettings.Get("search1"));
            LinkedIn_SearchPage.fnClickSearchBtn();
            Assert.AreEqual(true, driver.Title.Contains("Java"), "Title not mach");
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnSelectPeople();
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnSelectAllFilters();
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnGetRegionMx();
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnLanguageEng();
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnLanguageEsp();
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnClickApplyBtn();
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnEnterSearchText(ConfigurationManager.AppSettings.Get("search2"));
            LinkedIn_SearchPage.fnClickSearchBtn();
            Assert.AreEqual(true, driver.Title.Contains("C#"), "Title not mach");
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnEnterSearchText(ConfigurationManager.AppSettings.Get("search3"));
            LinkedIn_SearchPage.fnClickSearchBtn();
            Assert.AreEqual(true, driver.Title.Contains("Pearl"), "Title not mach");
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnEnterSearchText(ConfigurationManager.AppSettings.Get("search4"));
            LinkedIn_SearchPage.fnClickSearchBtn();
            Assert.AreEqual(true, driver.Title.Contains("PHP"), "Title not mach");
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnEnterSearchText(ConfigurationManager.AppSettings.Get("search5"));
            LinkedIn_SearchPage.fnClickSearchBtn();
            Assert.AreEqual(true, driver.Title.Contains("Ruby"), "Title not mach");
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnEnterSearchText(ConfigurationManager.AppSettings.Get("search6"));
            LinkedIn_SearchPage.fnClickSearchBtn();
            Assert.AreEqual(true, driver.Title.Contains("Selenium"), "Title not mach");


        }


    }
}
