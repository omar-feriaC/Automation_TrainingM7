using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AutomationTraining_M7.Reporting;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
        clsPHPTravels_Main_Menu pageMainMenu;


        [Test]
        public void Test_M9Exercise_Menu()
        {

            /*URL for Webdriver*/


            //Init objects
            objPHP = new clsPHPTravels_LoginPage(driver);
            
            //Login Action
            //Assert.AreEqual(true, BaseTest.driver.Title.Contains("Administrador Login."), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail("admin@phptravels.com");
            clsPHPTravels_LoginPage.fnEnterPassword("demoadmin");
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            //Assert.AreEqual(true, BaseTest.driver.Title.Contains("Dashboard."), "The Dashboard was not loaded correctly.");
            pageMainMenu = new clsPHPTravels_Main_Menu(driver);
            pageMainMenu.clsPHPTravels_Main_Menu_click("Modules","Menu");
            pageMainMenu.clsPHPTravels_Main_Menu_click("Hotels", "SubMenu"); 


            // ExtentTest pobjTest, ExtentReports pobjExtent, IWebDriver pobjDriver
        }

    }
}
