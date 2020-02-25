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
    class Test_LinkedInSearch : Test_LinkedIn
    {
        //LinkedIn_LoginPage objLogin; -- DELETE
        public WebDriverWait wait;
        LinkedIn_SearchPage objSearch;

        [Test]
        public void Search_LinkedIn()
        {
            //VARIABLES
            string[] arrLines = System.IO.File.ReadAllLines(@"C:\Users\daniel.luna\Documents\Automation\Exc 2 Mod 8\Autom_TrngM7\AutomTrng_M7\technologies.txt");
            string[] arrLanguages = { "English" };

            //Step# 1 .- Log In 
            objSearch = new LinkedIn_SearchPage(driver);
            Login_LinkedIn();

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
                        wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
                        objCheckbox = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@role='checkbox']")));
                        if (objCheckbox.Enabled) { objCheckbox.Click(); }
                        
                    }
                }
            }

            //Step# 3 .- Set Filters
            for (int i = 0; i < arrLines.Length; i++)
            {


                objSearch = new LinkedIn_SearchPage(driver);
                LinkedIn_SearchPage.fnEnterSearchText(arrLines[i]);
                LinkedIn_SearchPage.fnClickSearchBtn();
                wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='People' or text()='Gente']]")));

                //Step# 4 .- Selecting People button
                LinkedIn_SearchPage.fnSelectPeople();
                wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@class='search-vertical-filter__dropdown-trigger-text mr1'][text()='People' or text()='Gente']")));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='All Filters' or text()='Todos los filtros']]")));

                //Step# 5 .- Locations selection
                LinkedIn_SearchPage.fnSelectAllFilters();
                wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@placeholder='Add a country/region' or @placeholder='Añadir un país o región'][@aria-label='Add a country/region' or @aria-label='Añadir un país o región']")));
                LinkedIn_SearchPage.fnAddCountry("Mexico");
                Thread.Sleep(5000);
                LinkedIn_SearchPage.fnSelectMexico();
                Thread.Sleep(5000);
                foreach (string language in arrLanguages)
                {
                    LinkedIn_SearchPage.fnSelectLanguage(language);
                }

                //Step# 7 .- Apply the Filters
                LinkedIn_SearchPage.fnClickApplyBtn();
                LinkedIn_SearchPage.fnClearFilters();
            }

            

        }
    }
}
