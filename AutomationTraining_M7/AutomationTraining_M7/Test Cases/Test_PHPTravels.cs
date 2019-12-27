using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AutomationTraining_M7.Reporting;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
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
        public static WebDriverWait wait2;
        clsPHPTravels_LoginPage objPHP;
        
        [Test]
        public void Test_M9Exercise()
        {
            //Init objects
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            objPHP = new clsPHPTravels_LoginPage(driver);
            //Login Action
            Assert.AreEqual(true, driver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnMinimizeLiveChat();
            clsPHPTravels_LoginPage.fnEnterEmail(ConfigurationManager.AppSettings.Get("email"));
            clsPHPTravels_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");
            //clsPHPTravels_LoginPage.fnMinimizeLiveChat();


            //Print in the console and Report the totals and values for Total links
            IList <IWebElement> ElementList = driver.FindElements(By.XPath("//div[contains(@class,'serverHeader')]//li"));
            for (int x = 2; x < ElementList.Count; x++)
            {
                Console.WriteLine(ElementList[x].Text);

                objTest.Log(Status.Info, ElementList[x].Text);
            }

            //Verify all Submenus from a Menu choosen
           clsPHPTravels_LoginPage.fnGetMenuSubmenu("Accounts");

        }

    }
}
