using AutomationTraining_M7.Base_Files;
using NUnit.Framework;
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
        // ATTRIBUTES
        public static WebDriverWait _driverWait;
        private static IWebDriver _objDriver;
        // LOCATORS DESCRIPTION
        readonly static string STR_EMAIL_TXT = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        public static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";
        readonly static string STR_ADMIN_LBL = "(//a[i[@class='fa fa-user']])[1]";
        readonly static string STR_SUPPLIER_LBL = "(//a[i[@class='fa fa-user']])[2]";
        readonly static string STR_CUSTOMER_LBL = "(//a[i[@class='fa fa-users']])[1]";
        readonly static string STR_GUEST_LBL = "(//a[i[@class='fa fa-users']])[2]";
        readonly static string STR_BOOKING_LBL = "//a[i[@class='fa fa-tag']]";
        // CONSTRUCTOR
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }
        // OBJECT DEFINITION
        private static IWebElement objEmailTxt => driver.FindElement(By.Name(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt => driver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objLoginBtn => driver.FindElement(By.XPath(STR_LOGIN_BTN));
        private static IWebElement objAdminLbl => driver.FindElement(By.XPath(STR_ADMIN_LBL));
        private static IWebElement objSupplierLbl => driver.FindElement(By.XPath(STR_SUPPLIER_LBL));
        private static IWebElement objCustomerLbl => driver.FindElement(By.XPath(STR_CUSTOMER_LBL));
        private static IWebElement objGuestLbl => driver.FindElement(By.XPath(STR_GUEST_LBL));
        private static IWebElement objBookingLbl => driver.FindElement(By.XPath(STR_BOOKING_LBL));
        /*METHODS/FUNCTIONS*/
        //Email
        public static void fnEnterEmail(string pstrEmail)
        {
            clsDriver.fnWaitForElementToExist(By.Name(STR_EMAIL_TXT));
            clsDriver.fnWaitForElementToBeVisible(By.Name(STR_EMAIL_TXT));
            clsDriver.fnWaitForElementToBeClickable(By.Name(STR_EMAIL_TXT));
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
            clsDriver.fnWaitForElementToExist(By.Name(STR_PASSWORD_TXT));
            clsDriver.fnWaitForElementToBeVisible(By.Name(STR_PASSWORD_TXT));
            clsDriver.fnWaitForElementToBeClickable(By.Name(STR_PASSWORD_TXT));
            objPasswordTxt.Clear();
            objPasswordTxt.SendKeys(pstrPass);
        }
        //Login Button
        private IWebElement GetLoginButton()
        {
            return objLoginBtn;
        }
        public static void fnClickLoginButton()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_LOGIN_BTN));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LOGIN_BTN));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_LOGIN_BTN));
            objLoginBtn.Click();
        }
        //Hamburger Button
        public static void fnWaitHamburgerMenu()
        {
            clsDriver.fnWaitForElementToExist(By.Id(STR_HAMBURGER_BTN));
            clsDriver.fnWaitForElementToBeVisible(By.Id(STR_HAMBURGER_BTN));
            clsDriver.fnWaitForElementToBeClickable(By.Id(STR_HAMBURGER_BTN));
        }
        //Print Labels on the Dashboard
        public static IWebElement GetAdminLbl()
        {
            return objAdminLbl;
        }
        public static IWebElement GetSupplierLbl()
        {
            return objSupplierLbl;
        }
        public static IWebElement GetGuestLbl()
        {
            return objGuestLbl;
        }
        public static IWebElement GetCustomerLbl()
        {
            return objCustomerLbl;
        }
        public static IWebElement GetBookingLbl()
        {
            return objBookingLbl;
        }
    }
}
