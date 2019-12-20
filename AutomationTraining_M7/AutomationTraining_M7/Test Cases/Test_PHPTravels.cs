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
             
            List<string> strTotVal = clsPHPTravels_LoginPage.fnGetTotalsValuesTxt();
            foreach(var item in strTotVal)
            {
                objRM.fnAddStepLog(objTest, item, "Pass");
            }
            objRM.fnAddStepLogScreen(objTest, driver, "Click in Side Menu", "scr.png", "Pass");
            
            
            clsPHPTravels_LoginPage.fnClickLSideBarMenu();
            objRM.fnAddStepLogScreen(objTest, driver, "Side Menu Bar", "scr1.png", "Pass");

            objPHP.fnSelectMenuItem("Tours");
            objRM.fnAddStepLogScreen(objTest, driver, "Visa Menu Bar", "scr2.png", "Pass");

            //objPHP.fnSelectMenuItem("General", "Settings");
        }

    }
}
