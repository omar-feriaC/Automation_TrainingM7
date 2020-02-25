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
        //LinkedIn_LoginPage objLogin; -- DELETE
        public WebDriverWait _driverWait;
        LinkedIn_SearchPage objSearch;
        clsDriver cls;

        [Test]
        public void Search_LinkedIn()
        {
            //VARIABLES
         //   string[] arrTechnologies = { "Java", "C#", "C++", "Pega", "Cobol" };
            string[] arrLanguages = { "English" };

            //Step# 1 .- Log In 
            objSearch = new LinkedIn_SearchPage(driver);
            cls = new clsDriver(driver);
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

            LinkedIn_SearchPage.fnEnterSearchText("");
            LinkedIn_SearchPage.fnClickSearchBtn();

            string XPATH_PEOPLE = "//button[span[text()='People' or text()='Gente']]";
            cls.fnWaitForElementToExist(By.XPath(XPATH_PEOPLE));
            cls.fnWaitForElementToBeVisible(By.XPath(XPATH_PEOPLE));
            cls.fnWaitForElementToBeClickable(By.XPath(XPATH_PEOPLE));
            LinkedIn_SearchPage.fnSelectPeople();

            string XPATH_ALLFILTERS = "//button[span[text()='All Filters' or text()='Todos los filtros']]";
            cls.fnWaitForElementToExist(By.XPath(XPATH_ALLFILTERS));
            cls.fnWaitForElementToBeVisible(By.XPath(XPATH_ALLFILTERS));
            cls.fnWaitForElementToBeClickable(By.XPath(XPATH_ALLFILTERS));
            LinkedIn_SearchPage.fnSelectAllFilters();

            string XPATH_SELECTCOUNTRY = "//input[@placeholder='Add a country/region'][@aria-label='Add a country/region']";
            cls.fnWaitForElementToExist(By.XPath(XPATH_SELECTCOUNTRY));
            cls.fnWaitForElementToBeVisible(By.XPath(XPATH_SELECTCOUNTRY));
            LinkedIn_SearchPage.fnAddCountry("Mexico");

            string XPATH_COUNTRY = "//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Mexico' or 'México']";
            cls.fnWaitForElementToExist(By.XPath(XPATH_COUNTRY));
            cls.fnWaitForElementToBeVisible(By.XPath(XPATH_COUNTRY));
            cls.fnWaitForElementToBeClickable(By.XPath(XPATH_COUNTRY));
            LinkedIn_SearchPage.fnSelectMexico();

            string XPATH_LANGUAGE = "//label[text()='English' or text()='Ingles']";
            cls.fnWaitForElementToExist(By.XPath(XPATH_LANGUAGE));
            cls.fnWaitForElementToBeVisible(By.XPath(XPATH_LANGUAGE));
            cls.fnWaitForElementToBeClickable(By.XPath(XPATH_LANGUAGE));
            LinkedIn_SearchPage.fnLanguageEng();

            string XPATH_APPLYBUTTON = "//button[@data-control-name='all_filters_apply']";
            cls.fnWaitForElementToExist(By.XPath(XPATH_APPLYBUTTON));
            cls.fnWaitForElementToBeVisible(By.XPath(XPATH_APPLYBUTTON));
            cls.fnWaitForElementToBeClickable(By.XPath(XPATH_APPLYBUTTON));
            LinkedIn_SearchPage.fnClickApplyBtn();

            //Step# 4 .- Search Elements
            /*           foreach (string strvalue in arrTechnologies)
                       {
                           LinkedIn_SearchPage.fnEnterSearchText(strvalue);
                           LinkedIn_SearchPage.fnClickSearchBtn();
                       }
                       */

        }
    }
}
