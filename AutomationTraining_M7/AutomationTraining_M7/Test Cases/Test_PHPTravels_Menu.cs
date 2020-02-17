using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AutomationTraining_M7.Reporting;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_PHPTravels_menu : BaseTest
    {
        clsPHPTravels_LoginPage objPHP;
        clsPHPTravels_Main Menu;
        [Test]
        public void Test_M9Exercise_Menu()
        {
            //Init objects
            objPHP = new clsPHPTravels_LoginPage(driver);
            
            //Login Action
            //Assert.AreEqual(true, BaseTest.driver.Title.Contains("Administrador Login."), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail("admin@phptravels.com");
            clsPHPTravels_LoginPage.fnEnterPassword("demoadmin");
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            //Assert.AreEqual(true, BaseTest.driver.Title.Contains("Dashboard."), "The Dashboard was not loaded correctly.");
            Menu = new clsPHPTravels_Main(driver);
            clsPHPTravels_Main.fnPHPTravels_Main_Menu_click("Modules","Menu");
            
            clsPHPTravels_Main.fnPHPTravels_Main_Menu_click("Settings", "SubMenu");
        }

    }
}
