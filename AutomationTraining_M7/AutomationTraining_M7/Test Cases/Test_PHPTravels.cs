using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
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


        [Test]
        public void Test_M9Exercise()
        {
            //Init objects
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            objPHP = new clsPHPTravels_LoginPage(driver, objExtent, objTest);
            //Login Action
            Assert.AreEqual(true, driver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail(ConfigurationManager.AppSettings.Get("email"));
            clsPHPTravels_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            clsPHPTravels_LoginPage.fnClickLoginButton();
            Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");
            //Get Dashboard
            IList<IWebElement> DashElements = driver.FindElements(By.XPath("//ul[@class='serverHeader__statsList']//child::a"));
            foreach (IWebElement el in DashElements)
            {
                Console.WriteLine(el.Text);
                objTest.Log(Status.Info, el.Text);
            }
            //Click Menu
            clsPHPTravels_LoginPage.fnClickMenu("ACCOUNTS");
            //Sort Submenu-Admins
            clsPHPTravels_LoginPage.fnSortingAdmins();
            //Click Menu
            clsPHPTravels_LoginPage.fnClickMenu("ACCOUNTS");
            //Sort Submenu-Suppliers
            clsPHPTravels_LoginPage.fnSortingSuppliers();
            //Click Menu
            clsPHPTravels_LoginPage.fnClickMenu("ACCOUNTS");
            //Sort Submenu-Customer
            clsPHPTravels_LoginPage.fnSortingCustomer();
            //Click Menu
            clsPHPTravels_LoginPage.fnClickMenu("ACCOUNTS");
            //Sort Submenu-GuestCustomer
            clsPHPTravels_LoginPage.fnSortingGuestCustomer();


        }

    }
}
