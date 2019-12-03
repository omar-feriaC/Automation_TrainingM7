using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_LinkedInSearch:Test_LinkedIn_Login
    {
        LinkedIn_LoginPageTziu pgLogin;
        LinkedIn_SearchPage pgSearch;
        WebDriverWait wait;
        [Test]
        public void LinkedIn_Search()
        {
            try
            {
                Console.WriteLine("Test start");
                pgLogin = new LinkedIn_LoginPageTziu(driver);
                Assert.IsTrue(driver.Title.Contains("Login"), "Titles do not match");
                LinkedIn_Login();
                wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
                wait.Until(condition => driver.Url.Equals("https://www.linkedin.com/feed/")); //Wait until Captcha is finished by the user and main page loads for 1 minute.
                Assert.AreEqual("https://www.linkedin.com/feed/", driver.Url);

                /*Perform search page actions*/
                pgSearch = new LinkedIn_SearchPage(driver); //New instance of a search page
                pgSearch.fnEnterSearchText("Anything"); //Search "Anything"
                pgSearch.fnClickSearchButton(); //Click search button

                wait.Until(condition => pgSearch.GetPeopleButton());//Wait for the People button to load
                pgSearch.fnClickPeopleButton(); //Click the people button
                wait.Until(condition => driver.Url.Contains("search/results/people/?keywords"));
                Assert.AreEqual("https://www.linkedin.com/search/results/people/?keywords=Anything&origin=SWITCH_SEARCH_VERTICAL", driver.Url); //Validate "people" URLs match

                wait.Until(condition => pgSearch.GetPeopleFilterButton());//Wait for the People Drop Down to load
                pgSearch.fnClickPeopleFilterButton(); //Click the people filter

                wait.Until(condition => pgSearch.GetPeopleFilterIndexContent(0).Displayed);//Wait for content to be selectable
                pgSearch.fnSelectDropDownOption(0); //Select the first filter
                wait.Until(condition => driver.Url.Contains("search/results/all/?keywords"));
                Assert.AreEqual("https://www.linkedin.com/search/results/all/?keywords=Anything&origin=SWITCH_SEARCH_VERTICAL", driver.Url); //Validate "all" URLs match


            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            finally
            {

            }
        }
    }
}
