using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;


namespace AutomationTraining_M7.Page_Objects
{
    class clsPHPTravels_LoginPage : BaseTest
    {
        /*ATTRIBUTES*/
      
        private static IWebDriver _objDriver;

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_EMAIL_TXT = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";
        public string STR_ACCOUNTS_MENU = "//a[@href='#ACCOUNTS']";
        public string STR_ADMINS_SUBMENU = "//a[contains(text(),'Admins')]";
        public string STR_SUPPLIERS_SUBMENU = "//a[contains(text(),'Suppliers')]";
        public string STR_CUSTOMERS_SUBMENU = "//a[text()='Customers']";
        public string STR_GUESTCUSTOMERS_SUBMENU = "//a[contains(text(),'GuestCustomers')]"; 
        public string STR_FIRSTNAME_HEADER = "//th[contains(text(),'First Name')]";
        public string STR_LASTNAME_HEADER = "//th[contains(text(),'Last Name')]";
        public string STR_EMAIL_HEADER = "//th[contains(text(),'Email')]";
        public string STR_ACTIVE_HEADER = "//th[contains(text(),'Active')]";
        public string STR_LASTLOGIN_HEADER = "//th[contains(text(),'Last Login')]";

        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
           
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt = driver.FindElement(By.Name(STR_EMAIL_TXT)); 
        private static IWebElement objPasswordTxt = driver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objLoginBtn = driver.FindElement(By.XPath(STR_LOGIN_BTN));
    

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



        public static void fnSelectMenuSubMenu(String pMenu, String pSubMenu)
        {

            clsDriver.fnWaitForElementToExist(By.XPath(pMenu));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(pMenu));
          

            driver.FindElement(By.XPath(pMenu)).Click();

            clsDriver.fnWaitForElementToExist(By.XPath(pSubMenu));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(pSubMenu));
           


            driver.FindElement(By.XPath(pSubMenu)).Click();
        }


        public static void fnSorting(string pHeader)
        {

            try
            {

                clsDriver.fnWaitForElementToExist(By.XPath(pHeader));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(pHeader));
              
                driver.FindElement(By.XPath(pHeader)).Click();
            }

            catch (StaleElementReferenceException)
            {
                clsDriver.fnWaitForElementToExist(By.XPath(pHeader));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(pHeader));
                
                driver.FindElement(By.XPath(pHeader)).Click();
            }


        }



    }
}
