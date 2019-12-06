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
using System.Web.UI.WebControls;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_LinkedInSearch : Test_LinkedIn
    {
        //LinkedIn_LoginPage objLogin; -- DELETE
        WebDriverWait wait;
        LinkedIn_SearchPage objSearch;
      
        [Test]
        public void Search_LinkedIn()
        {
            //VARIABLES
            string[] arrTechnologies = { "Java", "C#", "C++", "Pega", "Cobol" };
            string[] arrLanguages = { "Spanish", "English" };
            

            //Step# 1 .- Log In 
            driver.Manage().Window.Maximize();
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

            //First search
            objSearch = new LinkedIn_SearchPage(driver);
            LinkedIn_SearchPage.fnEnterSearchText("Testing");
            LinkedIn_SearchPage.fnClickSearchBtn();
            wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='People' or text()='Gente']]")));

            //Selecting People button
            LinkedIn_SearchPage.fnSelectPeople();
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@class='search-vertical-filter__dropdown-trigger-text mr1'][text()='People']")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='All Filters' or text()='Todos los filtros']]")));

            //Locations selection
            LinkedIn_SearchPage.fnSelectAllFilters();
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@placeholder='Add a country/region'][@aria-label='Add a country/region']")));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//label[text()='Mexico' or text()='México']")));
            LinkedIn_SearchPage.fnGetRegionMx();
            LinkedIn_SearchPage.fnAddCountry("Italy");
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@class='basic-typeahead__triggered-content search-s-add-facet__typeahead-tray']")));
            wait.Until(ExpectedConditions.TextToBePresentInElement(LinkedIn_SearchPage.GetItalyDropDown(), "Italy"));
            LinkedIn_SearchPage.fnSelectItaly();

            //Entering Languages
            foreach(string language in arrLanguages) 
            {
                LinkedIn_SearchPage.fnSelectLanguage(language);
            }

            //Apply the Filters
            LinkedIn_SearchPage.fnClickApplyBtn();

            //Search for Technologies

            IList<IWebElement> ElementsCount = driver.FindElements(By.XPath("//span[@class='actor-name']"));

            

            foreach (string Tech in arrTechnologies)
            {
                LinkedIn_SearchPage.fnEnterSearchText(Tech);
                LinkedIn_SearchPage.fnClickSearchBtn();
                wait.Until(ExpectedConditions.ElementExists(By.XPath("//p[@class='subline-level-1 t-14 t-black t-normal search-result__truncate']")));
                LinkedIn_SearchPage.fnTechnology();
                
            }






        }
    }
}
