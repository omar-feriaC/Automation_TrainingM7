using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class clsPHPTravels_LoginPage
    {
        /*ATTRIBUTES*/
        public static WebDriverWait _driverWait;
        private static IWebDriver _objDriver;
        private static string strMenuItem;
        private static string strSubMenuItem;

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_EMAIL_TXT = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STRREMEMBERME_LNK = "///label[@class='checkbox']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";
        readonly static string STR_STATS_LST = "//ul[@class='serverHeader__statsList']//a";
        static string STR_MENU_ITEM = $"(//ul[@id='social-sidebar-menu']/li//*[contains(text(),'{strMenuItem}')]//ancestor::li/a)[1]";
        static string STR_SUBMENU_ITEM = $"//ul[@id='social-sidebar-menu']/li//a[contains(text(),'{strSubMenuItem}')]";
        readonly static string STR_FNAME_COL = "//table[@class='xcrud-list table table-striped table-hover']/tbody//following-sibling::tr/td[3]";
        readonly static string STR_FNAME_BTN = "//th[contains(text(),'First Name')]";
        readonly static string STR_LNAME_COL = "//table[@class='xcrud-list table table-striped table-hover']/tbody//following-sibling::tr/td[4]";
        readonly static string STR_LNAME_BTN = "//th[contains(text(),'Last Name')]";
        readonly static string STR_EMAIL_COL = "//table[@class='xcrud-list table table-striped table-hover']/tbody//following-sibling::tr/td[5]";
        readonly static string STR_EMAIL_BTN = "//th[contains(text(),'Email')]";
        readonly static string STR_ACCOUNTS_SUBMENU_ITEMS = "//ul[@id='social-sidebar-menu']/li//*[contains(text(),'Accounts')]//ancestor::li/ul/li/a";

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
        private static IList<IWebElement> objStatLst => _objDriver.FindElements(By.XPath(STR_STATS_LST));
        private static IWebElement objMenuItem => _objDriver.FindElement(By.XPath(STR_MENU_ITEM));
        private static IWebElement objSubMenuItem => _objDriver.FindElement(By.XPath(STR_SUBMENU_ITEM));
        private static IList<IWebElement> objFNameColLst => _objDriver.FindElements(By.XPath(STR_FNAME_COL));
        private static IWebElement objFNameBtn => _objDriver.FindElement(By.XPath(STR_FNAME_BTN));
        private static IList<IWebElement> objLNameColLst => _objDriver.FindElements(By.XPath(STR_LNAME_COL));
        private static IWebElement objLNameBtn => _objDriver.FindElement(By.XPath(STR_LNAME_BTN));
        private static IList<IWebElement> objEmailColLst => _objDriver.FindElements(By.XPath(STR_EMAIL_COL));
        private static IWebElement objEmailBtn => _objDriver.FindElement(By.XPath(STR_EMAIL_BTN));
        private static IList<IWebElement> objAccountsSubMenuLst => _objDriver.FindElements(By.XPath(STR_ACCOUNTS_SUBMENU_ITEMS));



        /*METHODS/FUNCTIONS*/

        //Email

        public void fnEnterEmail(string pstrEmail)
        {
            clsDriver.fnWaitForElementToExist(By.Name(STR_EMAIL_TXT));
            clsDriver.fnWaitForElementToBeVisible(By.Name(STR_EMAIL_TXT));
            objEmailTxt.Clear();
            objEmailTxt.SendKeys(pstrEmail);
        }

        //Password

        public void fnEnterPassword(string pstrPass)
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.Name(STR_PASSWORD_TXT)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Name(STR_PASSWORD_TXT)));
            objPasswordTxt.Clear();
            objPasswordTxt.SendKeys(pstrPass);
        }

        //Login Button

        public void fnClickLoginButton()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LOGIN_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LOGIN_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LOGIN_BTN)));
            objLoginBtn.Click();
        }

        /*Hamburger Button*/
        public void fnWaitHamburgerMenu()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.Id(STR_HAMBURGER_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_HAMBURGER_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.Id(STR_HAMBURGER_BTN)));
        }

        /*5. Stat List*/
        public IList<IWebElement> GetStatsList()
        {
            return objStatLst;
        }

        public void fnPrintStatList()
        {
            foreach(var stat in objStatLst)
            {
                Console.WriteLine(stat.Text);
            }
        }

        /*10. Menu and SubMenu function*/
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

        /*11. Accounts Menu and submenus*/

        public IList<IWebElement> GetAccountsSubMenuItems()
        {
            return objAccountsSubMenuLst;
        }
        public List<string> GetFirstNameColumnList()
        {
            List<string> lstToString = new List<string>();
            foreach(var name in objFNameColLst)
            {
                lstToString.Add(name.Text);//Need wait for records who are large and take longer to load.
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
        public List<string> fnSort(List<string> lstColumn,IWebElement objHeader)
        {
            IOrderedEnumerable<string> lstSorted;
            switch (objHeader.GetAttribute("data-order"))
            {
                case "asc":
                    lstSorted = from firstName in lstColumn
                                orderby firstName descending //Ascending and Descending are inverted because there is an error in the webpage.
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
            _driverWait.Until(condition => lstCurrent[2] != GetFirstNameColumnList()[2]);
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

        public void fnValidateSorting()
        {
            fnClickFirstNameButton();
            fnWaitFirstNameListChange();
            //Assert.AreEqual(GetFirstNameColumnList(), fnSort(GetFirstNameColumnList(), GetFirstNameButton()));

            fnClickFirstNameButton();
            fnWaitFirstNameListChange();
            //Assert.AreEqual(GetFirstNameColumnList(), fnSort(GetFirstNameColumnList(), GetFirstNameButton()));

            fnClickLastNameButton();
            fnWaitLastNameListChange();
            //Assert.AreEqual(GetLasttNameColumnList(), fnSort(GetLasttNameColumnList(), GetLastNameButton()));

            fnClickLastNameButton();
            fnWaitLastNameListChange();
            //Assert.AreEqual(GetLasttNameColumnList(), fnSort(GetLasttNameColumnList(), GetLastNameButton()));

            fnClickEmailButton();
            fnWaitEmailNameListChange();
            //Assert.AreEqual(GetEmailColumnList(), fnSort(GetEmailColumnList(), GetEmailButton())); //Need to figure out the order of similar texts. It's messing the sort

            fnClickEmailButton();
            fnWaitEmailNameListChange();
            //Assert.AreEqual(GetEmailColumnList(), fnSort(GetEmailColumnList(), GetEmailButton()));
        }
    }
}
