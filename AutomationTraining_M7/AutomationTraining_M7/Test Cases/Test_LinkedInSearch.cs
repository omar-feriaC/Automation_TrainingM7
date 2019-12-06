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

            _driverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            objSearch = new LinkedIn_SearchPage(driver);
            //Step# 3 .- Set Filters
            LinkedIn_SearchPage.fnEnterSearchText("Test");
            
            LinkedIn_SearchPage.fnClickSearchBtn();
            _driverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Gente' or text()='People']")));
            LinkedIn_SearchPage.fnSelectPeople();
            
            Task.Delay(3000).Wait();
            LinkedIn_SearchPage.fnSelectAllFilters();
            _driverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//label[text()='Mexico' or text()='México']")));

            LinkedIn_SearchPage.fnGetRegionMx();
            Task.Delay(3000).Wait();

            //Search and click on Italy
            LinkedIn_SearchPage.fnEnterLocationValue("Italy");
            Task.Delay(3000).Wait();

           

            /* LinkedIn_SearchPage.fnLanguageEng();
             Thread.Sleep(5000);
             LinkedIn_SearchPage.fnLanguageEsp();
             Thread.Sleep(5000);*/
            LinkedIn_SearchPage.fnClickApplyBtn();

            //Step# 4 .- Search Elements
            foreach (string strvalue in arrTechnologies)
            {
                
                LinkedIn_SearchPage.fnEnterSearchText(strvalue);
                LinkedIn_SearchPage.fnClickSearchBtn();

                String strName = driver.FindElement(By.XPath("//span[@class = 'actor-name']")).Text;
                Console.WriteLine("Name: " + strName);

                String strTitle = driver.FindElement(By.XPath("//p[@class = 'subline-level-1 t-14 t-black t-normal search-result__truncate']")).Text;
                Console.WriteLine("Role: " + strTitle);
                
                

            }




        }

    }    
}
