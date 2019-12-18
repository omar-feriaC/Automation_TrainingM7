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
        clsPHPTravels_DashboardPage objPHPDsh;


        [Test]
        public void Test_M9Exercise()
        {
            //Init objects
            objPHP = new clsPHPTravels_LoginPage(driver);
            //Login Action
            Assert.AreEqual(true, driver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail("admin@phptravels.com");
            clsPHPTravels_LoginPage.fnEnterPassword("demoadmin");
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");
            //Init objects
            objPHPDsh = new clsPHPTravels_DashboardPage(driver);
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            //Print counts in console
            Console.WriteLine(clsPHPTravels_DashboardPage.GetAdminsLbl().Text);            
            Console.WriteLine(clsPHPTravels_DashboardPage.GetSuppliersLbl().Text);           
            Console.WriteLine(clsPHPTravels_DashboardPage.GetCustomersLbl().Text);          
            Console.WriteLine(clsPHPTravels_DashboardPage.GetGuestsLbl().Text);           
            Console.WriteLine(clsPHPTravels_DashboardPage.GetBookingsLbl().Text);
            //Add counts comments to report
            objTest.Log(Status.Info, (clsPHPTravels_DashboardPage.GetAdminsLbl().Text));
            objTest.Log(Status.Info, (clsPHPTravels_DashboardPage.GetSuppliersLbl().Text));
            objTest.Log(Status.Info, (clsPHPTravels_DashboardPage.GetCustomersLbl().Text));
            objTest.Log(Status.Info, (clsPHPTravels_DashboardPage.GetGuestsLbl().Text));
            objTest.Log(Status.Info, (clsPHPTravels_DashboardPage.GetBookingsLbl().Text));
        }
    }
}
