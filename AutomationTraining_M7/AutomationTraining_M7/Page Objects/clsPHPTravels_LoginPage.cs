using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomationTraining_M7.Page_Objects
{
    class clsPHPTravels_LoginPage : BaseTest
    {
        /*ATTRIBUTES*/
        public static WebDriverWait wait;
        private static IWebDriver objDriver;

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_EMAIL_TXT = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STR_LOGIN_BTN = "//span[contains(text(),'Login')]";
        //readonly static string STR_ACCOUNTS_LNK = "//a[contains(text(),'Accounts')]";
        readonly static string STR_SUB_ACCOUNTS_LNK = "//ul[@id='ACCOUNTS']//li";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";


        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            objDriver = pobjDriver;
            wait = new WebDriverWait(objDriver, new TimeSpan(0, 0, 60));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt = driver.FindElement(By.Name(STR_EMAIL_TXT)); 
        private static IWebElement objPasswordTxt = driver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objLoginBtn = driver.FindElement(By.XPath(STR_LOGIN_BTN));
        //private static IWebElement objAccountsLnk = driver.FindElement(By.XPath(STR_ACCOUNTS_LNK));
        //private static IWebElement objSubMenuAccounts = driver.FindElement(By.XPath(STR_SUB_ACCOUNTS_LNK));
        

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
        private IWebElement GetPassword()
        {
            return objPasswordTxt;
        }

        public static void fnEnterPassword(string pstrPassword)
        {
            clsDriver.fnWaitForElementToExist(By.Name(STR_PASSWORD_TXT));
            clsDriver.fnWaitForElementToBeVisible(By.Name(STR_PASSWORD_TXT));
            objPasswordTxt.Clear();
            objPasswordTxt.SendKeys(pstrPassword);
        }

        //Login Button
        private IWebElement GetLoginButton()
        {
            return objLoginBtn;
        }

        public static void fnClickLoginButton()
        {
            wait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LOGIN_BTN)));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LOGIN_BTN)));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LOGIN_BTN)));
            objLoginBtn.Click();
        }

        //Hamburger Button
        public static void fnWaitHamburgerMenu()
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id(STR_HAMBURGER_BTN)));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_HAMBURGER_BTN)));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(STR_HAMBURGER_BTN)));
        }

        //Get Menus
        public static void fnGetMenu(int pintingIndexNum, int pintIndexNumber)
        {
            IList<IWebElement> ElementList2 = driver.FindElements(By.XPath("//body[contains(@class,'pace-done')]/div[@class='wrapper']/nav[@id='sidebar']/div[@class='social-sidebar']/ul[@id='social-sidebar-menu']/li[" + pintingIndexNum + "]/a"));
            IList<IWebElement> ElementList3 = driver.FindElements(By.XPath("//ul[@id='ACCOUNTS']//li[" + pintIndexNumber + "]//a"));
        }

        /*
        //Get Submenus
        public static void fnGetSubmenu(string pstrIndexNumber)
        {
            IList<IWebElement> ElementList3 = driver.FindElements(By.XPath("//ul[@id='ACCOUNTS']//li[" + pstrIndexNumber + "]//a"));
        }
        
        private IWebElement GetAccountLink()
        {
            return objAccountsLnk;
        }

        public static void fnAccountLink()
        {

        }

        private IWebElement GetSubmenuAccounts()
        {
            return objSubMenuAccounts;
        }

        public static void fnSubmenuAccounts()
        {

        }*/

    }
}
