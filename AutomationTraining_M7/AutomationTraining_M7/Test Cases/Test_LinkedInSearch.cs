
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
using SeleniumExtras.WaitHelpers;

namespace AutomationTraining_M7.Test_Cases
{


    class Test_LinkedInSearch : BaseTest
    {
        WebDriverWait waitCaptcha;
        WebDriverWait wait;
        LinkedIn_SearchPage objSearch;


        [Test]
        public void FirstSearch()
        {
            //VARIABLES
            string[] arrLanguages = { "Español", "Inglés" };
            int x = 0;
            string[] arrTechnologies = { "Java", "C#", "C++", "Pega", "Cobol" };
            int y = 0;
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //Step 1 - Login
            //Reusing Login from Test_LinkedIn
            Test_LinkedIn objLogin = new Test_LinkedIn();
            objLogin.Login_LinkedIn();

            //Captcha, if needed
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
                        waitCaptcha = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
                        objCheckbox = waitCaptcha.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@role='checkbox']")));
                        if (objCheckbox.Enabled) { objCheckbox.Click(); }

                    }
                }
            }

            //Step 2 - Select People or Gente Filter
            objSearch = new LinkedIn_SearchPage(driver);
            wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));

            //Perform any search and wait to load the results
            LinkedIn_SearchPage.fnEnterSearch("Jose Luis");
            //Select the first filter for People or Gente.
            //wait.fnWait("//span[text()='Todos los filtros'] | //span[text()='All Filters']");
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Gente'] | //span[text()='People']")));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Gente'] | //span[text()='People']")));
            LinkedIn_SearchPage.fnClickPeople();



            //Step 3 - Select "All Filters" option
            //Select the option for “All Filters” and wait to open the window.
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Todos los filtros'] | //span[text()='All Filters']")));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Todos los filtros'] | //span[text()='All Filters']")));
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='Todos los filtros'] | //span[text()='All Filters']")));
            LinkedIn_SearchPage.fnClickAllFilter();


            //Step 4 - Select Location Mexico and Italy
            //In Location Option, select the option for Mexico.
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//label[text()='México']")));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//label[text()='México']")));
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//label[text()='México']")));

            LinkedIn_SearchPage.fnGetMexico();
            LinkedIn_SearchPage.fnWriteCountry("Italy");
            LinkedIn_SearchPage.fnGetItaly();

            //Step 5 - Select Languages
            //In Profile language, select the options provided in the array arrLanguages
            foreach (string strlanguages2 in arrLanguages)
            {
                x++;
                LinkedIn_SearchPage.fnGetLanguage(strlanguages2);
            }

            //Step 6 - Apply the filters
            LinkedIn_SearchPage.fnGetApply();


            //Step 7 - Second Array
            foreach (string strtechnologies in arrTechnologies)
            {
                y++;
                LinkedIn_SearchPage.fnEnterSearch(strtechnologies);
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='blended-srp-results-js pt0 pb4 ph0 container-with-shadow']")));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='blended-srp-results-js pt0 pb4 ph0 container-with-shadow']")));
                wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@class='blended-srp-results-js pt0 pb4 ph0 container-with-shadow']")));
                LinkedIn_SearchPage.fnTechResults();
            }

        }
        /*
        public void fnWait(string pXpath) 
        {
            wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            WebDriverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(pXpath)));
            WebDriverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(pXpath)));
            WebDriverWait.Until(ExpectedConditions.ElementExists(By.XPath(pXpath)));
        }*/
    }
}