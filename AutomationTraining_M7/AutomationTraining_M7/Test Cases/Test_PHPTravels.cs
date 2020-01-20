using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
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
    class Test_PHPTravels : BaseTest
    {
        clsPHPTravels_LoginPage objPHP;
        clsPHPTravels_Main pageMain;


        [Test]
        public void Test_M9Exercise()
        {

            /*URL for Webdriver*/
            

            //Init objects
            objPHP = new clsPHPTravels_LoginPage(BaseTest.driver);
            //Login Action
            Assert.AreEqual(true, BaseTest.driver.Title.Contains("Administrador Login."), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail("admin@phptravels.com");
            clsPHPTravels_LoginPage.fnEnterPassword("demoadmin");
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, BaseTest.driver.Title.Contains("Dashboard."), "The Dashboard was not loaded correctly.");
            pageMain = new clsPHPTravels_Main(BaseTest.driver);
            Dictionary<string,string> listValues = pageMain.CreateReport();
            foreach (KeyValuePair<string,string> a in listValues) 
            { 
                //do magic 
            }


        }

    }
}
