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

        static string STR_MENU_ITEM = $"(//ul[@id='social-sidebar-menu']/li//*[contains(text(),'{strMenuItem}')]//ancestor::li/a)[1]";
        static string STR_SUBMENU_ITEM = $"//ul[@id='social-sidebar-menu']/li//a[contains(text(),'{strSubMenuItem}')]";

        readonly static string STR_ACCOUNTS_SUBMENU_ITEMS = "//ul[@id='social-sidebar-menu']/li//*[contains(text(),'Accounts')]//ancestor::li/ul/li/a";
        readonly static string STR_FIRSTNAME_COL = "//table[@class='xcrud-list table table-striped table-hover']/tbody//following-sibling::tr/td[3]";
        readonly static string STR_FIRSTNAME_BTN = "//th[contains(text(),'First Name')]";
        readonly static string STR_LASTNAME_COL = "//table[@class='xcrud-list table table-striped table-hover']/tbody//following-sibling::tr/td[4]";
        readonly static string STR_LASTNAME_BTN = "//th[contains(text(),'Last Name')]";
        readonly static string STR_EMAIL_COL = "//table[@class='xcrud-list table table-striped table-hover']/tbody//following-sibling::tr/td[5]";
        readonly static string STR_EMAIL_BTN = "//th[contains(text(),'Email')]";
       


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
        private static IList<IWebElement> objFNameColLst => _objDriver.FindElements(By.XPath(STR_FIRSTNAME_COL));
        private static IWebElement objFNameBtn => _objDriver.FindElement(By.XPath(STR_FIRSTNAME_BTN));
        private static IList<IWebElement> objLNameColLst => _objDriver.FindElements(By.XPath(STR_LASTNAME_COL));
        private static IWebElement objLNameBtn => _objDriver.FindElement(By.XPath(STR_LASTNAME_BTN));
        private static IList<IWebElement> objEmailColLst => _objDriver.FindElements(By.XPath(STR_EMAIL_COL));
        private static IWebElement objEmailBtn => _objDriver.FindElement(By.XPath(STR_EMAIL_BTN));
        private static IList<IWebElement> objAccountsSubMenuLst => _objDriver.FindElements(By.XPath(STR_ACCOUNTS_SUBMENU_ITEMS));



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


       // Password
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


       // Login Button
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

        ///Print total Values
            
        public static List<string> fnGetTotalsValuesTxt()
        {
            IList<IWebElement> objGetTotalsValuesTx = _objDriver.FindElements(By.XPath("//*[@class='serverHeader__statsList']"));
            List<string> strTotalValuesReport = new List<string>();
            foreach (var vList in objGetTotalsValuesTx)
            {
                strTotalValuesReport.Add(vList.Text);
                Console.WriteLine(vList.Text);
                objRM.fnAddStepLog(objTest, vList.Text, "Pass");
            }
            return strTotalValuesReport;
        }


        //SideBar Menu

        public void fnSelectMenuItem(string pstrMenuItem)
        {
            strMenuItem = pstrMenuItem;
            STR_MENU_ITEM = $"(//ul[@id='social-sidebar-menu']/li//*[contains(text(),'{strMenuItem}')]//ancestor::li/a)[1]";
            objMenuItem.Click();
        }


        public void fnSelectMenuItem(string pstrMenuItem, string pstrSubMenuItem)
        {
            strMenuItem = pstrMenuItem;
            strSubMenuItem = pstrSubMenuItem;

            STR_MENU_ITEM = $"(//ul[@id='social-sidebar-menu']/li//*[contains(text(),'{strMenuItem}')]//ancestor::li/a)[1]";
            STR_SUBMENU_ITEM = $"//ul[@id='social-sidebar-menu']/li//a[contains(text(),'{strSubMenuItem}')]";

            objMenuItem.Click();

            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUBMENU_ITEM)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_SUBMENU_ITEM)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_SUBMENU_ITEM)));
            objSubMenuItem.Click();

        }

        //Submenu & Accoounts

        public IList<IWebElement> GetAccountsSubMenuItems()
        {
            return objAccountsSubMenuLst;
        }
        public List<string> GetFirstNameColumnList()
        {
            List<string> lstToString = new List<string>();
            foreach (var name in objFNameColLst)
            {
                lstToString.Add(name.Text);
            }
            return lstToString;
        }
        public void fnClickFirstNameButton()
        {
            objFNameBtn.Click();
        }
        public IWebElement GetFirstNameButton()
        {
            return objFNameBtn;
        }
        public List<string> GetLasttNameColumnList()
        {
            List<string> lstToString = new List<string>();
            foreach (var name in objLNameColLst)
            {
                lstToString.Add(name.Text);
            }
            return lstToString;
        }
        public void fnClickLastNameButton()
        {
            objLNameBtn.Click();
        }
        public IWebElement GetLastNameButton()
        {
            return objLNameBtn;
        }
        public List<string> GetEmailColumnList()
        {
            List<string> lstToString = new List<string>();
            foreach (var name in objEmailColLst)
            {
                lstToString.Add(name.Text);
            }
            return lstToString;
        }
        public void fnClickEmailButton()
        {
            objEmailBtn.Click();
        }
        public IWebElement GetEmailButton()
        {
            return objEmailBtn;
        }
        public List<string> fnSort(List<string> lstColumn, IWebElement objHeader)
        {
            IOrderedEnumerable<string> lstSorted;
            switch (objHeader.GetAttribute("data-order"))
            {
                case "asc":
                    lstSorted = from firstName in lstColumn
                                orderby firstName descending 
                                select firstName;
                    break;

                case "desc":
                    lstSorted = from firstName in lstColumn
                                orderby firstName ascending
                                select firstName;
                    break;
                default:
                    lstSorted = from firstName in lstColumn
                                orderby firstName descending
                                select firstName;
                    break;
            }

            return lstSorted.ToList<string>();
        }

        public void fnWaitFirstNameListChange()
        {
            List<string> lstCurrent = GetFirstNameColumnList();
            _driverWait.Until(condition => lstCurrent[0] != GetFirstNameColumnList()[0]);
        }
        public void fnWaitLastNameListChange()
        {
            List<string> lstCurrent = GetLasttNameColumnList();
            _driverWait.Until(condition => lstCurrent[2] != GetLasttNameColumnList()[2]);
        }
        public void fnWaitEmailNameListChange()
        {
            List<string> lstCurrent = GetEmailColumnList();
            _driverWait.Until(condition => lstCurrent[2] != GetEmailColumnList()[2]);
        }

        public void fnFNameSorting()
        {
            fnClickFirstNameButton();           
            fnWaitFirstNameListChange();

            fnClickFirstNameButton();
            fnWaitFirstNameListChange();
        }

        public void fnLNameSorting()
        {
            fnClickLastNameButton();
            fnWaitLastNameListChange();

            fnClickLastNameButton();
            fnWaitLastNameListChange();
        }

        public void fnEmailSorting()
        {
            fnClickEmailButton();
            fnWaitEmailNameListChange();
           
            fnClickEmailButton();
            fnWaitEmailNameListChange();
           
        }
    }
}


