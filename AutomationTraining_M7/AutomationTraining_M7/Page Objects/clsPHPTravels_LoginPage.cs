using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class clsPHPTravels_LoginPage
    {
        /*ATTRIBUTES*/

        private static IWebDriver _objDriver;
        public WebDriverWait _driverWait;

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_EMAIL_TXT = "email";
        //readonly static string STR_EMAIL_TXT2 = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STRREMEMBERME_LNK = "//label[@class='checkbox']";
        //readonly static string STRREMEMBERME_LNK2 = "//label[@class='checkbox']";
        readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";

        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt = _objDriver.FindElement(By.Name(STR_EMAIL_TXT)); 
        private static IWebElement objPasswordTxt = _objDriver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeLnk = _objDriver.FindElement(By.XPath(STRREMEMBERME_LNK));
        private static IWebElement objForgotPassLnk = _objDriver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn = _objDriver.FindElement(By.XPath(STR_LOGIN_BTN));
        private static IWebElement objHamburuerBtn = _objDriver.FindElement(By.Id(STR_HAMBURGER_BTN));

        /*METHODS/FUNCTIONS*/

        //Email
        private IWebElement GetEmailField()
        {
            return objEmailTxt;
        }

        public static void fnEnterEmail(string pstrEmail)
        {
            //clsDriver.fnWaitForElementToExist(By.Name(STR_EMAIL_TXT));
            //clsDriver.fnWaitForElementToBeVisible(By.Name(STR_EMAIL_TXT));
            objEmailTxt.Clear();
            objEmailTxt.SendKeys(pstrEmail);
        }

        //Password
        private IWebElement GetPasswordField()
        {
            return objPasswordTxt;
        }

        public static void fnEnterPassword(string pstrPass)
        {
            //clsDriver.fnWaitForElementToExist(By.Name(STR_PASSWORD_TXT));
            //clsDriver.fnWaitForElementToBeVisible(By.Name(STR_PASSWORD_TXT));
            objPasswordTxt.Clear();
            objPasswordTxt.SendKeys(pstrPass);
        }

        //Login Button
        private IWebElement GetLoginButton()
        {
            return objLoginBtn;
            //return objRememberMeLnk;
        }

        public static void fnClickLoginButton()
        {
            //clsDriver.fnWaitForElementToExist(By.XPath(STR_LOGIN_BTN));
            //clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LOGIN_BTN));
            //clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_LOGIN_BTN));
            objLoginBtn.Click();
        }

        ///*Hamburger Button*/
        //public static void fnWaitHamburgerMenu()
        //{
        //    clsDriver.fnWaitForElementToExist(By.Id(STR_HAMBURGER_BTN));
        //    clsDriver.fnWaitForElementToBeVisible(By.Id(STR_HAMBURGER_BTN));
        //    clsDriver.fnWaitForElementToBeClickable(By.Id(STR_HAMBURGER_BTN));
            
        //}


    }
}
