using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AventStack.ExtentReports;
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

namespace AutomationTraining_M7.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {
        clsPHPTravels_LoginPage objPHP1;
        [Test]
        public void Test_M9Exercise()
        {
            //Init objects
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            objPHP1 = new clsPHPTravels_LoginPage(driver);
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
            clsPHPTravels_AdminPage.fnSortFirstName();
            clsPHPTravels_AdminPage.fnSortLastName();
            clsPHPTravels_AdminPage.fnSortEmail();
            clsPHPTravels_AdminPage.fnSortActive();
            clsPHPTravels_AdminPage.fnSortLastLogin();
            objRM.fnAddLogStepScreen(objTest, driver, "Accounts", "Admins.png", "Pass");
            clsPHPTravels_AdminPage.fnSelectMenuItem("Accounts", "Suppliers");
            clsPHPTravels_AdminPage.fnSortFirstName();
            clsPHPTravels_AdminPage.fnSortLastName();
            clsPHPTravels_AdminPage.fnSortEmail();
            clsPHPTravels_AdminPage.fnSortActive();
            clsPHPTravels_AdminPage.fnSortLastLogin();
            objRM.fnAddLogStepScreen(objTest, driver, "Suppliers", "Suppliers.png", "Pass");
            objRM.fnAddLogStepScreen(objTest, driver, "AdminsFirstName", "AdminsFirstName.png", "Pass");
            clsPHPTravels_AdminPage.fnSelectMenuItem("Accounts", "Customers");
            clsPHPTravels_AdminPage.fnSortFirstName();
            clsPHPTravels_AdminPage.fnSortLastName();
            clsPHPTravels_AdminPage.fnSortEmail();
            clsPHPTravels_AdminPage.fnSortActive();
            clsPHPTravels_AdminPage.fnSortLastLogin();
            objRM.fnAddLogStepScreen(objTest, driver, "Customers", "Customers.png", "Pass");
            objRM.fnAddLogStepScreen(objTest, driver, "AdminsFirstName", "AdminsFirstName.png", "Pass");
            clsPHPTravels_AdminPage.fnSelectMenuItem("Accounts", "GuestCustomers");
            clsPHPTravels_AdminPage.fnSortFirstName();
            clsPHPTravels_AdminPage.fnSortLastName();
            clsPHPTravels_AdminPage.fnSortEmail();
            clsPHPTravels_AdminPage.fnSortActive();
            clsPHPTravels_AdminPage.fnSortLastLogin();
            objRM.fnAddLogStepScreen(objTest, driver, "GuestCustomers", "GuestCustomers.png", "Pass");
            objRM.fnAddLogStepScreen(objTest, driver, "AdminsGuestCustomers", "AdminsGuestCustomers.png", "Pass");
        }
    }
}
