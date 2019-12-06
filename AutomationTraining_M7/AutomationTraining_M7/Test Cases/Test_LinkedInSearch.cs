using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Threading;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_LinkedInSearch : Test_LinkedIn
    {
        //LinkedIn_LoginPage objLogin; -- DELETE
        LinkedIn_SearchPage objSearch;
        public WebDriverWait _driverWait;

        [Test]
        public void Search_LinkedIn()
        {
            //VARIABLES
            string[] arrTechnologies = { "Java", "C#", "C++", "Cobol", "Ruby", "SQL", "Android", "iOS", "Selenium", "Python", "PHP" };
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
            _driverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            objSearch = new LinkedIn_SearchPage(driver);            
            
            //start interacting with the page elements            
            _driverWait.Until(driver => driver.FindElement(By.XPath("//input[@class = 'search-global-typeahead__input']")));
            LinkedIn_SearchPage.fnSearchText("Amazon");

            _driverWait.Until(driver => driver.FindElement(By.XPath("//span[text()='People']")));
            LinkedIn_SearchPage.fnClickPeopleButton();

            _driverWait.Until(driver => driver.FindElement(By.XPath("//button[@class='search-s-facet__button artdeco-button artdeco-button--muted artdeco-button--icon-right artdeco-button--2 artdeco-button--secondary ember-view'] //span[text()='Connections' or text()='Conexiones']"))); ////span[text()='Connections']
            LinkedIn_SearchPage.fnSelectAllFilltersButton();

            _driverWait.Until(driver => driver.FindElement(By.XPath("//label[text()='Mexico' or text()='México']")));            
            LinkedIn_SearchPage.fnSelectMexicoCheckbox();
            
            LinkedIn_SearchPage.fnSearchLocations("Italy");

            for (int x = 0; x < arrLanguages.Length; x++)
            {
                string lang = arrLanguages[x];
                LinkedIn_SearchPage.fnSelectLanguage(lang);
            }
            LinkedIn_SearchPage.fnClickApplyFiltersButton();

            _driverWait.Until(driver => driver.FindElement(By.XPath("//button[@class='search-s-facet__button artdeco-button artdeco-button--icon-right artdeco-button--2 artdeco-button--primary ember-view']")));

            for (int y = 0; y < arrTechnologies.Length; y++)
            {
                string technology = arrTechnologies[y];                              
                LinkedIn_SearchPage.fnSearchText(technology);
                _driverWait.Until(driver => driver.FindElement(By.XPath($"//*[contains(text(),'{technology}')]")));
                Console.WriteLine("=== LinkedIn result for " + technology + " ===");

                _driverWait.Until(driver => driver.FindElement(By.XPath("(//span[@class='name actor-name'])[1]")));
                Console.WriteLine("Name: " + LinkedIn_SearchPage.GetNameSpan().Text);

                _driverWait.Until(driver => driver.FindElement(By.XPath("(//p[@class='subline-level-1 t-14 t-black t-normal search-result__truncate']//span[@dir='ltr'])[1]")));
                Console.WriteLine("Role: " + LinkedIn_SearchPage.GetRoleSpan().Text);

                _driverWait.Until(driver => driver.FindElement(By.XPath("(//a[@class='search-result__result-link ember-view'])[1]")));
                Console.WriteLine("LinkedIn URL: " + LinkedIn_SearchPage.GetUrlA().GetAttribute("href"));
                Console.WriteLine("");
            }
        }
    }
}
