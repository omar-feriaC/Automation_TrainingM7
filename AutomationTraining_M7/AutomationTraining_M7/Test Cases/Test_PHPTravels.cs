using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AventStack.ExtentReports;
using NUnit.Framework;
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
        
        clsPHPTravels_LoginPage objPHP;


        [Test]
        public void Test_M9Exercise()
        {
            //Init objects
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            objPHP = new clsPHPTravels_LoginPage(driver);


            //Login Action
            Assert.IsTrue(driver.Title.Contains("Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail(ConfigurationManager.AppSettings.Get("email"));
            clsPHPTravels_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            Assert.IsTrue(driver.Title.Contains("Dash"), "The Dashboard was not loaded correctly.");

            //Print Total Values

            List<string> strTotVal = clsPHPTravels_LoginPage.fnGetTotalsValuesTxt();
            foreach (var item in strTotVal)
            {
                objRM.fnAddStepLog(objTest, item, "Pass");
            }
            objRM.fnAddStepLogScreen(objTest, driver, "Print Total Values", "scr.png", "Pass");

            // Menu and Submenu

            objPHP.fnSelectMenuItem("Updates");

            objPHP.fnSelectMenuItem("Accounts", "Admins");
            objPHP.fnFNameSorting();
            objRM.fnAddStepLogScreen(objTest, driver, "Admins First Name Column Sort", "Admins_FName_Sort.png", "Pass");

            objPHP.fnLNameSorting();
            objRM.fnAddStepLogScreen(objTest, driver, "Admins Last Name Column Sort", "Admins_LName_Sort.png", "Pass");

            objPHP.fnEmailSorting();
            objRM.fnAddStepLogScreen(objTest, driver, "Admins Email Column Sort", "Admins_EMail_Sort.png", "Pass");



            objPHP.fnSelectMenuItem("Accounts", "Suppliers");
            objPHP.fnFNameSorting();
            objRM.fnAddStepLogScreen(objTest, driver, "Suppliers First Name Column Sort", "Suppliers_FName_Sort.png", "Pass");

            objPHP.fnLNameSorting();
            objRM.fnAddStepLogScreen(objTest, driver, "Suppliers Last Name Column Sort", "Suppliers_LName_Sort.png", "Pass");

            objPHP.fnEmailSorting();
            objRM.fnAddStepLogScreen(objTest, driver, "Suppliers Email Column Sort", "Suppliers_EMail_Sort.png", "Pass");



            objPHP.fnSelectMenuItem("Accounts", "Customers");
            objPHP.fnFNameSorting();
            objRM.fnAddStepLogScreen(objTest, driver, "Customers First Name Column Sort", "Customers_FName_Sort.png", "Pass");

            objPHP.fnLNameSorting();
            objRM.fnAddStepLogScreen(objTest, driver, "Customers Last Name Column Sort", "Customers_LName_Sort.png", "Pass");

            objPHP.fnEmailSorting();
            objRM.fnAddStepLogScreen(objTest, driver, "Customers Email Column Sort", "Customers_EMail_Sort.png", "Pass");



            objPHP.fnSelectMenuItem("Accounts", "GuestCustomers");
            //objPHP.fnFNameSorting();
            //objRM.fnAddStepLogScreen(objTest, driver, "GuestCustomers First Name Column Sort", "GuestCustomers_FName_Sort.png", "Pass");

            //objPHP.fnLNameSorting();
            //objRM.fnAddStepLogScreen(objTest, driver, "GuestCustomers Last Name Column Sort", "GuestCustomers_LName_Sort.png", "Pass");

            //objPHP.fnEmailSorting();
            //objRM.fnAddStepLogScreen(objTest, driver, "GuestCustomers Email Column Sort", "GuestCustomers_EMail_Sort.png", "Pass");

        }

    }
}
