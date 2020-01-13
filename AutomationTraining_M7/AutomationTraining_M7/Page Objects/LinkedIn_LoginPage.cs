using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class LinkedIn_LoginPage : BaseTest
    {

        // DRIVER REFERENCE FOR POM

        private static IWebDriver _objDriver;

        // LOCATORS FOR EACH ELEMENT

        readonly static string STR_USERNAME_TEXT = "username";
        readonly static string STR_PASSWORD_TEXT = "password";
        readonly static string STR_SIGNIN_BTN = "//button[text()='Sign in']";


        // CONSTRUCTOR

        public LinkedIn_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _objDriver.Manage().Window.Maximize();

        }

        // IWEBELEMENT OBJECTS

        private static IWebElement objUserNameTxt => _objDriver.FindElement(By.Id(STR_USERNAME_TEXT));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.Id(STR_PASSWORD_TEXT));
        private static IWebElement objSignInBtn => _objDriver.FindElement(By.XPath(STR_SIGNIN_BTN));

        // METHODS
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

        private static IWebElement GetPasswordField()
        {
            return objPasswordTxt;
        }

        public static void fnEnterPassword(string pstrPassword)
        {
            objPasswordTxt.Clear();
            objPasswordTxt.SendKeys(pstrPassword);
        }

        // SignIn button

        private static IWebElement GetSignInButton()
        {
            return objSignInBtn;
        }

        public static void fnClickSignInBtn()
        {
            objSignInBtn.Click();
        }
    }
}

