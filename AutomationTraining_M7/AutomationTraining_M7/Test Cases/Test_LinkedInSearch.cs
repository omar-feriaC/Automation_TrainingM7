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
    class Test_LinkedInSearch : Test_LinkedIn
    {
        LinkedIn_SearchPage objLogin; //-- DELETE
        public WebDriverWait _driverWait;
      
        [Test]
        public void Search_LinkedIn()
        {
            //VARIABLES
            string[] arrTechnologies = { "Java", "C#", "C++", "Pega", "Cobol" };
            string[] arrLanguages = { "Spanish", "English" };

            //Step# 1 .- Log In 
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
                        _driverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
                        objCheckbox = _driverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@role='checkbox']")));
                        if (objCheckbox.Enabled) { objCheckbox.Click(); }
                        
                    }
                }
            }
            objLogin = new LinkedIn_SearchPage(driver);
            //Thread.Sleep(TimeSpan.FromSeconds(10));
            Utils.AssertIsPresent(LinkedIn_SearchPage.searchTxt);
            LinkedIn_SearchPage.fnSearchField("Juan");
            LinkedIn_SearchPage.searchTxt.SendKeys(Keys.Enter);
            Utils.AssertIsPresent(LinkedIn_SearchPage.genteBtn);
            //Thread.Sleep(TimeSpan.FromSeconds(10));
            LinkedIn_SearchPage.fnClickGente();
            Utils.AssertIsPresent(LinkedIn_SearchPage.filtrosBtn);
            LinkedIn_SearchPage.fnClickAllFilters();
            Utils.AssertIsPresent(LinkedIn_SearchPage.ubicacionChBtn);
            LinkedIn_SearchPage.fnClickMexico();
            LinkedIn_SearchPage.fnAddCountryField("Italy");
            Utils.AssertIsPresent(LinkedIn_SearchPage.idiomaEnChBtn);
            LinkedIn_SearchPage.fnClickEnglish();

            foreach (string strlanguage in arrLanguages)
            {
                LinkedIn_SearchPage.fnSelectandClickLanguage(strlanguage);
            }


        }
    }
}
