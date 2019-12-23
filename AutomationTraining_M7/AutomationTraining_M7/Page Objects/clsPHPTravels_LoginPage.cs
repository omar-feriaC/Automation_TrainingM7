using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomationTraining_M7.Page_Objects {
    class clsPHPTravels_LoginPage : BaseTest {
        /*ATTRIBUTES*/
        public static WebDriverWait _driverWait;
        private static IWebDriver _objDriver;

        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_EMAIL_TXT = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STR_REMEMBERME_CHK = "///label[@class='checkbox']";
        readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";


        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt = _objDriver.FindElement(By.Name(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt = _objDriver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeChk = _objDriver.FindElement(By.XPath(STR_REMEMBERME_CHK));
        private static IWebElement objForgotPassLnk = _objDriver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn = _objDriver.FindElement(By.XPath(STR_LOGIN_BTN));

        public static void fnEnterEmail(string pstrEmail)
        {
            clsDriver.fnWaitForElementToExist(By.Name(STR_EMAIL_TXT));
            clsDriver.fnWaitForElementToBeVisible(By.Name(STR_EMAIL_TXT));
            objEmailTxt.Clear();
            objEmailTxt.SendKeys(pstrEmail);
        }

        public static void fnEnterPassword(string pstrPass)
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.Name(STR_PASSWORD_TXT)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Name(STR_PASSWORD_TXT)));
            objPasswordTxt.Clear();
            objPasswordTxt.SendKeys(pstrPass);
        }

        public static void fnClickLoginButton()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LOGIN_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LOGIN_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LOGIN_BTN)));
            objLoginBtn.Click();
        }

        public static void fnWaitHamburgerMenu()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.Id(STR_HAMBURGER_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_HAMBURGER_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.Id(STR_HAMBURGER_BTN)));
        }
    }
}
