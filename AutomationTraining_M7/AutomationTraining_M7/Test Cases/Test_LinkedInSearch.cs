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

        [Test]
        public void Search_LinkedIn()
        {
            //VARIABLES
         //   string[] arrTechnologies = { "Java", "C#", "C++", "Pega", "Cobol" };
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
                        _driverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
                        objCheckbox = _driverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@role='checkbox']")));
                        if (objCheckbox.Enabled) { objCheckbox.Click(); }
                        
                    }
                }
            }

            //Step# 3 .- Set Filters
            LinkedIn_SearchPage.fnEnterSearchText("");
            LinkedIn_SearchPage.fnClickSearchBtn();
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//button[span[text()='People' or text()='Gente']]")));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='People' or text()='Gente']]")));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[span[text()='People' or text()='Gente']]")));
            LinkedIn_SearchPage.fnSelectPeople();
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnSelectAllFilters();
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnAddCountry("Mexico");
            //LinkedIn_SearchPage.fnGetRegionMx();
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnSelectMexico();
            Thread.Sleep(5000);
            LinkedIn_SearchPage.fnLanguageEng();
            Thread.Sleep(5000);
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
