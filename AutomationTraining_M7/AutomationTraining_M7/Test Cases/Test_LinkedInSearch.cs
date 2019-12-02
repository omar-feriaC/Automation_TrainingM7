using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using System.Configuration;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_LinkedInSearch:BaseTest
    {
        LinkedIn_LoginPageTziu pgLogin;
        LinkedIn_SearchPage pgSearch;
        WebDriverWait wait;
        [Test]
        public void LinkedIn_Login()
        {
            try
            {
                Console.WriteLine("Test start");
                pgLogin = new LinkedIn_LoginPageTziu(driver);
                Assert.IsTrue(driver.Title.Contains("Login"), "Titles do not match");
                pgLogin.fnEnterUserName(ConfigurationManager.AppSettings.Get("username"));
                pgLogin.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
                pgLogin.fnClickSignInButton();
                wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
                wait.Until(condition => driver.Title.Equals("LinkedIn")); //Wait until Captcha is finished by the user and main page loads for 1 minute.
                Assert.AreEqual("LinkedIn", driver.Title);

                /*Perform search page actions*/
                pgSearch = new LinkedIn_SearchPage(driver); //New instance of a search page
                pgSearch.fnEnterSearchText("Anything"); //Search "Anything"
                pgSearch.fnClickSearchButton(); //Click search button
                Assert.AreEqual("\"anything\" | Search | LinkedIn", driver.Title); //Validate the search was performed

                pgSearch.fnClickPeopleButton(); //Click the people button
                Assert.AreEqual("https://www.linkedin.com/search/results/people/?keywords=anything&origin=SWITCH_SEARCH_VERTICAL", driver.Url); //Validate "people" URLs match
                pgSearch.fnClickPeopleFilterButton(); //Click the people filter
                pgSearch.fnSelectDropDownOption(0); //Select the first filter
                Assert.AreEqual("https://www.linkedin.com/search/results/all/?keywords=anything&origin=SWITCH_SEARCH_VERTICAL", driver.Url); //Validate all" URLs match


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
