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
                        _DriverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
                        objCheckbox = _DriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@role='checkbox']")));
                        if (objCheckbox.Enabled) { objCheckbox.Click(); }

                    }
                }
            }
            // Set Filters
            LinkedIn_SearchPage.FnEnterSearchText("Jesus");
            Thread.Sleep(6000);
            LinkedIn_SearchPage.FnClickSearchBtn();
            Thread.Sleep(6000);
            LinkedIn_SearchPage.FnSelectAllFilters();
            LinkedIn_SearchPage.FnGetRegionMx();
            LinkedIn_SearchPage.FnLanguageEng();
            LinkedIn_SearchPage.FnLanguageEsp();
            LinkedIn_SearchPage.FnClickApplyBtn();

            //Elements
            foreach (string strValue in arrTechnologies)
            {
                LinkedIn_SearchPage.FnEnterSearchText(strValue);
                LinkedIn_SearchPage.FnClickSearchBtn();
            }
        }
    }
}
