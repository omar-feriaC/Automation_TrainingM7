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
    class clsPHPTravels_AdminPage : BaseTest
    {
        // ATTRIBUTES
        public static WebDriverWait _driverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 40));
        private static IWebDriver _objDrivers;
        // LOCATORS DESCRIPTION
        readonly static string STR_MENUACCOUNT = "//a[@href='#ACCOUNTS']";
        readonly static string STR_SUBMENUADMINS = STR_MENUACCOUNT + "//a[text()='Admins']";
        readonly static string STR_SUBMENUSUPPLIERS = STR_MENUACCOUNT + "//a[text()='Suppliers']";
        readonly static string STR_SUBMENUCUSTOMERS = STR_MENUACCOUNT + "//a[text()='Customers']";
        readonly static string STR_SUBMENUGUESTC = STR_MENUACCOUNT + "//a[text()='GuestCustomers']";
        readonly static string STR_FIRSTNAME = "//th[text()= 'First Name']";
        readonly static string STR_LASTNAME = "//th[text()= 'Last Name']";
        readonly static string STR_EMAIL = "//th[text()= 'Email']";
        readonly static string STR_ACTIVE = "//th[text()= 'Active']";
        readonly static string STR_LASTLOGIN = "//th[text()= 'Last Login']";
        // Constructor
        public clsPHPTravels_AdminPage(IWebDriver pobjDriver)
        {
            _objDrivers = pobjDriver;
        }
        // OBJECT DEFINITION
        private static IWebElement objMenuAccounts => driver.FindElement(By.XPath(STR_MENUACCOUNT));
        private static IWebElement objFistName => driver.FindElement(By.XPath(STR_FIRSTNAME));
        private static IWebElement objLastName => driver.FindElement(By.XPath(STR_LASTNAME));
        private static IWebElement objEmail => driver.FindElement(By.XPath(STR_EMAIL));
        private static IWebElement objActive => driver.FindElement(By.XPath(STR_ACTIVE));
        private static IWebElement objLastLogin => driver.FindElement(By.XPath(STR_LASTLOGIN));
        // Get SideBar Menu Account & Sub Menus
        public static void fnSelectMenuItem(string pstrMenuItem, string pstrSubMenuItem)
        {
            string STR_MENU_ITEM = $"//ul[@id='social-sidebar-menu']//*[contains(text(), '{pstrMenuItem}')]";
            string STR_SUBMENU_ITEM = $"//ul[@id='social-sidebar-menu']/li//a[contains(text(),'{pstrSubMenuItem}')]";
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_MENU_ITEM)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_MENU_ITEM)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_MENU_ITEM)));
            driver.FindElement(By.XPath(STR_MENU_ITEM)).Click();
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENU_ITEM)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_SUBMENU_ITEM)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_SUBMENU_ITEM)));
            driver.FindElement(By.XPath(STR_SUBMENU_ITEM)).Click();
        }
        //Go through the Sub Menu's content and select them.
        public static void fnClickFistNameSort()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_FIRSTNAME));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_FIRSTNAME));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_FIRSTNAME));
            objFistName.Click();
        }
        public static void fnClickLastNameSort()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_LASTNAME));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LASTNAME));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_LASTNAME));
            objLastName.Click();
        }
        public static void fnClickEmail()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_EMAIL));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_EMAIL));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_EMAIL));
            objEmail.Click();
        }
        public static void fnClickActive()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_ACTIVE));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_ACTIVE));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_ACTIVE));
            objActive.Click();
        }
        public static void fnClickLastLogin()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_LASTLOGIN));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LASTLOGIN));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_LASTLOGIN));
            objLastLogin.Click();
        }
    }
}
