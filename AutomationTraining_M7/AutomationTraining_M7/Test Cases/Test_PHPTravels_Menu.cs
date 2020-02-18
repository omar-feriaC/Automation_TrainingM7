using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AutomationTraining_M7.Reporting;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_PHPTravels_menu : BaseTest
    {
        clsPHPTravels_LoginPage objPHP;
        clsPHPTravels_Main Menu;
        [Test]
        public void Test_M9Exercise_Menu()
        {
            //Init objects
            objPHP = new clsPHPTravels_LoginPage(driver);

            //Login Action
            clsPHPTravels_LoginPage.fnEnterEmail(ConfigurationManager.AppSettings.Get("email"));
            clsPHPTravels_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            Menu = new clsPHPTravels_Main(driver);
            clsPHPTravels_Main.fnPHPTravels_Main_Menu_click("Modules","");
            
            clsPHPTravels_Main.fnPHPTravels_Main_Menu_click("General", "Settings");
        }

        [Test]
        public void Test_M9Exercise_Menu_Accounts()
        {
            //Init objects
            objPHP = new clsPHPTravels_LoginPage(driver);
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            string strSortmsn;
            string strSubMenuName;
            string strReportAssert;
            string strMenuSuccess;
            //Login Action
            clsPHPTravels_LoginPage.fnEnterEmail(ConfigurationManager.AppSettings.Get("email"));
            clsPHPTravels_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            Menu = new clsPHPTravels_Main(driver);
            strSubMenuName = "Admins";
            clsPHPTravels_Main.fnPHPTravels_Main_Menu_click("Accounts", strSubMenuName);
            Assert.IsTrue(clsPHPTravels_Main.fnPHPTravels_Menu_Assert("ADMINS MANAGEMENT"), "The Sub Menu was not clicked");
            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_First_Name_Sort();
            strReportAssert = "The first Name sort test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn;
            strMenuSuccess = "The first Name sort test success in the sub menu: " + strSubMenuName;
            Assert.AreEqual("Success", strSortmsn, strReportAssert);
            if ("Success" == strSortmsn)
            {
                objRM.fnTestCaseResult(BaseTest.objTest, BaseTest.objExtent, driver, strMenuSuccess);
            }
            else 
            {
                objRM.fnTestCaseResult(BaseTest.objTest, BaseTest.objExtent, driver, strReportAssert);
            }
            
            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_Last_Name_Sort();
            Assert.AreEqual("Success", strSortmsn, strReportAssert);
            strReportAssert = "The last Name sort test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn;
            strMenuSuccess = "The last Name sort test success in the sub menu: " + strSubMenuName;
            if ("Success" == strSortmsn)
            {
                objRM.fnTestCaseResult(BaseTest.objTest, BaseTest.objExtent, driver, strMenuSuccess);
            }
            else
            {
                objRM.fnTestCaseResult(BaseTest.objTest, BaseTest.objExtent, driver, strReportAssert);
            }

            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_Email_Sort();
            Assert.AreEqual("Success", strSortmsn, strReportAssert);
            strReportAssert = "The Email sort test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn;
            strMenuSuccess = "The Email sort test success in the sub menu: " + strSubMenuName;
            if ("Success" == strSortmsn)
            {
                objRM.fnTestCaseResult(BaseTest.objTest, BaseTest.objExtent, driver, strMenuSuccess);
            }
            else
            {
                objRM.fnTestCaseResult(BaseTest.objTest, BaseTest.objExtent, driver, strReportAssert);
            }

            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_Active_Sort();
            Assert.AreEqual("Success", strSortmsn, strReportAssert);
            strReportAssert = "The Active sort test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn;
            strMenuSuccess = "The Active sort test success in the sub menu: " + strSubMenuName;
            if ("Success" == strSortmsn)
            {
                objRM.fnTestCaseResult(BaseTest.objTest, BaseTest.objExtent, driver, strMenuSuccess);
            }
            else
            {
                objRM.fnTestCaseResult(BaseTest.objTest, BaseTest.objExtent, driver, strReportAssert);
            }

            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_LastLoguin_Sort();
            Assert.AreEqual("Success", strSortmsn, strReportAssert);
            //Report Sections needed and could be optimised
            strReportAssert = "The Last Loguin sort test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn;
            strMenuSuccess = "The Last Loguin sort test success in the sub menu: " + strSubMenuName;
            if ("Success" == strSortmsn)
            {
                objRM.fnTestCaseResult(BaseTest.objTest, BaseTest.objExtent, driver, strMenuSuccess);
            }
            else
            {
                objRM.fnTestCaseResult(BaseTest.objTest, BaseTest.objExtent, driver, strReportAssert);
            }


            strSubMenuName = "Suppliers";
            clsPHPTravels_Main.fnPHPTravels_Main_Menu_click("Accounts", strSubMenuName);
            Assert.IsTrue(clsPHPTravels_Main.fnPHPTravels_Menu_Assert("SUPPLIERS MANAGEMENT"), "The Sub Menu was not clicked");
            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_First_Name_Sort();
            Assert.AreEqual("Success", strSortmsn, "The test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn);
            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_Last_Name_Sort();
            Assert.AreEqual("Success", strSortmsn, "The test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn);
            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_Email_Sort();
            Assert.AreEqual("Success", strSortmsn, "The test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn);
            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_Active_Sort();
            Assert.AreEqual("Success", strSortmsn, "The test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn);
            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_LastLoguin_Sort();
            Assert.AreEqual("Success", strSortmsn, "The test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn);

            strSubMenuName = "Customers";
            clsPHPTravels_Main.fnPHPTravels_Main_Menu_click("Accounts", strSubMenuName);
            Assert.IsTrue(clsPHPTravels_Main.fnPHPTravels_Menu_Assert("CUSTOMERS MANAGEMENT"), "The Sub Menu was not clicked");
            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_First_Name_Sort();
            Assert.AreEqual("Success", strSortmsn, "The test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn);
            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_Last_Name_Sort();
            Assert.AreEqual("Success", strSortmsn, "The test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn);
            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_Email_Sort();
            Assert.AreEqual("Success", strSortmsn, "The test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn);
            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_Active_Sort();
            Assert.AreEqual("Success", strSortmsn, "The test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn);
            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_LastLoguin_Sort();
            Assert.AreEqual("Success", strSortmsn, "The test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn);

            strSubMenuName = "GuestCustomers";
            clsPHPTravels_Main.fnPHPTravels_Main_Menu_click("Accounts", strSubMenuName);
            Assert.IsTrue(clsPHPTravels_Main.fnPHPTravels_Menu_Assert("GUEST MANAGEMENT"), "The Sub Menu was not clicked");
            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_First_Name_Sort();
            Assert.AreEqual("Success", strSortmsn, "The test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn);
            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_Last_Name_Sort();
            Assert.AreEqual("Success", strSortmsn, "The test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn);
            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_Email_Sort();
            Assert.AreEqual("Success", strSortmsn, "The test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn);
            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_Active_Sort();
            Assert.AreEqual("Success", strSortmsn, "The test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn);
            strSortmsn = clsPHPTravels_Main.fnPHPTravels_Column_LastLoguin_Sort();
            Assert.AreEqual("Success", strSortmsn, "The test fails in the sub menu: " + strSubMenuName + ". error: " + strSortmsn);
        }

    }
}
