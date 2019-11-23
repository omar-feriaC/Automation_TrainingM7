using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class LinkedIn_LoginPage : BaseTest
    {
        /*DRIVER REFERENCE FOR POM*/
        private static IWebDriver _objDriver;

        /*LOCATORS FOR EACH ELEMENT*/
        readonly static string STR_USERNAME_TEXT = "username";
        readonly static string STR_PASSWORD_TEXT = "password";
        readonly static string STR_SIGNIN_BTN = "//button[text()='Sign in']";
        
        /*CONSTRUCTOR*/
        public LinkedIn_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }

        /*IWEBELEMEMT OBJECTS*/
        private static IWebElement objUserName => _objDriver.FindElement(By.Id(""));

    }
}
