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
        int x = 2;


        [Test]
        public void Test_M9Exercise()
        {
            //Init objects
            objPHP = new clsPHPTravels_LoginPage(driver);
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            //Login Action
            Assert.AreEqual(true, driver.Title.Contains("Administrator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail(ConfigurationManager.AppSettings.Get("email"));
            clsPHPTravels_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");


            //Printing the Total Links info in Console and adding them to the Extent Report
            IList<IWebElement> ElementList = driver.FindElements(By.XPath("//div[contains(@class,'serverHeader')]//li"));
            for(int x = 2; x< ElementList.Count; x++)
            {
                x++;
                Console.WriteLine(ElementList[x].Text);
                objTest.Log(Status.Info, ElementList[x].Text);
            }

        }

    }
}
