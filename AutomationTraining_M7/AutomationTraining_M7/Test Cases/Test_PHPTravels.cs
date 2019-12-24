using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {
        clsPHPTravels_LoginPage objPHP;
        WebDriverWait _driverWait;

        [Test]
        public void Test_M9Exercise()
        {
            //Init objects
            objPHP = new clsPHPTravels_LoginPage(driver);
            _driverWait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            //Login Action
            Assert.AreEqual(true, driver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            objPHP.fnEnterEmail(strEmail);
            objPHP.fnEnterPassword(strPasword);
            objPHP.fnClickLoginButton();
            objPHP.fnWaitHamburgerMenu();
            Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            /*5*/
            objPHP.fnPrintStatList(); //Print the stats list to the console

            /*10 and 11*/
            objPHP.fnSelectMenuItem("Updates");
            objPHP.fnSelectMenuItem("Accounts", "Admins");
            objPHP.fnValidateSorting();
            objPHP.fnSelectMenuItem("Accounts", "Suppliers");
            objPHP.fnValidateSorting();
            objPHP.fnSelectMenuItem("Accounts", "Customers");
            objPHP.fnValidateSorting();
            objPHP.fnSelectMenuItem("Accounts", "GuestCustomers");
            objPHP.fnValidateSorting();
        }

    }
}
