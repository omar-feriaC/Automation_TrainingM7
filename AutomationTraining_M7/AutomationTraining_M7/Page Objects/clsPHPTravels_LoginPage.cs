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
    class clsPHPTravels_LoginPage : BaseTest
    {
        /*ATTRIBUTES*/
        public static WebDriverWait driverWait;
        private static IWebDriver objDriver;

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_EMAIL_TXT = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STRREMEMBERME_LNK = "//ins[@class='iCheck-helper']";
        readonly static string STR_FORGOTPASS_LNK = "//strong[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//span[contains(text()='Login')]";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";

        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            objDriver = pobjDriver;
            driverWait = new WebDriverWait(objDriver, new TimeSpan(0, 0, 40));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objLoginBtn = driver.FindElement(By.XPath(STR_LOGIN_BTN));
        private static IWebElement objEmailTxt = driver.FindElement(By.Name(STR_EMAIL_TXT)); 
        private static IWebElement objPasswordTxt = driver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeLnk = driver.FindElement(By.XPath(STRREMEMBERME_LNK));
        private static IWebElement objForgotPassLnk = driver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objHamburgerBtn = driver.FindElement(By.XPath(STR_HAMBURGER_BTN));



        /*METHODS/FUNCTIONS*/

        //Email
        private IWebElement GetEmailField()
        {
            return objEmailTxt;
        }

        public static void fnEnterEmail(string pstrEmail)
        {
            driverWait.Until(ExpectedConditions.ElementExists(By.Name(STR_EMAIL_TXT)));
            driverWait.Until(ExpectedConditions.ElementIsVisible(By.Name(STR_EMAIL_TXT)));
            driverWait.Until(ExpectedConditions.ElementToBeClickable(By.Name(STR_EMAIL_TXT)));
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
            driverWait.Until(ExpectedConditions.ElementExists(By.Name(STR_PASSWORD_TXT)));
            driverWait.Until(ExpectedConditions.ElementIsVisible(By.Name(STR_PASSWORD_TXT)));
            driverWait.Until(ExpectedConditions.ElementToBeClickable(By.Name(STR_PASSWORD_TXT)));

            objPasswordTxt.Clear();
            objPasswordTxt.SendKeys(pstrPass);
        }

        //Login Button
        private IWebElement GetLoginButton()
        {
            return objRememberMeLnk;
        }

        public static void fnClickLoginButton()
        {

            driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LOGIN_BTN)));
            driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LOGIN_BTN)));
            driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LOGIN_BTN)));
            objLoginBtn.Click();
        }

        /*Hamburger Button*/
        public static void fnWaitHamburgerMenu()
        {
            driverWait.Until(ExpectedConditions.ElementExists(By.Id(STR_HAMBURGER_BTN)));
            driverWait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_HAMBURGER_BTN)));
            driverWait.Until(ExpectedConditions.ElementToBeClickable(By.Id(STR_HAMBURGER_BTN)));
        }


    }
}
