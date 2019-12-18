using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AventStack.ExtentReports;
using NUnit.Framework;
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
        clsPHPTravels_Dashboard_Page objDashboard;
        [Test]
        public void Test_M9Exercise()
        {
            //Init login object(s)
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            objPHP = new clsPHPTravels_LoginPage(driver);

            //Login action(s)
            Assert.AreEqual(true, driver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail(ConfigurationManager.AppSettings.Get("email"));
            clsPHPTravels_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            //Init dashboaard object(s)
            objDashboard = new clsPHPTravels_Dashboard_Page(driver);

            //Dashboard action(s)
            Console.WriteLine(clsPHPTravels_Dashboard_Page.GetTotalAdminsLink().Text);
            objTest.Log(Status.Info, clsPHPTravels_Dashboard_Page.GetTotalAdminsLink().Text);
            Console.WriteLine(clsPHPTravels_Dashboard_Page.GetTotalSuppliersLink().Text);
            objTest.Log(Status.Info, clsPHPTravels_Dashboard_Page.GetTotalSuppliersLink().Text);
            Console.WriteLine(clsPHPTravels_Dashboard_Page.GetTotalCustomersLink().Text);
            objTest.Log(Status.Info, clsPHPTravels_Dashboard_Page.GetTotalCustomersLink().Text);
            Console.WriteLine(clsPHPTravels_Dashboard_Page.GetTotalGuestsLink().Text);
            objTest.Log(Status.Info, clsPHPTravels_Dashboard_Page.GetTotalGuestsLink().Text);
            Console.WriteLine(clsPHPTravels_Dashboard_Page.GetTotalBookingsLink().Text);
            objTest.Log(Status.Info, clsPHPTravels_Dashboard_Page.GetTotalBookingsLink().Text);
        }
    }
}
