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
            clsPHPTravels_LoginPage.fnCloseHelpWindowifPresent();
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();  
            clsPHPTravels_LoginPage.fnMinimizeChatWindowifPresent();
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
            //    Assertions(by checking if the sorted column header added a ↓ ↑) (using a new function fnAccountsMenuSubMenusSorting)(fnAccountMenuAssertions)
            //
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            string[] strarraySubmenu = { objPHP.STR_ADMINS_SUBMENU, objPHP.STR_SUPPLIERS_SUBMENU, objPHP.STR_CUSTOMERS_SUBMENU, objPHP.STR_GUESTCUSTOMERS_SUBMENU };
            string[] strarrayTitle = { "Admins Management", "Suppliers Management", "Customers Management", "Guest Management" };
            string[] strarrayAcronym = { "ACADM", "ACSUP", "ACCUS", "ACGUE" };

            for (int i=0; i<4; i++)
            {
                clsPHPTravels_LoginPage.fnSelectMenuSubMenu(objPHP.STR_ACCOUNTS_MENU, strarraySubmenu[i]);
                clsPHPTravels_LoginPage.fnAccountMenuAssertions(strarrayTitle[i], $"The Accounts - {strarrayTitle[i]} Page was not loaded correctly.", $"Accounts_{strarrayTitle[i]} _Selected_Test");
                clsPHPTravels_LoginPage.fnAccountsMenuSubMenusSorting(strarrayAcronym[i]);

            }


        }

    }
}
