using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AutomationTraining_M7.Reporting;
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
            objPHP = new clsPHPTravels_LoginPage(driver);
            //Login Action
            Assert.AreEqual(true, driver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail(ConfigurationManager.AppSettings.Get("email"));
            clsPHPTravels_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");


            //Print in the console and Report the totals and values for Total links
            IList<IWebElement> ElementList = driver.FindElements(By.XPath("//div[contains(@class,'serverHeader')]//li"));
            for (int x = 2; x < ElementList.Count; x++)
            {
                Console.WriteLine(ElementList[x].Text);
                clsReportManager.fnTestCaseResult(objTest, objExtent, objPHP);
                objTest.Log(Status.Info, ElementList[x].Text);
            }

            //Access Menu and Submenus
            //IList<IWebElement> ElementList2 = driver.FindElements(By.XPath("//ul[@id='ACCOUNTS']//li//a"));
            /*for (int y = 0; y < ElementList2.Count; y++)
            {
                clsPHPTravels_LoginPage.fnGetMenu("Accounts");

            }*/
            clsPHPTravels_LoginPage.fnGetMenu("Accounts");



        }

    }
}
