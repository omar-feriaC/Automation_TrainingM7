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
        public static WebDriverWait _driverWait;
        public static IWebDriver _objDriver;

        /*LOCATORS DESCRIPTION LOGIN*/
        readonly static string STR_EMAIL_TXT = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STRREMEMBERME_LNK = "//label[@class='checkbox']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";
        /*LOCATORS DESCRIPTION DASHBOARD*/
        readonly static string STR_ADMINS_LBL = "(//a[i[@class='fa fa-user']])[1]";
        readonly static string STR_SUPPLIERS_LBL = "(//a[i[@class='fa fa-user']])[2]";
        readonly static string STR_CUSTOMERS_LBL = "(//a[i[@class='fa fa-users']])[1]";
        readonly static string STR_GUESTS_LBL = "(//a[i[@class='fa fa-users']])[2]";
        readonly static string STR_BOOKINGS_LBL = "//a[i[@class='fa fa-tag']]";
        /*LOCATORS TABLES*/
        readonly static string STR_EMPTY_TABLE = "//td[text()='Entries not found.']";
        readonly static string STR_TABLE_HEADER = "//div[contains(text(),'Management')]";

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
        private static IWebElement objLoginBtn => _objDriver.FindElement(By.XPath(STR_LOGIN_BTN));
        /*OBJECT DEFINITION DASHBOARD*/
        private static IWebElement objAdminsLbl => _objDriver.FindElement(By.XPath(STR_ADMINS_LBL));
        private static IWebElement objSuppliersLbl => _objDriver.FindElement(By.XPath(STR_SUPPLIERS_LBL));
        private static IWebElement objCustomersLbl => _objDriver.FindElement(By.XPath(STR_CUSTOMERS_LBL));
        private static IWebElement objGuestsLbl => _objDriver.FindElement(By.XPath(STR_GUESTS_LBL));
        private static IWebElement objBookingsLbl => _objDriver.FindElement(By.XPath(STR_BOOKINGS_LBL));
        /*OBJECT DEFINITION TABLE*/
        private static IWebElement objEmptyTableLbl => _objDriver.FindElement(By.XPath(STR_EMPTY_TABLE));
        private static IWebElement objTableHeaderLbl => _objDriver.FindElement(By.XPath(STR_TABLE_HEADER));

        /*METHODS/FUNCTIONS*/

        //Email
        private IWebElement GetEmailField()
        {
            return objEmailTxt;
        }

        public static void fnEnterEmail(string pstrEmail)
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.Name(STR_EMAIL_TXT)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Name(STR_EMAIL_TXT)));
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
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LOGIN_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LOGIN_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LOGIN_BTN)));
            objLoginBtn.Click();
        }

        /*Hamburger Button*/
        public static void fnWaitHamburgerMenu()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.Id(STR_HAMBURGER_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_HAMBURGER_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.Id(STR_HAMBURGER_BTN)));
        }

        /*METHODS/FUNCTIONS DASHBOARD*/
        //Administators count
        public static IWebElement GetAdminsLbl()
        {
            return objAdminsLbl;
        }
        //Suppliers count
        public static IWebElement GetSuppliersLbl()
        {
            return objSuppliersLbl;
        }
        //Customers count
        public static IWebElement GetCustomersLbl()
        {
            return objCustomersLbl;
        }
        //Guests count
        public static IWebElement GetGuestsLbl()
        {
            return objGuestsLbl;
        }
        //Bookings count
        public static IWebElement GetBookingsLbl()
        {
            return objBookingsLbl;
        }
        //Click element
        public static void fnClickIWebElement(IWebElement pIWebElement)
        {
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(pIWebElement));
            pIWebElement.Click();
        }

        //Function get list of web elements
        public static List<IWebElement> GetListOfElements(string pstrCriteria)
        {
            List<IWebElement> lstElements = _objDriver.FindElements(By.XPath(pstrCriteria)).ToList<IWebElement>();
            return lstElements;
        }
        //*****Function to get specific element
        public static IWebElement GetElement(string pstrCriteria)
        {
            IWebElement objIWElement = _objDriver.FindElement(By.XPath(pstrCriteria));
            return objIWElement;
        }
        //Funtion to wait for table to load
        public static void fnWaitTable()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_TABLE_HEADER)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_TABLE_HEADER)));
        }
        public static void fnWaitElement(string psrtElement)
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(psrtElement)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(psrtElement)));
            //_driverWait.Until(ExpectedConditions.ElementToBeClickable(By.Id(psrtElement)));
        }

        public static string getTableHeader()
        {
            return objTableHeaderLbl.Text;
        }
        //Funtion to now if table is empty
        public static bool IsTableEmpty()
        {
            try
            {
                if (objEmptyTableLbl == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
