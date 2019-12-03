using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Test_Cases;
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

namespace AutomationTraining_M7.Page_Objects
{
    class Test_LinkedInSearch : Test_LinkedIn
    {
        LinkedIn_SearchPage objSearch;
        WebDriverWait wait;

        [Test]
        public void TestSearch()
        {
            Test1();

            wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            wait.Until(condition => driver.Title.Equals("LinkedIn"));

            objSearch = new LinkedIn_SearchPage(driver);

            LinkedIn_SearchPage.fnEnterSearchText(ConfigurationManager.AppSettings.Get("search"));
            LinkedIn_SearchPage.fnClickSearchButton();

            wait.Until(condition => driver.Title.Contains(ConfigurationManager.AppSettings.Get("search")));
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnClickPeopleButton();
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnClickAllFiltersButton();
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnClickLocationComboBox();
            Thread.Sleep(2000);
            LinkedIn_SearchPage.fnClickEnglishLanguageComboBox();
            Thread.Sleep(2000);
            LinkedIn_SearchPage.fnClickSpanishLanguageComboBox();
            Thread.Sleep(2000);
            LinkedIn_SearchPage.fnClickApplyButton();
            Thread.Sleep(5000);

            string[] search = {"csharp","python","selenium","jmeter","ruby"};

            for(int i = 0; i < search.Length; i++)
            {
                LinkedIn_SearchPage.fnEnterSearchText(search[i]);
                LinkedIn_SearchPage.fnClickSearchButton();
                wait.Until(condition => driver.Title.Contains(search[i]));
            }
        }
    }
}
