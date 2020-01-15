using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Reporting;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class clsPHPTravels_LoginPage : BaseTest
    {
        /*ATTRIBUTES*/
        public static WebDriverWait _driverWait;
        public static IWebDriver _objDriver;
        public static clsReportManager objRep = new clsReportManager();

        /*LOCATORS DESCRIPTION*/
        private static readonly string STR_EMAIL_TXT = "email";
        // readonly static string STR_EMAIL_TXT2 = "email";
        private static readonly string STR_PASSWORD_TXT = "password";
        private static readonly string STR_REMEMBERME_LNK = "///label[@class='checkbox']";
        //  readonly static string STRREMEMBERME_LNK2 = "//label[@class='checkbox']";
        // private static readonly string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        private static readonly string STR_LOGIN_BTN = "//span[text()='Login']";
        private static readonly string STR_HAMBURGER_BTN = "sidebarCollapse";
        private static readonly string STR_DASHBOARD = "//div[@class='serverHeader__stats']";
        private static readonly string STR_DASHBOARD_STATS = "//ul[@class='serverHeader__statsList']";     
        private static readonly string STR_MENU = "//a[@href='#ACCOUNTS']";
        private static readonly string STR_SUBMENUS = "//ul[@id='ACCOUNTS']//li//a";
        private static string STR_SUBMENUS_TOTAL;
        private static readonly string STR_COLUMNS = "//tr[@class='xcrud-th']//th[@data-order]";
        private static readonly string STR_ROW = "//tr[@class='xcrud-th']";
        private static readonly string STR_TABLE_TXT = "//div[@class='xcrud-list-container']";
        private static readonly string STR_TABLECONTENT_TXT = "//table[@class='xcrud-list table table-striped table-hover']";
        private readonly static string STR_FIRSTNAMECOLUMN_TXT = "//th[contains(text(),'First Name')]";
        private readonly static string STR_LASTNAMECOLUMN_TXT = "//th[contains(text(),'Last Name')]";
        private readonly static string STR_EMAILCOLUMN_TXT = "//th[contains(text(),'Email')]";
        private readonly static string STR_ACTIVECOLUMN_TXT = "//th[contains(text(),'Active')]";
        private readonly static string STR_LASTLOGINCOLUMN_TXT = "//th[contains(text(),'Last Login')]";
        //private readonly static string STR_FIRSTNAME_DESC_TXT = "//th[contains(text(),'↑ First Name')]";
        private readonly static string STR_FIRSTNAME_ASC_TXT = "//th[contains(text(),'↓ First Name')]";
        private readonly static string STR_LASTNAME_DESC_TXT = "//th[contains(text(),'↑ Last Name')]";
        //private readonly static string STR_LASTNAME_ASC_TXT = "//th[contains(text(),'↓ Last Name')]";
        //private readonly static string STR_EMAIL_DESC_TXT = "//th[contains(text(),'↑ Email')]";
        private readonly static string STR_EMAIL_ASC_TXT = "//th[contains(text(),'↓ Email')]";
        private readonly static string STR_ACTIVE_DESC_TXT = "//th[contains(text(),'↑ Active')]";
        //private readonly static string STR_ACTIVE_ASC_TXT = "//th[contains(text(),'↓ Active')]";
        //private readonly static string STR_LASTLOGIN_DESC_TXT = "//th[contains(text(),'↑ Last Login')]";
        private readonly static string STR_LASTLOGIN_ASC_TXT = "//th[contains(text(),'↓ Last Login')]";

        string status;            

        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt => _objDriver.FindElement(By.Name(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeLnk => _objDriver.FindElement(By.XPath(STR_REMEMBERME_LNK));
        //  private static IWebElement objForgotPassLnk => _objDriver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn => _objDriver.FindElement(By.XPath(STR_LOGIN_BTN));
        private static IWebElement objDashboardStats => _objDriver.FindElement(By.XPath(STR_DASHBOARD));
        private static IList<IWebElement> objTotals => _objDriver.FindElements(By.XPath(STR_DASHBOARD_STATS));
        private static IWebElement objMenu => _objDriver.FindElement(By.XPath(STR_MENU));
        private static IList<IWebElement> objSubMenus => _objDriver.FindElements(By.XPath(STR_SUBMENUS));
        private static IList<IWebElement> objColumns => _objDriver.FindElements(By.XPath(STR_COLUMNS));
        private static IWebElement objTableContainer => _objDriver.FindElement(By.XPath(STR_TABLE_TXT));
        private static IWebElement objTableContent => _objDriver.FindElement(By.XPath(STR_TABLECONTENT_TXT));
        private static IWebElement objFirstNameColumnAsc => _objDriver.FindElement(By.XPath(STR_FIRSTNAME_ASC_TXT));
        private static IWebElement objLastNameColumnDesc => _objDriver.FindElement(By.XPath(STR_LASTNAME_DESC_TXT));
        private static IWebElement objEmailColumnAsc => _objDriver.FindElement(By.XPath(STR_EMAIL_ASC_TXT));
        private static IWebElement objActiveColumnDesc => _objDriver.FindElement(By.XPath(STR_ACTIVE_DESC_TXT));
        private static IWebElement objLastLoginColumnAsc => _objDriver.FindElement(By.XPath(STR_LASTLOGIN_ASC_TXT));

        string[] column = { STR_FIRSTNAMECOLUMN_TXT, STR_LASTNAMECOLUMN_TXT, STR_EMAILCOLUMN_TXT, STR_ACTIVECOLUMN_TXT, STR_LASTLOGINCOLUMN_TXT };
        string[] sortedColumn = { STR_FIRSTNAME_ASC_TXT, STR_LASTNAME_DESC_TXT, STR_EMAIL_ASC_TXT, STR_ACTIVE_DESC_TXT, STR_LASTLOGIN_ASC_TXT };

        /*METHODS/FUNCTIONS*/

        public IList<IWebElement> GetColumns()
        {
            return objColumns;
        }

        public IList<IWebElement> GetSubMenus()
        {
            return objSubMenus;
        }

        public IWebElement GetMenu()
        {
            return objMenu;
        }

        //Dashboard Header Stats

        public IList<IWebElement> GetDashboardTotals()
        {
            return objTotals;
        }

        private IWebElement GetDashboardStats()
        {
            return objDashboardStats;
        }

        public void fnWaitDashboardStats()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_DASHBOARD));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_DASHBOARD));

        }

        //Email
        private IWebElement GetEmailField()
        {
            return objEmailTxt;
        }

        public void fnEnterEmail(string pstrEmail)
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

        public void fnEnterPassword(string pstrPass)
        {
            clsDriver.fnWaitForElementToExist(By.Name(STR_PASSWORD_TXT));
            clsDriver.fnWaitForElementToBeVisible(By.Name(STR_PASSWORD_TXT));
            objPasswordTxt.Clear();
            objPasswordTxt.SendKeys(pstrPass);
        }

        //Login Button
        private IWebElement GetLoginButton()
        {
            return objRememberMeLnk;
        }

        public void fnClickLoginButton()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_LOGIN_BTN));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LOGIN_BTN));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_LOGIN_BTN));

            objLoginBtn.Click();
        }

        /*Hamburger Button*/
        public void fnWaitHamburgerMenu()
        {
            clsDriver.fnWaitForElementToExist(By.Id(STR_HAMBURGER_BTN));
            clsDriver.fnWaitForElementToBeVisible(By.Id(STR_HAMBURGER_BTN));
            clsDriver.fnWaitForElementToBeClickable(By.Id(STR_HAMBURGER_BTN));
        }

        /*Menus validation*/
        public void fnMenuSelection()
        {
            int j = 0;
            int subMenuTotal = objSubMenus.Count - 1;

            STR_SUBMENUS_TOTAL = $"//ul[@id='ACCOUNTS']//li[position()={subMenuTotal}]";

            foreach (IWebElement i in objSubMenus)
            {
                fnWaitMenus();
                objMenu.Click();
                fnWaitSubMenus();
                objSubMenus.ElementAt(j).Click();
                fnSortColumns();
                j++;
            }
        }

        public void fnWaitMenus()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_MENU));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_MENU));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_MENU));
        }

        public void fnWaitSubMenus()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_SUBMENUS));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_SUBMENUS));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_SUBMENUS_TOTAL));
        }

        public void fnSortColumns()
        {
            for (int i = 0; i < objColumns.Count; i++)
            {
                fnValidateCurrentColumn(column[i], sortedColumn[i]);
            }
        }

        public void fnValidateCurrentColumn(string column, string sortedColumn)
        {
            try
            {
                fnClickColumn(column);
                fnColumnValidation();
                clsDriver.fnWaitForElementToExist(By.XPath(sortedColumn));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(sortedColumn));
                fnClickColumn(sortedColumn);
                fnColumnValidation();
                Assert.AreEqual(true, _objDriver.FindElements(By.XPath(sortedColumn)).Count > 0, "The sorting of columns is not working");
            }
            catch
            {
                Assert.Fail();
            }
        }

        public void fnColumnValidation()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_TABLE_TXT));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_TABLE_TXT));
            clsDriver.fnWaitForElementToExist(By.XPath(STR_TABLECONTENT_TXT));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_TABLECONTENT_TXT));
            clsDriver.fnWaitForElementToExist(By.XPath(STR_ROW));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_ROW));
            clsDriver.fnWaitForElementToExist(By.XPath(STR_COLUMNS));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_COLUMNS));
        }

        public void fnClickColumn(string column)
        {
            try
            {
                _objDriver.FindElement(By.XPath(column)).Click();
            }
            catch (StaleElementReferenceException e)
            {
                _objDriver.FindElement(By.XPath(column)).Click();
            }
        }
    }
}
