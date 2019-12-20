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
        private static string strMenuItem;
        private static string strSubMenuItem;

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_EMAIL_TXT = "email";        
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";
        readonly static string STR_SIDEBAR_MENU = "//a[@id='sidebarCollapse']";
        readonly static string STR_UPDATES_SUB = "//span[text()='Updates']";
        readonly static string STR_SIDEBAR_MENU_DASH = "//ul[@id='social-sidebar-menu']//*[text()='Dashboard']";
        readonly static string STR_LIVE_CHAT_POPUP = "//button[@class='e1mwfyk10 lc-4rgplc e1m5b1js0']";

        readonly static string STR_MENU_ITEM = $"//ul[@id='social-sidebar-menu']/li//a[contains(text(),'{strMenuItem}')]";
        readonly static string STR_SUBMENU_ITEM = $"//ul[@id='social-sidebar-menu']/li//a[contains(text(),'{strSubMenuItem}')]";

        readonly static string STR_ACCOUNTS_MENU = "//a[@href='#ACCOUNTS']";
        readonly static string STR_AC_ADMINS_SUBMENU = "//a[contains(text(), 'Admins')]";
        readonly static string STR_AC_SUPPLIERS_SUBMENU = "//a[contains(text(), 'Suppliers')]";
        readonly static string STR_AC_CUSTOMERS_SUBMENU = "//a[text()='Customers']";
        readonly static string STR_AC_GUESTCUSTOMERS_SUBMENU = "//a[contains(text(), 'GuestCustomers')]";

        readonly static string STR_FIRSTnAME_HEADER = "//th[contains(text(), 'First Name')]";
        readonly static string STR_LASTNAME_HEADER = "//th[contains(text(), 'Last Name')]";
        readonly static string STR_EMAIL_HEADER = "//th[contains(text(), 'Email')]";
        readonly static string STR_ACTIVE_HEADER = "//th[contains(text(), 'Active')]";
        readonly static string STR_LASTLOGIN_HEADER = "//th[contains(text(), 'Last Login')]";

        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt => _objDriver.FindElement(By.Name(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objForgotPassLnk => _objDriver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn => _objDriver.FindElement(By.XPath(STR_LOGIN_BTN));
        private static IWebElement objHamburuerBtn => _objDriver.FindElement(By.Id(STR_HAMBURGER_BTN));
        private static IWebElement objSidebarMenu => _objDriver.FindElement(By.XPath(STR_SIDEBAR_MENU));
        private static IWebElement objSidebarMenuDash => _objDriver.FindElement(By.XPath(STR_SIDEBAR_MENU_DASH));
        private static IWebElement objUpdateSubMenu => _objDriver.FindElement(By.XPath(STR_UPDATES_SUB));
        private static IWebElement objLiveChatPopUp => _objDriver.FindElement(By.XPath(STR_LIVE_CHAT_POPUP));

        private static IWebElement objMenuItem => _objDriver.FindElement(By.XPath(STR_MENU_ITEM));
        private static IWebElement objSubMenuItem => _objDriver.FindElement(By.XPath(STR_SUBMENU_ITEM));



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
            clsDriver.fnWaitForElementToExist(By.Name(STR_PASSWORD_TXT));
            clsDriver.fnWaitForElementToBeVisible(By.Name(STR_PASSWORD_TXT));
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

        /*Hamburger Button*/     
        public static void fnWaitHamburgerMenu()
        {
            clsDriver.fnWaitForElementToExist(By.Id(STR_HAMBURGER_BTN));
            clsDriver.fnWaitForElementToBeVisible(By.Id(STR_HAMBURGER_BTN));
            clsDriver.fnWaitForElementToBeClickable(By.Id(STR_HAMBURGER_BTN));

        }

        public static List<string> fnGetTotalsValuesTxt()
        {
            IList<IWebElement> objGetTotalsValuesTx = _objDriver.FindElements(By.XPath("//*[@class='serverHeader__statsList']"));
            List<string> strTotalValuesReport = new List<string>();

            foreach (var vList in objGetTotalsValuesTx)
            {
                strTotalValuesReport.Add(vList.Text);
                Console.WriteLine(vList.Text);                
            }

            return strTotalValuesReport;

        }
        //SideBar Menu
        private IWebElement GetSideBarMenu()
        {
             return objSidebarMenu;
            //return objHamburuerBtn;
        }

        public static void fnClickLSideBarMenu()
        {
            //objLiveChatPopUp.Click();
            if (!objSidebarMenuDash.Displayed)
            {                
                objSidebarMenu.Click();
             }

            clsDriver.fnWaitForElementToExist(By.XPath(STR_SIDEBAR_MENU_DASH));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_SIDEBAR_MENU_DASH));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_SIDEBAR_MENU_DASH));

            objSidebarMenuDash.Click();
            objUpdateSubMenu.Click();
            //objSidebarMenu.Click();          

            //clsDriver.fnWaitForElementToExist(By.XPath(STR_SIDEBAR_MENU_DASH));
            //clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_SIDEBAR_MENU_DASH));
            //clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_SIDEBAR_MENU_DASH));

            //objSidebarMenuDash.Click();

        }

        public void fnSelectMenuItem(string pstrMenuItem)
        {
            strMenuItem = pstrMenuItem;
            objMenuItem.Click();
        }
        public void fnSelectMenuItem(string pstrMenuItem, string pstrSubMenuItem)
        {
            strMenuItem = pstrMenuItem;
            strSubMenuItem = pstrSubMenuItem;
            objMenuItem.Click();
            objSubMenuItem.Click();

        }
    }
}