
﻿using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
﻿using AutomationTraining_M7.Base_Files;
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
        public WebDriverWait _driverWait;
        LinkedIn_SearchPage objSearch;


        //[Test]
        public void FirstSearch()
        {
            //VARIABLES
            string[] arrLanguages = { "Español", "Inglés" };
            int x = 0;
            string[] arrTechnologies = { "Java", "C#", "C++", "Pega", "Cobol" };
            int y = 0;

            //Step 1 - Login
            objSearch = new LinkedIn_SearchPage(driver);
            LinkedIn_LoginPage objLogin = new LinkedIn_LoginPage(driver);
            Assert.AreEqual(true, driver.Title.Contains("Login"), "Title not mach");
            LinkedIn_LoginPage.fnEnterUserName(ConfigurationManager.AppSettings.Get("username"));
            LinkedIn_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            LinkedIn_LoginPage.fnClickSignInButton();


            //Step 2 - Select People or Gente Filter
            //Perform any search and wait to load the results
            IWebElement webElement = _driverWait.Until(driver => driver.FindElement(By.XPath("//div[@class='search-global-typeahead__controls']")));
            LinkedIn_SearchPage.fnEnterSearch("Jose Luis");
            //Select the first filter for People or Gente.
            IWebElement webElement2 = _driverWait.Until(driver => driver.FindElement(By.XPath("//div[@class='neptune-grid']")));
            LinkedIn_SearchPage.fnClickPeople();


            //Step 3 - Select "All Filters" option
            //Select the option for “All Filters” and wait to open the window.
            IWebElement webElement3 = _driverWait.Until(driver => driver.FindElement(By.XPath("//span[text()='Siguiente']")));
            LinkedIn_SearchPage.fnClickAllFilter();


            //Step 4 - Select Location Mexico and Italy
            //In Location Option, select the option for Mexico.
            IWebElement webElement4 = _driverWait.Until(driver => driver.FindElement(By.XPath("//fieldset[@class='search-s-facet__values search-s-facet__values--geoRegion']")));
            LinkedIn_SearchPage.fnGetMexico();
            //_driverWait.Until(driver => driver.FindElement(By.XPath("//header[contains(@class,'msg-overlay-bubble-header')]")));
            LinkedIn_SearchPage.fnGetItaly("Italy");
            IWebElement webElement5 = _driverWait.Until(driver => driver.FindElement(By.XPath("//header[contains(@class,'msg-overlay-bubble-header')]")));

            //Step 5 - Select Languages
            //In Profile language, select the options provided in the array arrLanguages
            foreach (string strlanguages2 in arrLanguages)
            {
                x++;
                LinkedIn_SearchPage.fnGetLanguage(strlanguages2);
            }

            /*for (int x= 0; x < arrLanguages.Length; x++)
            {
                string strlanguages2 = arrLanguages[x];
                LinkedIn_SearchPage.fnGetLanguage(strlanguages2);
            }*/
            
            //Step 6 - Apply the filters
            LinkedIn_SearchPage.fnGetApply();
            IWebElement webElement6 = _driverWait.Until(driver => driver.FindElement(By.XPath("//header[contains(@class,'msg-overlay-bubble-header')]")));

            //Step 7 - Second Array
            foreach (string strtechnologies in arrTechnologies)
            {
                y++;
                LinkedIn_SearchPage.fnEnterSearch(strtechnologies);
                _driverWait.Until(driver => driver.FindElement(By.XPath("//div[@class='blended-srp-results-js pt0 pb4 ph0 container-with-shadow']")));
                LinkedIn_SearchPage.fnTechResults();
            }

        }

    }
}