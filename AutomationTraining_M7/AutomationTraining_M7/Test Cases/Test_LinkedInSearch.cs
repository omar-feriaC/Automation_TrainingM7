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
        LinkedIn_SearchPage objSearch;


        //[Test]
        public void FirstSearch()
        {
            //Step 1 - Login
            objSearch = new LinkedIn_SearchPage(driver);
            LinkedIn_LoginPage objLogin = new LinkedIn_LoginPage(driver);
            Assert.AreEqual(true, driver.Title.Contains("Login"), "Title not mach");
            LinkedIn_LoginPage.fnEnterUserName(ConfigurationManager.AppSettings.Get("username"));
            LinkedIn_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            LinkedIn_LoginPage.fnClickSignInButton();
            Thread.Sleep(5000);

            //Step 2 - Select People or Gente Filter
            //Perform any search and wait to load the results
            LinkedIn_SearchPage.fnEnterSearch("Jose Luis");
            Thread.Sleep(5000);
            //Select the first filter for People or Gente.
            LinkedIn_SearchPage.fnClickPeople();
            Task.Delay(5000).Wait();

            //Step 3 - Select the option "All Filters"
            //Select the option for “All Filters” and wait to open the window.
            LinkedIn_SearchPage.fnClickAllFilter();
            Task.Delay(5000).Wait();

            //Step 4 - Select Loation Mexico and Italy
            //In Location Option, select the option for Mexico.
            LinkedIn_SearchPage.fnGetMexico();
            Task.Delay(5000).Wait();
            LinkedIn_SearchPage.fnGetItaly("Italy");
            Thread.Sleep(5000);


            /* Previous execersise
            //In Profile language, select English and Spanish options.
            LinkedIn_SearchPage.fnGetLanguage();
            Thread.Sleep(5000);

            //Apply the filters.
            LinkedIn_SearchPage.fnGetApply();
            Thread.Sleep(5000);

            //Using filter provided now search 5 technologies
            LinkedIn_SearchPage.fnEnterSearch("Java");
            Thread.Sleep(5000);

            LinkedIn_SearchPage.fnEnterSearch("C#");
            Thread.Sleep(5000);

            LinkedIn_SearchPage.fnEnterSearch("PHP");
            Thread.Sleep(5000);

            LinkedIn_SearchPage.fnEnterSearch("SQL");
            Thread.Sleep(5000);

            LinkedIn_SearchPage.fnEnterSearch("Quality Engineer Automation Testing");
            Thread.Sleep(5000);*/
        }


    }
}