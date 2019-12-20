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
            // 2) Sort Asc and Desc by clicking on the headers (using a new function fnSorting)
            // 3) Attaching screens (using a new function fnStepCaptureImage) based on the  Passed or Failed results of
            //    Assertions(by checking if the sorted column header added a ↓ ↑) 
            //
            // Areas to Improve:
            // 1) Reduce significantly the code by using a new function(s) on the repeatable code
            // 2) Add code to validate actual sorting logic by using arrays and data comparison
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


           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_FIRSTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_FIRSTNAME_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_FIRSTNAME_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_FIRSTNAME_HEADER_DESC)).Count>0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_FirstNameSortingDesc_Test", status, "ACADM_FirstNameSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_FirstNameSortingDesc_Test", status, "ACADM_FirstNameSortingDesc_Test");
                Assert.Fail();
            }


            
            
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_FIRSTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_FIRSTNAME_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_FIRSTNAME_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_FIRSTNAME_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_FirstNameSortingAsc_Test", status, "ACADM_FirstNameSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_FirstNameSortingAsc_Test", status, "ACADM_FirstNameSortingAsc_Test");
                Assert.Fail();
            }



           

           
           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTNAME_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTNAME_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_LASTNAME_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_LastNameSortingAsc_Test", status, "ACADM_LastNameSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_LastNameSortingAsc_Test", status, "ACADM_LastNameSortingAsc_Test");
                Assert.Fail();
            }
           


           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTNAME_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTNAME_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_LASTNAME_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_LastNameSortingDesc_Test", status, "ACADM_LastNameSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_LastNameSortingDesc_Test", status, "ACADM_LastNameSortingDesc_Test");
                Assert.Fail();
            }
           

         
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_EMAIL_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_EMAIL_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_EMAIL_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_EMAIL_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_EmailSortingDesc_Test", status, "ACADM_EmailSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_EmailSortingDesc_Test", status, "ACADM_EmailSortingDesc_Test");
                Assert.Fail();
            }
           


            
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_EMAIL_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_EMAIL_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_EMAIL_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_EMAIL_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_EmailSortingAsc_Test", status, "ACADM_EmailSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_EmailSortingAsc_Test", status, "ACADM_EmailSortingAsc_Test");
                Assert.Fail();
            }

           


            
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_ACTIVE_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_ACTIVE_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_ACTIVE_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_ACTIVE_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_ActiveSortingAsc_Test", status, "ACADM_ActiveSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_ActiveSortingAsc_Test", status, "ACADM_ActiveSortingAsc_Test");
                Assert.Fail();
            }
           
            try
            {

                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_ACTIVE_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_ACTIVE_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_ACTIVE_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_ACTIVE_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_ActiveSortingDesc_Test", status, "ACADM_ActiveSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_ActiveSortingDesc_Test", status, "ACADM_ActiveSortingDesc_Test");
                Assert.Fail();
            }
           

            
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTLOGIN_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTLOGIN_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTLOGIN_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_LASTLOGIN_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_LastLoginSortingDesc_Test", status, "ACADM_LastLoginSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_LastLoginSortingDesc_Test", status, "ACADM_LastLoginSortingDesc_Test");
                Assert.Fail();
            }
           
            
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTLOGIN_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTLOGIN_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTLOGIN_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_LASTLOGIN_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_LastLoginSortingAsc_Test", status, "ACADM_LastLoginSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACADM_LastLoginSortingAsc_Test", status, "ACADM_LastLoginSortingAsc_Test");
                Assert.Fail();
            }




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


            try
            {

                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_FIRSTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_FIRSTNAME_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_FIRSTNAME_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_FIRSTNAME_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_FirstNameSortingDesc_Test", status, "ACSUP_FirstNameSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_FirstNameSortingDesc_Test", status, "ACSUP_FirstNameSortingDesc_Test");
                Assert.Fail();
            }



     
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_FIRSTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_FIRSTNAME_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_FIRSTNAME_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_FIRSTNAME_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_FirstNameSortingAsc_Test", status, "ACSUP_FirstNameSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_FirstNameSortingAsc_Test", status, "ACSUP_FirstNameSortingAsc_Test");
                Assert.Fail();
            }






            
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTNAME_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTNAME_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_LASTNAME_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_LastNameSortingAsc_Test", status, "ACSUP_LastNameSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_LastNameSortingAsc_Test", status, "ACSUP_LastNameSortingAsc_Test");
                Assert.Fail();
            }



           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTNAME_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTNAME_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_LASTNAME_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_LastNameSortingDesc_Test", status, "ACSUP_LastNameSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_LastNameSortingDesc_Test", status, "ACSUP_LastNameSortingDesc_Test");
                Assert.Fail();
            }


           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_EMAIL_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_EMAIL_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_EMAIL_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_EMAIL_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_EmailSortingDesc_Test", status, "ACSUP_EmailSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_EmailSortingDesc_Test", status, "ACSUP_EmailSortingDesc_Test");
                Assert.Fail();
            }



            
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_EMAIL_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_EMAIL_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_EMAIL_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_EMAIL_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_EmailSortingAsc_Test", status, "ACSUP_EmailSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_EmailSortingAsc_Test", status, "ACSUP_EmailSortingAsc_Test");
                Assert.Fail();
            }




           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_ACTIVE_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_ACTIVE_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_ACTIVE_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_ACTIVE_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_ActiveSortingAsc_Test", status, "ACSUP_ActiveSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_ActiveSortingAsc_Test", status, "ACSUP_ActiveSortingAsc_Test");
                Assert.Fail();
            }

           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_ACTIVE_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_ACTIVE_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_ACTIVE_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_ACTIVE_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_ActiveSortingDesc_Test", status, "ACSUP_ActiveSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_ActiveSortingDesc_Test", status, "ACSUP_ActiveSortingDesc_Test");
                Assert.Fail();
            }


            try
            {

                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTLOGIN_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTLOGIN_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTLOGIN_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_LASTLOGIN_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_LastLoginSortingDesc_Test", status, "ACSUP_LastLoginSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_LastLoginSortingDesc_Test", status, "ACSUP_LastLoginSortingDesc_Test");
                Assert.Fail();
            }

           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTLOGIN_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTLOGIN_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTLOGIN_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_LASTLOGIN_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_LastLoginSortingAsc_Test", status, "ACSUP_LastLoginSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACSUP_LastLoginSortingAsc_Test", status, "ACSUP_LastLoginSortingAsc_Test");
                Assert.Fail();
            }




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


           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_FIRSTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_FIRSTNAME_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_FIRSTNAME_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_FIRSTNAME_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_FirstNameSortingDesc_Test", status, "ACCUS_FirstNameSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_FirstNameSortingDesc_Test", status, "ACCUS_FirstNameSortingDesc_Test");
                Assert.Fail();
            }



        
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_FIRSTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_FIRSTNAME_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_FIRSTNAME_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_FIRSTNAME_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_FirstNameSortingAsc_Test", status, "ACCUS_FirstNameSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_FirstNameSortingAsc_Test", status, "ACCUS_FirstNameSortingAsc_Test");
                Assert.Fail();
            }






           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTNAME_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTNAME_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_LASTNAME_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_LastNameSortingAsc_Test", status, "ACCUS_LastNameSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_LastNameSortingAsc_Test", status, "ACCUS_LastNameSortingAsc_Test");
                Assert.Fail();
            }



           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTNAME_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTNAME_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_LASTNAME_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_LastNameSortingDesc_Test", status, "ACCUS_LastNameSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_LastNameSortingDesc_Test", status, "ACCUS_LastNameSortingDesc_Test");
                Assert.Fail();
            }


           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_EMAIL_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_EMAIL_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_EMAIL_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_EMAIL_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_EmailSortingDesc_Test", status, "ACCUS_EmailSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_EmailSortingDesc_Test", status, "ACCUS_EmailSortingDesc_Test");
                Assert.Fail();
            }



           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_EMAIL_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_EMAIL_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_EMAIL_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_EMAIL_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_EmailSortingAsc_Test", status, "ACCUS_EmailSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_EmailSortingAsc_Test", status, "ACCUS_EmailSortingAsc_Test");
                Assert.Fail();
            }




         
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_ACTIVE_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_ACTIVE_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_ACTIVE_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_ACTIVE_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_ActiveSortingAsc_Test", status, "ACCUS_ActiveSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_ActiveSortingAsc_Test", status, "ACCUS_ActiveSortingAsc_Test");
                Assert.Fail();
            }

            
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_ACTIVE_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_ACTIVE_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_ACTIVE_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_ACTIVE_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_ActiveSortingDesc_Test", status, "ACCUS_ActiveSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_ActiveSortingDesc_Test", status, "ACCUS_ActiveSortingDesc_Test");
                Assert.Fail();
            }


          
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTLOGIN_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTLOGIN_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTLOGIN_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_LASTLOGIN_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUSP_LastLoginSortingDesc_Test", status, "ACCUS_LastLoginSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_LastLoginSortingDesc_Test", status, "ACCUS_LastLoginSortingDesc_Test");
                Assert.Fail();
            }

           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTLOGIN_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTLOGIN_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTLOGIN_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_LASTLOGIN_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_LastLoginSortingAsc_Test", status, "ACCUS_LastLoginSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACCUS_LastLoginSortingAsc_Test", status, "ACCUS_LastLoginSortingAsc_Test");
                Assert.Fail();
            }



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

           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_FIRSTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_FIRSTNAME_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_FIRSTNAME_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_FIRSTNAME_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_FirstNameSortingDesc_Test", status, "ACGUE_FirstNameSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_FirstNameSortingDesc_Test", status, "ACGUE_FirstNameSortingDesc_Test");
                Assert.Fail();
            }



           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_FIRSTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_FIRSTNAME_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_FIRSTNAME_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_FIRSTNAME_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_FirstNameSortingAsc_Test", status, "ACGUE_FirstNameSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_FirstNameSortingAsc_Test", status, "ACGUE_FirstNameSortingAsc_Test");
                Assert.Fail();
            }






            try
            {

                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTNAME_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTNAME_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_LASTNAME_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_LastNameSortingAsc_Test", status, "ACGUE_LastNameSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_LastNameSortingAsc_Test", status, "ACGUE_LastNameSortingAsc_Test");
                Assert.Fail();
            }



           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTNAME_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTNAME_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_LASTNAME_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_LastNameSortingDesc_Test", status, "ACGUE_LastNameSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_LastNameSortingDesc_Test", status, "ACGUE_LastNameSortingDesc_Test");
                Assert.Fail();
            }


           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_EMAIL_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_EMAIL_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_EMAIL_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_EMAIL_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_EmailSortingDesc_Test", status, "ACGUE_EmailSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_EmailSortingDesc_Test", status, "ACGUE_EmailSortingDesc_Test");
                Assert.Fail();
            }



            
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_EMAIL_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_EMAIL_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_EMAIL_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_EMAIL_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_EmailSortingAsc_Test", status, "ACGUE_EmailSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_EmailSortingAsc_Test", status, "ACGUE_EmailSortingAsc_Test");
                Assert.Fail();
            }




           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_ACTIVE_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_ACTIVE_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_ACTIVE_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_ACTIVE_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_ActiveSortingAsc_Test", status, "ACGUE_ActiveSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_ActiveSortingAsc_Test", status, "ACGUE_ActiveSortingAsc_Test");
                Assert.Fail();
            }

           
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_ACTIVE_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_ACTIVE_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_ACTIVE_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_ACTIVE_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_ActiveSortingDesc_Test", status, "ACGUE_ActiveSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_ActiveSortingDesc_Test", status, "ACGUE_ActiveSortingDesc_Test");
                Assert.Fail();
            }


      
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTLOGIN_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTLOGIN_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTLOGIN_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_LASTLOGIN_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_LastLoginSortingDesc_Test", status, "ACGUE_LastLoginSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_LastLoginSortingDesc_Test", status, "ACGUE_LastLoginSortingDesc_Test");
                Assert.Fail();
            }

         
            try
            {
                clsPHPTravels_LoginPage.fnSorting(objPHP.STR_LASTLOGIN_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(objPHP.STR_LASTLOGIN_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(objPHP.STR_LASTLOGIN_HEADER_ASC));Assert.AreEqual(true, driver.FindElements(By.XPath(objPHP.STR_LASTLOGIN_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_LastLoginSortingAsc_Test", status, "ACGUE_LastLoginSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, "ACGUE_LastLoginSortingAsc_Test", status, "ACGUE_LastLoginSortingAsc_Test");
                Assert.Fail();
            }



            ////////////////////////


        }

    }
}
