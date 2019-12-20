using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AutomationTraining_M7.Reporting;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {
       clsPHPTravels_LoginPage objPHP;
       string status;
       public static clsReportManager objRep = new clsReportManager();

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
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //
            //Below code is a running version of a first approach on how to :
            // 1) Interact with the Menus and SubMenus (using a new function that receives parameters fnSelectMenuSubMenu)
            // 2) Sort Asc and Desc by clicking on the headers (using a new function fnClick)
            // 3) Attaching screens (using a new function fnStepCaptureImage) based on the  Passed or Failed results of
            //    Assertions(by checking if the sorted column header added a ↓ ↑) (using a new function fnAccountsMenuSubMenusSorting)
            //
            // Areas to Improve:
            //
            // 1) Add code to validate actual sorting logic by using arrays and data comparison
            //      
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            clsPHPTravels_LoginPage.fnSelectMenuSubMenu(objPHP.STR_ACCOUNTS_MENU, objPHP.STR_ADMINS_SUBMENU);
            try { 
            Assert.AreEqual(true, driver.Title.Contains("Admins Management"), "The Accounts-Admin Page was not loaded correctly.");
            status="Passed";
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "Accounts_Admins_Selected_Test", status, "Accounts_Admins_Selected_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "Accounts_Admins_Selected_Test", status, "Accounts_Admins_Selected_Test");
                Assert.Fail();
            }

            clsPHPTravels_LoginPage.fnAccountsMenuSubMenusSorting("ACADM");



            ////////////////////////



            clsPHPTravels_LoginPage.fnSelectMenuSubMenu(objPHP.STR_ACCOUNTS_MENU, objPHP.STR_SUPPLIERS_SUBMENU);
            try
            {
                Assert.AreEqual(true, driver.Title.Contains("Suppliers Management"), "The Accounts-Suppliers Page was not loaded correctly.");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "Accounts_Suppliers_Selected_Test", status, "Accounts_Suppliers_Selected_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "Accounts_Suppliers_Selected_Test", status, "Accounts_Suppliers_Selected_Test");
                Assert.Fail();
            }


            clsPHPTravels_LoginPage.fnAccountsMenuSubMenusSorting("ACSUP");



            ////////////////////////


            clsPHPTravels_LoginPage.fnSelectMenuSubMenu(objPHP.STR_ACCOUNTS_MENU, objPHP.STR_CUSTOMERS_SUBMENU);
            try
            {
                Assert.AreEqual(true, driver.Title.Contains("Customers Management"), "The Accounts-Customers Page was not loaded correctly.");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "Accounts_Customers_Selected_Test", status, "Accounts_Customers_Selected_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "Accounts_Customers_Selected_Test", status, "Accounts_Customers_Selected_Test");
                Assert.Fail();
            }

            clsPHPTravels_LoginPage.fnAccountsMenuSubMenusSorting("ACCUS");



            ////////////////////////

            clsPHPTravels_LoginPage.fnSelectMenuSubMenu(objPHP.STR_ACCOUNTS_MENU, objPHP.STR_GUESTCUSTOMERS_SUBMENU);
            try
            {
                Assert.AreEqual(true, driver.Title.Contains("Guest Management"), "The Accounts-GuestCustomers Page was not loaded correctly.");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "Accounts_GuestCustomers_Selected_Test", status, "Accounts_GuestCustomers_Selected_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "Accounts_GuestCustomers_Selected_Test", status, "Accounts_GuestCustomers_Selected_Test");
                Assert.Fail();
            }

            clsPHPTravels_LoginPage.fnAccountsMenuSubMenusSorting("ACGUE");


            ////////////////////////


        }

    }
}
