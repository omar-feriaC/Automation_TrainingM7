using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {
        clsPHPTravels_LoginPage objPHP;
        //public static WebDriverWait WdriverWait;

        [Test]
        
        public void Test_M9Exercise()
        {
            
            try
            {
                objPHP = new clsPHPTravels_LoginPage(driver);



                //Init objects
                objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);


                //Login Action
                Assert.AreEqual(true, driver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");

                clsPHPTravels_LoginPage.fnEnterEmail(strUserName);
                clsPHPTravels_LoginPage.fnEnterPassword(strPassword);
                clsPHPTravels_LoginPage.fnClickLoginButton();
                clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
                Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");
                clsPHPTravels_LoginPage.fnPrintStats();
                clsPHPTravels_LoginPage.fnSideMenuBtn("Accounts");
                Console.WriteLine("");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error in: \n" + ex.GetBaseException());
                

            }
        }


    }
}
