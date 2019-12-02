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
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_LinkedInSearch : Test_LinkedIn
    {
       //LinkedIn_LoginPage objLogin = new LinkedIn_LoginPage(driver);
        LinkedIn_SearchPage objSearch;
        //WebDriverWait wait;

        [Test]
        public void Search()
        {
            Login_LinkedIn();
            objSearch = new LinkedIn_SearchPage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            LinkedIn_SearchPage.fnSearchText("Amazon");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            /*
            LinkedIn_SearchPage.fnClickPeopleButton();
            LinkedIn_SearchPage.fnSelectAllFilltersButton();
            LinkedIn_SearchPage.fnSelectMexicoCheckbox();
            LinkedIn_SearchPage.fnSelectSpanishCheckbox();
            LinkedIn_SearchPage.fnSelectEnglishCheckbox();
            */
        }
    }
}