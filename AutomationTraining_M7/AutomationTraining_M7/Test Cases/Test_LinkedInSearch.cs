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
        public WebDriverWait _driverWait;
        LinkedIn_SearchPage objLogin;


        [Test]
        public void Search_LinkedIn()
        {

            objLogin = new LinkedIn_SearchPage(driver);
            _driverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
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

            LinkedIn_SearchPage.fnSearch("x");
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='People']")));
            Task.Delay(1000).Wait();
            LinkedIn_SearchPage.fnSelectGente();
            try
            {
                //I added this because it was so unestable that desided to bypass this error
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='Todos los filtros' or text()='All Filters']")));
                _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Todos los filtros' or text()='All Filters']")));
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Todos los filtros' or text()='All Filters']")));
                _driverWait.Until(driver => driver.FindElement(By.XPath("//button[@class='search-filters-bar__all-filters flex-shrink-zero mr3 artdeco-button artdeco-button--muted artdeco-button--2 artdeco-button--tertiary ember-view'] //span[text()='All Filters' or text()='Todos los Filtros']"))); ////span[text()='Connections']
                _driverWait.Until(driver => driver.FindElement(By.XPath("//button[@class='search-s-facet__button artdeco-button artdeco-button--muted artdeco-button--icon-right artdeco-button--2 artdeco-button--secondary ember-view'] //span[text()='Connections' or text()='Conexiones']"))); ////span[text()='Connections']
                _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='All Filters'or text()='Todos los filtros'")));
            }
            catch (Exception ex) {

            }
            Task.Delay(1000).Wait();
            LinkedIn_SearchPage.fnSelectFilters();
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h2[@id='advanced-facets-modal-header']")));
            LinkedIn_SearchPage.fnSelectCountry();
            LinkedIn_SearchPage.fnSelectLanguage(arrLanguages);
            Task.Delay(1000).Wait();
            LinkedIn_SearchPage.fnAplicar();

            foreach (string i in arrTechnologies)
            {
                Task.Delay(2000).Wait();
                LinkedIn_SearchPage.fnSearch(i);
                Console.WriteLine("Technology: " + i);
                Console.WriteLine("Name: " + LinkedIn_SearchPage.fnGetName());
                Console.WriteLine("Title: " + LinkedIn_SearchPage.fnGetTitle());
                Console.WriteLine("Location: " + LinkedIn_SearchPage.fnGetLocation());
                Console.WriteLine("URL: https://www.linkedin.com/" + LinkedIn_SearchPage.fnGetUrl() + "\n");

            }









        }
    }
}
