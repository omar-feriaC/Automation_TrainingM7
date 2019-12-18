using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {
       clsPHPTravels_LoginPage objPHP;
        

        [Test]
        public void Test_M9Exercise()
        {

            //Init objects
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name); objPHP = new clsPHPTravels_LoginPage(driver);
            objPHP = new clsPHPTravels_LoginPage(driver);

            //Login Action
            Assert.AreEqual(true, driver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail(ConfigurationManager.AppSettings.Get("email"));
            clsPHPTravels_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            //Printing the Total Links info in Console and adding them to the Extent Report
            IList<IWebElement> ElementList = driver.FindElements(By.XPath("//ul[@class='serverHeader__statsList']//child::a"));
            foreach (IWebElement el in ElementList)
             {

                    Console.WriteLine(el.Text);

                    objTest.Log(Status.Info, el.Text);

             }
            
        }

    }
}
