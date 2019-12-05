using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class Linkedin_LoginPage : BaseTest
    {
        //DRIVER REFERENCE DOR POM
        private static IWebDriver _objDriver;

        internal static void FnEnterPassword(object p)
        {
            throw new NotImplementedException();
        }

        //LOCATOR FOR EACH ELEMENT
        readonly static string STR_USERNAME_TEXT = "username";
        readonly static string STR_PASSWORD_TEXT = "password";
        readonly static string STR_LOGIN_BTN = "//button[@class='btn__primary--large from__button--floating']";

        //CONSTRUCTOR
        public Linkedin_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }

        //IWEBELEMENT OBJECTS
        private static IWebElement objUserName => _objDriver.FindElement(By.Id(STR_USERNAME_TEXT));
        private static IWebElement objPassword => _objDriver.FindElement(By.Id(STR_PASSWORD_TEXT));
        private static IWebElement objsingIn => _objDriver.FindElement(By.XPath(STR_LOGIN_BTN));

        //METHODS
        //User Name
        private static IWebElement GetUserNameFiedl()
        {
            return objUserName;
        }

        public static void FnEnterUserName(string pstrUserName)
        {
            objUserName.Clear();
            objUserName.SendKeys(pstrUserName);

        }

        //PASSWORD
        private static IWebElement GetPassword()
        {
            return objPassword;
        }

        public static void FnEnterPassword(string pstrPassword)
        {
            objPassword.Clear();
            objPassword.SendKeys(pstrPassword);

        }
        //LoginButton

        private static IWebElement GetsingInButton()
        {
            return objsingIn;
        }

        public static void fnClickSingInButton()
        {
            objsingIn.Click();
        }

    }


}
