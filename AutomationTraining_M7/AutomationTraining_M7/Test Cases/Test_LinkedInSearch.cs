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
using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Data_Model;


namespace AutomationTraining_M7.Test_Cases
{
    class Test_LinkedInSearch : Test_LinkedIn
    {
        //LinkedIn_LoginPage objLogin; -- DELETE
        public WebDriverWait wait;
        LinkedIn_SearchPage objSearch;

        [Test]
        public void Search_LinkedIn()
        {
            //VARIABLES
            string[] arrLines = System.IO.File.ReadAllLines(@"C: \Users\hector.castillo.AT\Desktop\technologies.txt");
            //string[] arrLanguages = { "English" };

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
                        wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
                        objCheckbox = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@role='checkbox']")));
                        if (objCheckbox.Enabled) { objCheckbox.Click(); }
                        
                    }
                }
            }

            //Step# 3 .- Set Filters
            for (int i = 0; i < arrLines.Length; i++)
            {


                objSearch = new LinkedIn_SearchPage(driver);
                LinkedIn_SearchPage.fnEnterSearchText(arrLines[i]);
                LinkedIn_SearchPage.fnClickSearchBtn();
                ExportDataCsv file = new ExportDataCsv(arrLines[i]);
                wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='People' or text()='Gente']]")));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[span[text()='People' or text()='Gente']]")));

                //Step# 4 .- Selecting People button
                try
                {
                    LinkedIn_SearchPage.fnSelectPeople();
                }
                catch(StaleElementReferenceException)
                {
                    wait.Until(ExpectedConditions.StalenessOf(LinkedIn_SearchPage.GetPeopleCB()));
                    LinkedIn_SearchPage.fnSelectPeople();
                }
                wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@class='search-vertical-filter__dropdown-trigger-text mr1'][text()='People' or text()='Gente']")));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='All Filters' or text()='Todos los filtros']]")));

                //Step# 5 .- Locations selection
                LinkedIn_SearchPage.fnSelectAllFilters();
                wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@placeholder='Add a country/region' or @placeholder='Añadir un país o región'][@aria-label='Add a country/region' or @aria-label='Añadir un país o región']")));
                LinkedIn_SearchPage.fnAddCountry("Mexico");
                wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Mexico' or 'México']")));
                LinkedIn_SearchPage.fnLanguageEng();
                //foreach (string language in arrLanguages)
                //{
                //    LinkedIn_SearchPage.fnSelectLanguage(language);
                //}

                //Step# 7 .- Apply the Filters
                LinkedIn_SearchPage.fnClickApplyBtn();

               



                IList<IWebElement> allSearchResults = LinkedIn_SearchPage.fnAllResultPage();
                Thread.Sleep(5000);

                for(int b=0; b< allSearchResults.Count; b++)
                {

                    Thread.Sleep(5000);
                    //string listXpath = $"//span[@class='actor-name'][{b+2}]";
                    string listXpath = $"(//span[@class='actor-name' or @class='name actor-name'])[{b + 1}]";

                    Console.WriteLine("XPATH is: " + listXpath);
                    string STR_TOTAL_RESULTS_WO = listXpath;
                    //wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_TOTAL_RESULTS_WO)));
                    IWebElement objSearchResult = driver.FindElement(By.XPath(listXpath));
                    objSearchResult.Click();
                    //int c = b + 1;
                    //Console.WriteLine(allSearchResults[c]);
                    ////allSearchResults[b].Click();
                    ////Console.WriteLine(allSearchResults.ElementAt(c).Text);
                    //Console.WriteLine(allSearchResults[c].Text);
                    //try
                    //{
                    //    allSearchResults.ElementAt(c).Click();
                    //}
                    //catch (StaleElementReferenceException)
                    //{
                    //    wait.Until(ExpectedConditions.StalenessOf(allSearchResults[c]));
                    //    allSearchResults.ElementAt(c).Click();
                    //}
                    Thread.Sleep(5000);
                    driver.Navigate().Back();

                    //Export ifno to CSV file
                    //CODE TO  GET CANDIDATE DATA
                    file.Member.Add(new Candidates
                    {
                        ActorName = "hector test",
                        ProfileRole = "testststs",
                        LinkedInUrl = "tsetset.com",
                        LastJob = "test1",
                        ExperienceRole = "test01",
                        ExperienceCompany = "test02",
                        ExperiencePeriod = "test03",
                        SkillsValidations = "test04",
                        ToolsTechnologies = "test05"
                    });
                }

                file.fnCreateFile();

                LinkedIn_SearchPage.fnClearFilters();
               
            
                
            }

            

        }
    }
}
