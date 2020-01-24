using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AutomationTraining_M7.Reporting;
using AventStack.ExtentReports;
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
    class Test_PHPTravels : BaseTest
    {
        clsPHPTravels_LoginPage objPHP;
        string strScreenshotPath;
        


        [Test]
        public void Test_M9Exercise()
        {
            
            
                //Init objects
                exTestStep = exTestCase.CreateNode("Login", "PHP Travels");
                objPHP = new clsPHPTravels_LoginPage(driver);
                //Login Action
                Assert.AreEqual(true, driver.Title.Contains("Administator Login"), "The Login Page didn't load");
            clsPHPTravels_LoginPage.fnEnterEmail(ConfigurationManager.AppSettings.Get("email"));
            clsPHPTravels_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            strScreenshotPath = manager.fnCaptureImage(driver);
            exTestStep.Log(AventStack.ExtentReports.Status.Info, "User logged in", MediaEntityBuilder.CreateScreenCaptureFromPath(strScreenshotPath).Build());
            exTestStep.Pass("Login Pass");

            Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            //Total Links
            IList<IWebElement> ElementList = driver.FindElements(By.XPath("//ul[@class='serverHeader__statsList']//child::a"));
            foreach (IWebElement elementl in ElementList)
            {
                Console.WriteLine(elementl.Text);
                exTestStep.Log(Status.Info, elementl.Text);
            }
            strScreenshotPath = manager.fnCaptureImage(driver);
            exTestStep.Log(AventStack.ExtentReports.Status.Info, "Dashboard Info displayed", MediaEntityBuilder.CreateScreenCaptureFromPath(strScreenshotPath).Build());
            exTestStep.Pass("Dasboard info displayed correctly");

            clsPHPTravels_LoginPage.fnGetMenuSubmenu("Accounts");
            strScreenshotPath = manager.fnCaptureImage(driver);
            exTestStep.Log(AventStack.ExtentReports.Status.Info, "Menu Sorted", MediaEntityBuilder.CreateScreenCaptureFromPath(strScreenshotPath).Build());
            exTestStep.Pass("Menu Sorted");


        }

    }
}
