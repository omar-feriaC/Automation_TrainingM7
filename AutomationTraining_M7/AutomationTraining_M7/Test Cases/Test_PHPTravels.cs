using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Collections.Generic;
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
            clsPHPTravels_LoginPage.fnEnterEmail("admin@phptravels.com");
            clsPHPTravels_LoginPage.fnEnterPassword("demoadmin");
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");
            objRM.fnAddStepLogWithSnapshot(objTest, driver, "Login Step", "Login123.png", "PASS");
        
        }

        [Test]
        public void test()
        {
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            var strNa = @"C:\Tools\GitHub_Review\Automation_TrainingM7\AutomationTraining_M7\AutomationTraining_M7\ExtentReports\Screenshots\Login.png";
            objTest.Fail("details2",
                MediaEntityBuilder.CreateScreenCaptureFromPath(strNa).Build());
            Console.WriteLine();
        }


        [Test]
        public void test1()
        {
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            var strNa = @"C:\Tools\GitHub_Review\Automation_TrainingM7\AutomationTraining_M7\AutomationTraining_M7\ExtentReports\Screenshots\Login.png";
            objTest.Fail("details2",
                MediaEntityBuilder.CreateScreenCaptureFromPath(strNa).Build());
            Console.WriteLine();
            Assert.Fail();
        }

    }
}
