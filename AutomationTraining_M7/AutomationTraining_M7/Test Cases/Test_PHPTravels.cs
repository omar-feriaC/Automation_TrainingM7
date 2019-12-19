using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AutomationTraining_M7.Reporting;
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
       string status="Passed";
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
            //Incomplete: Missing Asserts to validate failures and report them  
            //below code is a first approach on how to interact(Need to figure out how to make reusable)
            //with the Menus and SubMenus (using a new function that receives parameters fnSelectMenuSubMenu) , 
            //Sorting by Clicking on the headers (using a new function fnSorting)
            //and attaching screens after each click (using a new function fnStepCaptureImage)
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            clsPHPTravels_LoginPage.fnSelectMenuSubMenu(objPHP.STR_ACCOUNTS_MENU, objPHP.STR_ADMINS_SUBMENU);
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_FIRSTNAME_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "Accounts_Admins_Selected_Test", status, "Accounts_Admins_Selected_Test");
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTNAME_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_FirstNameSorting_Test", status, "ACADM_FirstNameSorting_Test");
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_EMAIL_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_LastNameSorting_Test", status, "ACADM_LastNameSorting_Test");
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_ACTIVE_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_EmailSorting_Test", status, "ACADM_EmailSorting_Test");
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTLOGIN_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_ActiveSorting_Test", status, "ACADM_ActiveSorting_Test");
            clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTLOGIN_HEADER));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTLOGIN_HEADER));
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_LastLoginSorting_Test", status, "ACADM_LastLoginSorting_Test");



            clsPHPTravels_LoginPage.fnSelectMenuSubMenu(objPHP.STR_ACCOUNTS_MENU, objPHP.STR_SUPPLIERS_SUBMENU);
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_FIRSTNAME_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "Accounts_Suppliers_Selected_Test", status, "Accounts_Suppliers_Selected_Test");
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTNAME_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_FirstNameSorting_Test", status, "ACSUP_FirstNameSorting_Test");
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_EMAIL_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_LastNameSorting_Test", status, "ACSUP_LastNameSorting_Test");
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_ACTIVE_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_EmailSorting_Test", status, "ACSUP_EmailSorting_Test");
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTLOGIN_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_ActiveSorting_Test", status, "ACSUP_ActiveSorting_Test");
            clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTLOGIN_HEADER));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTLOGIN_HEADER));
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_LastLoginSorting_Test", status, "ACSUP_LastLoginSorting_Test");



            clsPHPTravels_LoginPage.fnSelectMenuSubMenu(objPHP.STR_ACCOUNTS_MENU, objPHP.STR_CUSTOMERS_SUBMENU);
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_FIRSTNAME_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "Accounts_Customers_Selected_Test", status, "Accounts_Customers_Selected_Test");
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTNAME_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_FirstNameSorting_Test", status, "ACCUS_FirstNameSorting_Test");
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_EMAIL_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_LastNameSorting_Test", status, "ACCUS_LastNameSorting_Test");
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_ACTIVE_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_EmailSorting_Test", status, "ACCUS_EmailSorting_Test");
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTLOGIN_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_ActiveSorting_Test", status, "ACCUS_ActiveSorting_Test");
            clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTLOGIN_HEADER));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTLOGIN_HEADER));
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_LastLoginSorting_Test", status, "ACCUS_LastLoginSorting_Test");



            clsPHPTravels_LoginPage.fnSelectMenuSubMenu(objPHP.STR_ACCOUNTS_MENU, objPHP.STR_GUESTCUSTOMERS_SUBMENU);
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_FIRSTNAME_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "Accounts_GuestCustomers_Selected_Test", status, "Accounts_GuestCustomers_Selected_Test");
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTNAME_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGCUS_FirstNameSorting_Test", status, "ACGCUS_FirstNameSorting_Test");
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_EMAIL_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGCUS_LastNameSorting_Test", status, "ACGCUS_LastNameSorting_Test");
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_ACTIVE_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGCUS_EmailSorting_Test", status, "ACGCUS_EmailSorting_Test");
            clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTLOGIN_HEADER);
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGCUS_ActiveSorting_Test", status, "ACGCUS_ActiveSorting_Test");
            clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTLOGIN_HEADER));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTLOGIN_HEADER));
            objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGCUS_LastLoginSorting_Test", status, "ACGCUS_LastLoginSorting_Test");



        }

    }
}
