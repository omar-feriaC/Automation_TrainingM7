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
            objLogin = new LinkedIn_LoginPage(driver);
            Assert.AreEqual(true, driver.Title.Contains("Login"), "Title not match");
            LinkedIn_LoginPage.fnEnterUserName(ConfigurationManager.AppSettings.Get("username"));
            LinkedIn_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            LinkedIn_LoginPage.fnClickSignInButton();

            objSearch = new LinkedIn_SearchPage(driver);

            LinkedIn_SearchPage.fnEnterSearchText(ConfigurationManager.AppSettings.Get("search1"));
            LinkedIn_SearchPage.fnClickSearchButton();
            //Webdriver wait
            wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='People' or text()='Gente']")));

            LinkedIn_SearchPage.fnClickPeopleBtn();
            wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='All Filters' or text()='Todos los filtros']]")));

            LinkedIn_SearchPage.fnClickAllFiltersBtn();
            wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//label[text()='México' or text()='Mexico']")));

            //Region Mexico
            LinkedIn_SearchPage.fnClickRegionMexCb();
            Thread.Sleep(5000);
            //Region Italy
            LinkedIn_SearchPage.fnClickRegionTxt(ConfigurationManager.AppSettings.Get("region"));
            Thread.Sleep(5000);

            LinkedIn_SearchPage.fnClickLangEspCb();
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnClickLangEngCb();
            Thread.Sleep(5000);
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