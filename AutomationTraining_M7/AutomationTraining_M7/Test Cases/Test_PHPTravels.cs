using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AutomationTraining_M7.Reporting;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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


        [Test]
        public void Test_M9Exercise()
        {
            try
            {
                //Init objects
                objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
                objPHP = new clsPHPTravels_LoginPage(driver);
                
                //Login Action
                Assert.AreEqual(true, driver.Title.Contains("Administator Login"), "Login Page not loaded correctly.");
                clsPHPTravels_LoginPage.fnEnterEmail("admin@phptravels.com");
                clsPHPTravels_LoginPage.fnEnterPassword("demoadmin");
                clsPHPTravels_LoginPage.fnClickLoginButton();
                clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
                Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");
                
                //Locate and Print the stats of the page from the upper banner.
                clsPHPTravels_LoginPage.fnPrintStats();
                objRM.fnAddStepLogScreen(objTest, driver, "Login done", "Logged.png", "Pass");
                clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
                Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "Home page not loaded correctly.");
                objRM.fnAddStepLogScreen(objTest, driver, "Stats", "stats.png", "Pass");
                
                //Display the Side Menu and Sub Menues content and validate the sorting
                clsPHPTravels_LoginPage.fnSideMenuBtn("Accounts".Trim());
                Console.WriteLine("");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error in: \n" + ex.GetBaseException());
                Assert.Fail();
            }
        }

    }
}
