using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTraining_M7.Base_Files;

namespace AutomationTraining_M7.Page_Objects
{
    class LinkedIn_LoginPageTziu:BaseTest
    {
        /*DRIVER REFERENCE*/
        private static IWebDriver _objDriver;

        /*ELEMENT LOCATORS*/
        readonly static string strUsernameId = "username";
        readonly static string strPasswordId = "password";
        readonly static string strSignInBtnXpath = "//button[text()='Sign in']";

        public LinkedIn_LoginPageTziu(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }

        /*PAGE ELEMENT OBJECTS*/
        private static IWebElement objUserNameInput => _objDriver.FindElement(By.Id(strUsernameId));
        private static IWebElement objUserPasswordInput => _objDriver.FindElement(By.Id(strPasswordId));
        private static IWebElement objSignInButton => _objDriver.FindElement(By.XPath(strSignInBtnXpath));

        /*METHODS*/
        //Get page elements
        private IWebElement GetUserNameField()
        {
            return objUserNameInput;
        }

        private IWebElement GetUserPasswordField()
        {
            return objUserPasswordInput;
        }

        private IWebElement GetSignInButton()
        {
            return objSignInButton;
        }

        /*PAGE ACTIONS*/
        //Enter username
        public void fnEnterUserName(string pstrUserName)
        {
            objUserNameInput.Clear();
            objUserNameInput.SendKeys(pstrUserName);
        }

        //Enter password
        public void fnEnterPassword(string pstrPassword)
        {
            objUserPasswordInput.Clear();
            objUserPasswordInput.SendKeys(pstrPassword);
        }

        //Click the login button
        public void fnClickSignInButton()
        {
            objSignInButton.Click();
        }
    }
}
