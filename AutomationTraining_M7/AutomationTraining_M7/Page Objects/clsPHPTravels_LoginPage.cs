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
        readonly static string STR_EMAIL_TXT2 = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STRREMEMBERME_LNK = "//label[@class='checkbox']";
        readonly static string STRREMEMBERME_LNK2 = "//label[@class='checkbox']";
        readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";
        readonly static string STR_SIDEMENU = "//nav[@id='sidebar']";
        readonly static string STR_ACCOUNTS_MENU = "//a[@href='#ACCOUNTS']";
        readonly static string STR_CLOSECHAT = "//button[@class='e1mwfyk10 lc-4rgplc e1m5b1js0']";
        readonly static string STR_OPENCHAT = "//*[@class='lc-1r1l4b7 e5ibypu0']"; //*[@class='e1mwfyk10 lc-4rgplc e1m5b1js0']
        readonly static string STR_CHATTEXT = "//div[@class='lc-lpdesj e903lsu2 lc-r4kv7x-enter-done']";
        readonly static string STR_SUBMENU_ADMINS = "//ul/li/a[text()='Admins']";
        readonly static string STR_SUBMENU_CUSTOMERS = "//ul/li/a[text()='Customers']";
        readonly static string STR_SUBMENU_SUPPLIERS = "//ul/li/a[text()='Suppliers']";
        readonly static string STR_SUBMENU_GUESTCUSTOMERS = "//ul/li/a[text()='GuestCustomers']";

        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt => driver.FindElement(By.Name(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt => driver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeLnk => driver.FindElement(By.XPath(STRREMEMBERME_LNK));
        private static IWebElement objForgotPassLnk => driver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn => driver.FindElement(By.XPath(STR_LOGIN_BTN));
        private static IWebElement objSidebarMenu => _objDriver.FindElement(By.XPath(STR_SIDEMENU));
        private static IWebElement objHamburgerMenu => _objDriver.FindElement(By.Id(STR_HAMBURGER_BTN));
        private static IWebElement objAccountsMenu => _objDriver.FindElement(By.XPath(STR_ACCOUNTS_MENU));
        private static IWebElement objLiveChatCloseBtn => _objDriver.FindElement(By.XPath(STR_CLOSECHAT));
        private static IWebElement objLiveChatOpenBtn => _objDriver.FindElement(By.XPath(STR_OPENCHAT));
        private static IWebElement objLiveChatText => _objDriver.FindElement(By.XPath(STR_CHATTEXT));
        private static IWebElement objSubmenuAdmins => _objDriver.FindElement(By.XPath(STR_SUBMENU_ADMINS));
        private static IWebElement objSubMenuAdmins => _objDriver.FindElement(By.XPath(STR_SUBMENU_ADMINS));
        private static IWebElement objSubMenuSuppliers => _objDriver.FindElement(By.XPath(STR_SUBMENU_SUPPLIERS));
        private static IWebElement objSubmenuCustomers => _objDriver.FindElement(By.XPath(STR_SUBMENU_CUSTOMERS));
        private static IWebElement objSubmenuGuestCustomers => _objDriver.FindElement(By.XPath(STR_SUBMENU_GUESTCUSTOMERS));




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

        public static void fnClickHamburgerMenu()
        {
            
            objHamburgerMenu.Click();
            
        }
        //ACCOUNTS
        private IWebElement GetAccountsMenu()
        {

            return objAccountsMenu;
        }
        public static void fnClickAccountsMenu()
        {
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_ACCOUNTS_MENU)));
            objAccountsMenu.Click();

        }

        //Get Totals 
        public static List<string> fnGetTotalsValuesTxt()
        {
            IList<IWebElement> objGetTotalsValuesTx = _objDriver.FindElements(By.XPath("//ul[@class='serverHeader__statsList']//li//a"));
            List<string> strTotalValuesReport = new List<string>();

            foreach (var vList in objGetTotalsValuesTx)
            {
                strTotalValuesReport.Add(vList.Text);
                Console.WriteLine(vList.Text);
                vList.Click();
            }

            return strTotalValuesReport;

        }

        //ACCOUNTS SUBMENUS******************
        public static void fnClickSubMenus()
        {
            var AdminSubMenus = new[] { objSubMenuAdmins, objSubMenuSuppliers, objSubmenuCustomers, objSubmenuGuestCustomers };

        foreach (IWebElement AdminSubMenu in AdminSubMenus)
            {
                AdminSubMenu.Click();
                
            }
        }
    //*********************ACCOUNTS SUBMENUS



    //LIVE CHAT OPEN AND CLOSE*********************


    //public static IWebElement GetLiveChatOpenBtn()
    //{

    //    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_CHATTEXT)));

    //    return objLiveChatText;
    //}
    //public static void fnClickOpenLiveChat()
    //{



    //}
    //public static IWebElement GetLiveChatCloseBtn()
    //{
    //    //Linkify

    //    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_CHATTEXT)));
    //    return objLiveChatCloseBtn;
    //}
    //public static void fnClickCloseLiveChat()
    //{
    //    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_CLOSECHAT)));
    //    objLiveChatCloseBtn.Click();


    //}
    //******************LIVE CHAT OPEN AND CLOSE

}
}
