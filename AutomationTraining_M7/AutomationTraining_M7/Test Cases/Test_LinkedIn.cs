using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AutomationTraining_M7.Reporting;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_LinkedIn : BaseTest
    {
        LinkedIn_LoginPage objLogin;

        [Test]
        public void Login_LinkedIn()
        {
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            objLogin = new LinkedIn_LoginPage(driver);
            Assert.AreEqual(true, driver.Title.Contains("Login"), "Title not mach");
            LinkedIn_LoginPage.fnEnterUserName(ConfigurationManager.AppSettings.Get("username"));
            LinkedIn_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            LinkedIn_LoginPage.fnClickSignInButton();
            //Assert.AreEqual("1", "1");
            //objRM.fnTestCaseResult(objTest, objExtent, driver);
            objTest.Log(Status.Pass, "Login Successfully");
            //assert
            var status = objTest.Status;
            Assert.AreEqual("1", "2");
            var status2 = objTest.Status;
            Console.WriteLine(status2.ToString());
            //objRM.fnAddStepLog(objTest, "The step Pass successfully", TestContext.CurrentContext.Result.Outcome.Status);
            //objRM.fnAddStepLogScreen(objTest, driver, "The step Pass successfully", "Step one pass", "Pass");

            //Assert.Fail();
        }
    }
}
