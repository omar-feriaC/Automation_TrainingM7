
using AutomationTraining_M7.Base_Files; 
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class  LinkedIn_LoginPage : BaseTest
    {
        /*Driver Reference for POM*/
        private static IWebDriver _objDriver;

        /*Locators for each element*/
        readonly static string STR_USERNAME_TEXT = "username";
        readonly static string STR_PASSWORD_TEXT = "password";
        readonly static string STR_SIGNIN_BTN = "//button[text()='Sign in']";


        /*Constructor*/
        public LinkedIn_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }

        /*IWebElement Objects*/
        private static IWebElement objUserNameTxt => _objDriver.FindElement(By.Id(STR_USERNAME_TEXT));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.Id(STR_PASSWORD_TEXT));
        private static IWebElement objSingInBtn => _objDriver.FindElement(By.XPath(STR_SIGNIN_BTN));

        /*Methods*/
        //User Name
        private static IWebElement GetUserNameField()
        {
            return objUserNameTxt;
        }

        public static void fnEnterUserName(string pstrUserName)
        {
            objUserNameTxt.Clear();
            objUserNameTxt.SendKeys(pstrUserName);            
        }

        //Password
        private static IWebElement GetUPassword()
        {
            return objPasswordTxt;
        }

        public static void fnEnterPassword(string pstrPassword)
        {
            objPasswordTxt.Clear();
            objPasswordTxt.SendKeys(pstrPassword);            
        }

        //SignIn Button
        private static IWebElement GetSignInButton()
        {
            return objSingInBtn;
        }

        public static void fnClickSignInButton()
        {
            objSingInBtn.Click();
        }
    }
}
