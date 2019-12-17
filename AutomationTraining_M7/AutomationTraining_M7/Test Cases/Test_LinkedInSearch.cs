using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AutomationTraining_M7.Reporting;
using AventStack.ExtentReports;
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
    class Test_SearchLinkedIn : Test_LinkedIn 
    {
        
           public WebDriverWait _driverWait;
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
                           _driverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
                           objCheckbox = _driverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@role='checkbox']")));
                           if (objCheckbox.Enabled) { objCheckbox.Click(); }

                       }
                   }
               }
           // objTest.Log(Status.Info, "Captcha verified");

            objSearch = new LinkedIn_SearchPage(driver);


            LinkedIn_SearchPage.fnEnterSearchText(ConfigurationManager.AppSettings.Get("search1"));
             LinkedIn_SearchPage.fnClickSearchButton();
            _driverWait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='People' or text()='Gente']")));

             LinkedIn_SearchPage.fnClickPeopleBtn();
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@class='search-vertical-filter__dropdown-trigger-text mr1'][text()='People']")));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='All Filters' or text()='Todos los filtros']]")));

             LinkedIn_SearchPage.fnClickAllFiltersBtn();
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@placeholder='Add a country/region'][@aria-label='Add a country/region']")));

             //Region Mexico
             LinkedIn_SearchPage.fnAddRegionMexTxt(ConfigurationManager.AppSettings.Get("regionMMx"));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Mexico']")));
             LinkedIn_SearchPage.fnEnterRegionMexText();
                       
             //Region Italy
             LinkedIn_SearchPage.fnAddRegionItaTxt(ConfigurationManager.AppSettings.Get("regionIta"));
             Thread.Sleep(100);
             _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Italy']")));
           
            LinkedIn_SearchPage.fnEnterRegionMItaText();
            

            //Language array
            foreach (string strLanguage in arrLanguages)
             {
                 LinkedIn_SearchPage.fnClickLanguageCb(strLanguage);
             }

            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//button[@data-control-name='all_filters_apply']")));

            //Technologies array    
            LinkedIn_SearchPage.fnClickApplyBtn();

            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@class='search-results__list list-style-none ']/li//*[@class='actor-name']")));

            foreach (string strTechnologies in arrTechnologies)
            {
                LinkedIn_SearchPage.fnEnterSearchText(strTechnologies);
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@class='search-results__list list-style-none ']/li//*[@class='actor-name']")));
                LinkedIn_SearchPage.fnClickSearchButton();
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//p[@class='subline-level-1 t-14 t-black t-normal search-result__truncate']")));
                LinkedIn_SearchPage.fnGetTechResultsTxt();
            }

            //objTest.Log(Status.Info, "Add a message2");


        }
}

}