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
        public static WebDriverWait _driverWait;
        private static IWebDriver _objDriver;

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_EMAIL_TXT = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STRREMEMBERME_LNK = "//input[@value='remember-me']";
        readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";
        readonly static string STR_TOTALADMINS_TXT = "//a[text()=' Total Admins ']";
        readonly static string STR_TOTALSUPPLIERS_TXT = "//a[text()=' Total Suppliers ']";
        readonly static string STR_TOTALCUSTOMERS_TXT = "//a[text()=' Total Customers ']";
        readonly static string STR_TOTALGUESTS_TXT = "//a[text()=' Total Guests ']";
        readonly static string STR_TOTALBOOKINGS_TXT = "//a[text()=' Total Bookings ']";

        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt => _objDriver.FindElement(By.Name(STR_EMAIL_TXT)); 
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeLnk => _objDriver.FindElement(By.XPath(STRREMEMBERME_LNK));
        private static IWebElement objForgotPassLnk => _objDriver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn => _objDriver.FindElement(By.XPath(STR_LOGIN_BTN));
        private static IWebElement objTotAdminTxt => _objDriver.FindElement(By.XPath(STR_TOTALADMINS_TXT));
        private static IWebElement objTotSuppTxt => _objDriver.FindElement(By.XPath(STR_TOTALSUPPLIERS_TXT));
        private static IWebElement objTotCustomerTxt => _objDriver.FindElement(By.XPath(STR_TOTALCUSTOMERS_TXT));
        private static IWebElement objTotGuestTxt => _objDriver.FindElement(By.XPath(STR_TOTALGUESTS_TXT));
        private static IWebElement objTotBookTxt => _objDriver.FindElement(By.XPath(STR_TOTALBOOKINGS_TXT));
        


        /*METHODS/FUNCTIONS*/

        //Email
        private IWebElement GetEmailField()
        {
            return objEmailTxt;
        }

        public static void fnEnterEmail(string pstrEmail)
        {
            clsDriver.fnWaitForElementToExist(By.Name(STR_EMAIL_TXT));
            clsDriver.fnWaitForElementToBeVisible(By.Name(STR_EMAIL_TXT));
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
            _driverWait.Until(ExpectedConditions.ElementExists(By.Name(STR_PASSWORD_TXT)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Name(STR_PASSWORD_TXT)));
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
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='Login']")));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Login']")));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Login']")));
            objLoginBtn.Click();
        }

        /*Hamburger Button*/
        public static void fnWaitHamburgerMenu()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.Id(STR_HAMBURGER_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_HAMBURGER_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.Id(STR_HAMBURGER_BTN)));
        }

        //Print the stats of the page
        public static void fnPrintStats()
        {
            Console.WriteLine(objTotAdminTxt.Text);
            objRM.fnAddStepLog(objTest, objTotAdminTxt.Text, "Pass");
            Console.WriteLine("");
            Console.WriteLine(objTotSuppTxt.Text);
            objRM.fnAddStepLog(objTest, objTotSuppTxt.Text, "Pass");
            Console.WriteLine("");
            Console.WriteLine(objTotCustomerTxt.Text);
            objRM.fnAddStepLog(objTest, objTotCustomerTxt.Text, "Pass");
            Console.WriteLine("");
            Console.WriteLine(objTotGuestTxt.Text);
            objRM.fnAddStepLog(objTest, objTotGuestTxt.Text, "Pass");
            Console.WriteLine("");
            Console.WriteLine(objTotBookTxt.Text);
            objRM.fnAddStepLog(objTest, objTotBookTxt.Text, "Pass");
        }


    }
}
