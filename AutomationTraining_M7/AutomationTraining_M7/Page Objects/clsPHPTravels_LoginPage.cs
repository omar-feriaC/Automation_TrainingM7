﻿using AutomationTraining_M7.Base_Files;
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
        readonly static string STR_CLOSECHAT_STR = "//button[@class='e1mwfyk10 lc-4rgplc e1m5b1js0']";
        readonly static string STR_OPENCHAT_STR = "//p[@class='lc-16fp8s8 eqd5v0k4']";
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
        private static IWebElement objHamburgerMenu => _objDriver.FindElement(By.XPath(STR_HAMBURGER_BTN));
        private static IWebElement objAccountsMenu => _objDriver.FindElement(By.XPath(STR_ACCOUNTS_MENU));
        private static IWebElement objLiveChatCloseBtn => _objDriver.FindElement(By.XPath(STR_CLOSECHAT_STR));
        private static IWebElement objLiveChatOpenBtn => _objDriver.FindElement(By.XPath(STR_OPENCHAT_STR));

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

        public static void fnClickHamburgerMenu()
        {
            objHamburgerMenu.Click();
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_SIDEMENU)));
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
            IList<IWebElement> objGetTotalsValuesTx = _objDriver.FindElements(By.XPath("//*[@class='serverHeader__statsList']"));
            List<string> strTotalValuesReport = new List<string>();

            foreach (var vList in objGetTotalsValuesTx)
            {
                strTotalValuesReport.Add(vList.Text);
                Console.WriteLine(vList.Text);
            }

            return strTotalValuesReport;

        }

        //ACCOUNTS SUBMENUS******************
        public static List<string> fnClickAccountsSubMenuTxt()
        {
            IList<IWebElement> objGetAccountsSubMenuTxt = _objDriver.FindElements(By.XPath("//ul[@id='ACCOUNTS']"));
            List<string> strAccountsSubMenu = new List<string>();

            foreach (var vList in objGetAccountsSubMenuTxt)
            {
                strAccountsSubMenu.Add(vList.Text);
                Console.WriteLine(vList.Text);
            }

            return strAccountsSubMenu;

        }
        //*********************ACCOUNTS SUBMENUS



        //LIVE CHAT OPEN AND CLOSE*********************
        public static IWebElement GetLiveChatOpenBtn()
        {
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_OPENCHAT_STR)));
            return objLiveChatOpenBtn;
        }
        public static void fnClickOpenLiveChat()
        {


            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_OPENCHAT_STR)));
            objLiveChatOpenBtn.Click();

        }
        public static IWebElement GetLiveChatCloseBtn()
        {

            return objLiveChatCloseBtn;
        }
        public static void fnClickCloseLiveChat()
        {
            

            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_CLOSECHAT_STR)));
            objLiveChatCloseBtn.Click();

        }
        //******************LIVE CHAT OPEN AND CLOSE

    }
}
