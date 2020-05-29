using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AventStack.ExtentReports;
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
    class Test_PHPTravels : BaseTest
    {
        [Test]
        public void Test_M9Exercise()
        {
            //Init objects
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            //Login Action
            Assert.IsTrue(driver.Title.Contains("Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail(ConfigurationManager.AppSettings.Get("email"));
            clsPHPTravels_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, driver.Title.Contains("Dash"), "The Dashboard was not loaded correctly.");
            // Print Values
            Console.WriteLine(clsPHPTravels_LoginPage.GetAdminLbl().Text);
            Console.WriteLine(clsPHPTravels_LoginPage.GetSupplierLbl().Text);
            Console.WriteLine(clsPHPTravels_LoginPage.GetCustomerLbl().Text);
            Console.WriteLine(clsPHPTravels_LoginPage.GetGuestLbl().Text);
            Console.WriteLine(clsPHPTravels_LoginPage.GetBookingLbl().Text);
            //Add counts comments in report
            objTest.Log(Status.Info, (clsPHPTravels_LoginPage.GetAdminLbl().Text));
            objTest.Log(Status.Info, (clsPHPTravels_LoginPage.GetSupplierLbl().Text));
            objTest.Log(Status.Info, (clsPHPTravels_LoginPage.GetCustomerLbl().Text));
            objTest.Log(Status.Info, (clsPHPTravels_LoginPage.GetGuestLbl().Text));
            objTest.Log(Status.Info, (clsPHPTravels_LoginPage.GetBookingLbl().Text));
            // Display side menu and side sub menus content with sorting validation
            clsPHPTravels_AdminPage.fnSelectMenuItem("Accounts", "Admins");
            Thread.Sleep(TimeSpan.FromSeconds(10));
            objRM.fnAddLogStepScreen(objTest, driver, "Accounts", "Accounts.png", "Pass");
            clsPHPTravels_AdminPage.fnClickFistNameSort();
            Thread.Sleep(TimeSpan.FromSeconds(20));
            objRM.fnAddLogStepScreen(objTest, driver, "AdminsFirstName", "AdminsFirstName.png", "Pass");
            clsPHPTravels_AdminPage.fnClickLastNameSort();
            Thread.Sleep(TimeSpan.FromSeconds(20));
            objRM.fnAddLogStepScreen(objTest, driver, "AdminsLastName", "AdminsLastName.png", "Pass");
            clsPHPTravels_AdminPage.fnClickEmail();
            Thread.Sleep(TimeSpan.FromSeconds(20));
            objRM.fnAddLogStepScreen(objTest, driver, "AdminsEmail", "AdminsEmail.png", "Pass");
            clsPHPTravels_AdminPage.fnClickActive();
            Thread.Sleep(TimeSpan.FromSeconds(20));
            objRM.fnAddLogStepScreen(objTest, driver, "AdminsActive", "AdminsActive.png", "Pass");
            clsPHPTravels_AdminPage.fnClickLastLogin();
            Thread.Sleep(TimeSpan.FromSeconds(20));
            objRM.fnAddLogStepScreen(objTest, driver, "AdminsLastLogin", "AdminsLastLogin.png", "Pass");
        }
    }
}
