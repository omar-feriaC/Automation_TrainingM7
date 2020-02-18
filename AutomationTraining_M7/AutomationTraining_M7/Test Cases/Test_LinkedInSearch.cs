using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
    class Test_LinkedInSearch : Test_LinkdIn
    {
        public WebDriverWait _DriverWait;
        LinkedIn_SearchPage objSearch;

        [Test]
        public void Search_LinkIn()
        {
            //Variables technologies
            string[] arrTechnologies = { "Cobol", "Java", "C#", "Pega", "C++" };
            string[] arrLanguage = { "English", "Spanish" };

            //Log In
            objSearch = new LinkedIn_SearchPage(driver);
            Login_LinkedIn();

            //Captcha
            if (driver.Title.Contains("Verification"))
            {
                driver.SwitchTo().DefaultContent();
                driver.SwitchTo().Frame(driver.FindElement(By.Id("captcha-internal")));
                IWebElement objCheckbox;
                List<IWebElement> frames = new List<IWebElement>(driver.FindElements(By.TagName("iframe")));
                for (int i = 0; i < frames.Count - 1; i++)
                {
                    if (frames[i].GetAttribute("role").ToString() == "presentation" | frames[i].GetAttribute("role").ToString() != "")
                    {
                        driver.SwitchTo().Frame(i);
                        _DriverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 120));
                        objCheckbox = _DriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@role='checkbox']")));
                        if (objCheckbox.Enabled) { objCheckbox.Click(); }

                    }
                }
            }
            // Set Filters
            _DriverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            objSearch = new LinkedIn_SearchPage(driver);

            _DriverWait.Until(driver => driver.FindElement(By.XPath("//div[@class='search-global-typeahead__controls']")));
            LinkedIn_SearchPage.FnEnterSearchText("Jesus");

            _DriverWait.Until(driver => driver.FindElement(By.XPath("//div[@class='search-global-typeahead__controls']")));
            LinkedIn_SearchPage.FnClickSearchBtn();

            _DriverWait.Until(driver => driver.FindElement(By.XPath("//button[span[text()='All Filters']]")));
            LinkedIn_SearchPage.FnSelectAllFilters();

            _DriverWait.Until(driver => driver.FindElement(By.XPath("//label[text()='Mexico' or text()='Mexico']")));
            LinkedIn_SearchPage.FnGetRegionMx();

            _DriverWait.Until(driver => driver.FindElement(By.XPath("//label[text()='Spain' or text()='España']")));
            LinkedIn_SearchPage.FnGetRegionSP();

            _DriverWait.Until(driver => driver.FindElement(By.XPath("//label[text()='English' or text()='Ingles']")));
            LinkedIn_SearchPage.FnLanguageEng();

            _DriverWait.Until(driver => driver.FindElement(By.XPath("//label[text()='Spanish' or text()='Español']")));
            LinkedIn_SearchPage.FnLanguageEsp();

            _DriverWait.Until(driver => driver.FindElement(By.XPath("//button[@data-control-name='all_filters_apply']")));
            LinkedIn_SearchPage.FnClickApplyBtn();

            //Elements
            foreach (string strtech in arrTechnologies)
            {
                _DriverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
                objSearch = new LinkedIn_SearchPage(driver);

                _DriverWait.Until(driver => driver.FindElement(By.XPath("//input[@placeholder='Search']")));
                LinkedIn_SearchPage.fnSearchTechnologies(strtech);


            }


            _DriverWait.Until(driver => driver.FindElement(By.XPath("//span[text()='People']")));
            LinkedIn_SearchPage.FnSelectPeople();

            Console.WriteLine("************");

            _DriverWait.Until(driver => driver.FindElement(By.XPath("(//span[@class='name actor-name'])[1]")));
            Console.WriteLine("Name: " + LinkedIn_SearchPage.GetNameSpan().Text);

            _DriverWait.Until(driver => driver.FindElement(By.XPath("(//p[@class='subline-level-1 t-14 t-black t-normal search-result__truncate']//span[@dir='ltr'])[1]")));
            Console.WriteLine("Role: " + LinkedIn_SearchPage.GetRoleSpan().Text);

            _DriverWait.Until(driver => driver.FindElement(By.XPath("(//a[@class='search-result__result-link ember-view'])[1]")));
            Console.WriteLine("LinkedIn URL: " + LinkedIn_SearchPage.GetUrlA().GetAttribute("href"));

            _DriverWait.Until(driver => driver.FindElement(By.XPath("(//span[@class='name actor-name'])[2]")));
            Console.WriteLine("Name: " + LinkedIn_SearchPage.GetNameSpan().Text);

            _DriverWait.Until(driver => driver.FindElement(By.XPath("(//p[@class='subline-level-1 t-14 t-black t-normal search-result__truncate']//span[@dir='ltr'])[2]")));
            Console.WriteLine("Role: " + LinkedIn_SearchPage.GetRoleSpan().Text);

            _DriverWait.Until(driver => driver.FindElement(By.XPath("(//a[@class='search-result__result-link ember-view'])[2]")));
            Console.WriteLine("LinkedIn URL: " + LinkedIn_SearchPage.GetUrlA().GetAttribute("href"));


        }
    }
}