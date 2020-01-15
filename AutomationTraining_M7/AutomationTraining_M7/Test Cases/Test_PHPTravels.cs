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

        private string email = ConfigurationManager.AppSettings.Get("email");
        private string password = ConfigurationManager.AppSettings.Get("password");

        [Test]
        public void Test_M9Exercise()
        {
            try
            {
                //Init objects

                exTestStep = exTestCase.CreateNode("Login", "Login to PHP Webpage");

                objPHP = new clsPHPTravels_LoginPage(driver);

                //Login Action
                Assert.AreEqual(true, driver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
                objPHP.fnEnterEmail(email);

                exTestStep.Log(AventStack.ExtentReports.Status.Info, $"Username: {email}");

                objPHP.fnEnterPassword(password);
                objPHP.fnClickLoginButton();   

                objPHP.fnWaitHamburgerMenu();
                Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

                strScreenshotPath = manager.fnCaptureImage(driver);
                exTestStep.Log(AventStack.ExtentReports.Status.Info, "User logged", MediaEntityBuilder.CreateScreenCaptureFromPath(strScreenshotPath).Build());
                exTestStep.Pass("User has logged succesfully");

                //Print Dashboard

                exTestStep = exTestCase.CreateNode("Dashboard Stats", "Numbers displayed in the table.");

                objPHP.fnWaitDashboardStats();  
                foreach (IWebElement i in objPHP.GetDashboardTotals())
                {
                    Console.WriteLine(i.Text);
                    exTestStep.Log(AventStack.ExtentReports.Status.Info, $"Dashboard: {i.Text}");
                }

                strScreenshotPath = manager.fnCaptureImage(driver);
                exTestStep.Log(AventStack.ExtentReports.Status.Info, "Dashboard Info displayed", MediaEntityBuilder.CreateScreenCaptureFromPath(strScreenshotPath).Build());
                exTestStep.Pass("Dasboard info displayed correctly");

                exTestStep = exTestCase.CreateNode("Sorting of Columns", "Validation of the available columns in the Submenus.");

                objPHP.fnMenuSelection();

                objPHP.GetMenu().Click();
                objPHP.fnWaitSubMenus();
                objPHP.GetSubMenus().ElementAt(1).Click();
                objPHP.GetMenu().Click();
                objPHP.fnWaitSubMenus();
                foreach (IWebElement i in objPHP.GetSubMenus())
                {
                    exTestStep.Log(AventStack.ExtentReports.Status.Info, $"Submenu validated: {i.Text}");

                    foreach(IWebElement j in objPHP.GetColumns())
                    {
                        exTestStep.Log(AventStack.ExtentReports.Status.Info, $"Column validated: {i.Text} -> {j.Text}");
                    }
                }

                strScreenshotPath = manager.fnCaptureImage(driver);
                exTestStep.Log(AventStack.ExtentReports.Status.Info, "Columns sorted", MediaEntityBuilder.CreateScreenCaptureFromPath(strScreenshotPath).Build());            
                exTestStep.Pass("Columns sorted correctly.");
            }
            catch(Exception ex)
            {
                strScreenshotPath = manager.fnCaptureImage(driver);
                exTestStep.Log(AventStack.ExtentReports.Status.Error, "Step has failed", MediaEntityBuilder.CreateScreenCaptureFromPath(strScreenshotPath).Build());
                Console.WriteLine(ex.Message);
                Console.WriteLine("Test case failed.");
                exTestCase.Fail($"Test case failed with error: {ex.Message}");
                Assert.Fail();
            }    
        }
    }
}
