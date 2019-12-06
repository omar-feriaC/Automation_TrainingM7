using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
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

            objSearch = new LinkedIn_SearchPage(driver);

            //*****Step 3*****//
            LinkedIn_SearchPage.fnEnterSearchText(ConfigurationManager.AppSettings.Get("PersonSearch"));


            //usar wait for an element
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            



            



            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='People' or text()='Gente']]")));
            
            //*****Step 4*****//
            LinkedIn_SearchPage.fnSelectPeople();

            wait.Until(ExpectedConditions.UrlContains("people"));
            //*****Step 5*****//
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='All Filters' or text()='Todos los filtros']]")));
            LinkedIn_SearchPage.fnSelectAllFilters();


            
            //MEXICO//
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//label[text()='Mexico' or text()='México']")));
            
            LinkedIn_SearchPage.fnGetRegionMx();

            //ITALIA//
            
            LinkedIn_SearchPage.fnSearchItaly(ConfigurationManager.AppSettings.Get("ItalySearch"));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Italy' or text()='Italia']")));
            LinkedIn_SearchPage.fnSelectItaly();


            
            
            LinkedIn_SearchPage.fnLanguageEng();
            LinkedIn_SearchPage.fnLanguageEsp();
            LinkedIn_SearchPage.fnClickApplyBtn();

            
            foreach (string strSearchTech in arrTechnologies)
            {
                LinkedIn_SearchPage.fnSearchTech(strSearchTech);
                wait.Until(ExpectedConditions.UrlContains("search/results/"));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[@class='actor-name']\"[0]")));
                string strName = driver.FindElement(By.XPath("//span[@class ='actor-name'][0]")).Text;
                string strJob = driver.FindElement(By.XPath("//span[@dir='ltr'][0]")).Text;
                string strUrl = driver.FindElement(By.XPath("//a[@data-control-name='search_srp_result']/@href[1]")).Text;
                Console.WriteLine("Name= " + strName);
                Console.WriteLine("Job= "+ strJob);
                Console.WriteLine("LinkedIn URL= "+ strUrl);
            }
            

            


            
            

        }
    }
}

