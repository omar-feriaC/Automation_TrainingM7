<<<<<<< HEAD
﻿using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
=======
﻿using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
>>>>>>> d775a935586d5c9c14de53cfa0f9f1e1718a14b7
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
<<<<<<< HEAD
    class Test_LinkedInSearch : Test_LinkedIn
    {
        //LinkedIn_LoginPage objLogin; -- DELETE
        public WebDriverWait _driverWait;
        LinkedIn_SearchPage objSearch;

        [Test]
        public void Search_LinkedIn()
        {
            //VARIABLES
            string[] arrTechnologies = { "Java", "C#", "C++", "Pega", "Cobol" };
            string[] arrLanguages = { "Spanish", "English" };

            //Step# 1 .- Log In 
=======
    class Test_LinkedInSearch : BaseTest
    {
        LinkedIn_SearchPage objSearch;


        //[Test]
        public void FirstSearch()
        {
            //Step 1 - Login
>>>>>>> d775a935586d5c9c14de53cfa0f9f1e1718a14b7
            objSearch = new LinkedIn_SearchPage(driver);
            LinkedIn_LoginPage objLogin = new LinkedIn_LoginPage(driver);
            Assert.AreEqual(true, driver.Title.Contains("Login"), "Title not mach");
            LinkedIn_LoginPage.fnEnterUserName(ConfigurationManager.AppSettings.Get("username"));
            LinkedIn_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            LinkedIn_LoginPage.fnClickSignInButton();
<<<<<<< HEAD

            //Step# 2 .- Verify if captcha exist
            if (driver.Title.Contains("Verification") | driver.Title.Contains("Verificación"))
            {
                //Switch to Iframe(0)
                driver.SwitchTo().DefaultContent();
                driver.SwitchTo().Frame(driver.FindElement(By.Id("captcha-internal")));
                //Switch to Iframe that contains captcha.
                IWebElement objCheckbox;
                List<IWebElement> frames = new List<IWebElement>(driver.FindElements(By.TagName("iframe")));
                for (int i = 0; i < frames.Count - 1; i++)
                {
                    if (frames[i].GetAttribute("role").ToString() == "presentation" | frames[i].GetAttribute("role").ToString() != "")
                    {
                        driver.SwitchTo().Frame(i);
                        _driverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
                        objCheckbox = _driverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@role='checkbox']")));
                        if (objCheckbox.Enabled) { objCheckbox.Click(); }
                        
                    }
                }
            }

            //Step# 3 .- Set Filters
            LinkedIn_SearchPage.fnEnterSearchText("Java");
            LinkedIn_SearchPage.fnClickSearchBtn();
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

            //Step# 4 .- Search Elements
            foreach (string strvalue in arrTechnologies)
            {
                LinkedIn_SearchPage.fnEnterSearchText(strvalue);
                LinkedIn_SearchPage.fnClickSearchBtn();
            }


        }
=======
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


>>>>>>> d775a935586d5c9c14de53cfa0f9f1e1718a14b7
    }
}