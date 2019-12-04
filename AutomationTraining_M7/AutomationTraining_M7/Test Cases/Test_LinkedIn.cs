using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_LinkedIn : BaseTest
    {
        LinkedIn_LoginPage objLogin;


        [Test]
        public void Login_LinkedIn()
        {
            objLogin = new LinkedIn_LoginPage(driver);

            //Verifying the Log in page opened
            Assert.AreEqual(true, driver.Title.Contains("Login"), "Login page was not displayed");

            LinkedIn_LoginPage.fnEnterUserName(ConfigurationManager.AppSettings.Get("username"));
           
            LinkedIn_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            
            LinkedIn_LoginPage.fnClickSignInButton();

            //Verifying the Log in was successful by checking if the feed page opened
            Assert.AreEqual("https://www.linkedin.com/feed/", driver.Url);

        }

    }


       
}
