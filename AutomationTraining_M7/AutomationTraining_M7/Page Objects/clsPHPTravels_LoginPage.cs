using AutomationTraining_M7.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;

namespace AutomationTraining_M7.Page_Objects
{
    class clsPHPTravels_LoginPage : BaseTest
    {
        //Attributes
        public static WebDriverWait _driverWait;
        private static IWebDriver _objDriver;
        //Locators
        readonly static string STR_EMAIL_TXT = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";
        readonly static string STR_ACCOUNTS_BTN = "//a[contains(text(),'Accounts')]";
        readonly static string STR_FIRSTNAME_HEADER = "//th[contains(text(),'First Name')]";
        readonly static string STR_LASTNAME_HEADER = "//th[contains(text(),'Last Name')]";
        readonly static string STR_EMAIL_HEADER = "//th[contains(text(),'Email')]";
        readonly static string STR_ACTIVE_HEADER = "//th[contains(text(),'Active')]";
        readonly static string STR_LASTLOGIN_HEADER = "//th[contains(text(),'Last Login')]";
        readonly static string STR_FIRSTNAME_HEADER_DESC = "//th[contains(text(),'↓ First Name')]";
        readonly static string STR_LASTNAME_HEADER_DESC = "//th[contains(text(),'↓ Last Name')]";
        readonly static string STR_EMAIL_HEADER_DESC = "//th[contains(text(),'↓ Email')]";
        readonly static string STR_ACTIVE_HEADER_DESC = "//th[contains(text(),'↓ Active')]";
        readonly static string STR_LASTLOGIN_HEADER_DESC = "//th[contains(text(),'↓ Last Login')]";
        //Constructors
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 60));
        }
        //Objects definition
        private static IWebElement objEmailTxt = driver.FindElement(By.Name(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt = driver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objLoginBtn = driver.FindElement(By.XPath(STR_LOGIN_BTN));
        public static IWebElement objFirstNameHeader;
        public static IWebElement objLastNameHeader;
        public static IWebElement objEmailHeader;
        public static IWebElement objActiveHeader;
        public static IWebElement objLastLoginHeader;
        public static IWebElement objAccountsBtn;
        public static IWebElement objSubMenuBtn;
        //Methods and Functions
        //Input Email
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
        //Input Password
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

        //Click Login Button
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
        //Hamburger Menu Button
        public static void fnWaitHamburgerMenu()
        {
            clsDriver.fnWaitForElementToExist(By.Id(STR_HAMBURGER_BTN));
            clsDriver.fnWaitForElementToBeVisible(By.Id(STR_HAMBURGER_BTN));
            clsDriver.fnWaitForElementToBeClickable(By.Id(STR_HAMBURGER_BTN));
        }
        //Click Accounts Menu
        private IWebElement GetButton()
        {
            return objAccountsBtn;
        }
        public static void fnClickAccounts()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ACCOUNTS_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ACCOUNTS_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_ACCOUNTS_BTN)));
            objAccountsBtn = _objDriver.FindElement(By.XPath(STR_ACCOUNTS_BTN));
            objAccountsBtn.Click();
        }
        public static void fnClickSubmenu(string SubMenu)
        {
            objSubMenuBtn = driver.FindElement(By.XPath(SubMenu));
            objSubMenuBtn.Click();   
        }
        //Account Pages
        private IWebElement FirstNameHeader()
        {
            return objFirstNameHeader;
        }
        public static void fnClickFirstNameHeader()
        {
            objFirstNameHeader = _objDriver.FindElement(By.XPath(STR_FIRSTNAME_HEADER));
            objFirstNameHeader.Click();
            clsDriver.fnWaitForElementToExist(By.XPath(STR_FIRSTNAME_HEADER_DESC));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_FIRSTNAME_HEADER_DESC));
        }
        private IWebElement LastNameHeader()
        {
            return objLastNameHeader;
        }
        public static void fnClickLastNameHeader()
        {
            objLastNameHeader = _objDriver.FindElement(By.XPath(STR_LASTNAME_HEADER));
            objLastNameHeader.Click();
            clsDriver.fnWaitForElementToExist(By.XPath(STR_LASTNAME_HEADER_DESC));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LASTNAME_HEADER_DESC));
        }
        private IWebElement GetEmailHeader()
        {
            return objEmailHeader;
        }
        public static void fnClickEmailHeader()
        {
            objEmailHeader = _objDriver.FindElement(By.XPath(STR_EMAIL_HEADER));
            objEmailHeader.Click();
            clsDriver.fnWaitForElementToExist(By.XPath(STR_EMAIL_HEADER_DESC));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_EMAIL_HEADER_DESC));

        }
        private IWebElement GetActiveHeader()
        {
            return objActiveHeader;
        }
        public static void fnClickActiveHeader()
        {
            objActiveHeader = _objDriver.FindElement(By.XPath(STR_ACTIVE_HEADER));
            objActiveHeader.Click();
            clsDriver.fnWaitForElementToExist(By.XPath(STR_ACTIVE_HEADER_DESC));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_ACTIVE_HEADER_DESC));
        }
        private IWebElement GetLastLoginHeader()
        {
            return objLastLoginHeader;
        }
        public static void fnClickLastLoginHeader()
        {
            objLastLoginHeader = _objDriver.FindElement(By.XPath(STR_LASTLOGIN_HEADER));
            objLastLoginHeader.Click();
            clsDriver.fnWaitForElementToExist(By.XPath(STR_LASTLOGIN_HEADER_DESC));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LASTLOGIN_HEADER_DESC));
        }
        public static void fnGetSubmenu(string pstrMenuOption)
        {
            IList<IWebElement> ElementList = driver.FindElements(By.XPath("//a[contains(text()," + pstrMenuOption.ToUpper() + ")]"));
            if (ElementList.Count > 0)
            {
                fnWaitHamburgerMenu();
                fnClickAccounts();
                IList<IWebElement> List = driver.FindElements(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li//a"));

                for (int i = 0; i < List.Count; i++)
                {
                    int listValue = i + 1;
                    string XPathValue = "//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + listValue.ToString() + "]//a[1]";

                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(XPathValue)));
                    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XPathValue)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(XPathValue)));
                    fnClickSubmenu(XPathValue);

                    string y = "Page did not load correctly.";
                    fnWaitHamburgerMenu();

                   switch (i)
                    {
                        case 0:
                            System.Threading.Thread.Sleep(3000);
                            Assert.AreEqual(true, driver.Title.Contains("Admins Management"), "Page did not load correctly.");
                            fnSort();
                            
                            break;

                        case 1:
                            System.Threading.Thread.Sleep(3000);
                            Assert.AreEqual(true, driver.Title.Contains("Suppliers Management"), "Page did not load correctly.");
                            fnSort();

                            break;

                        case 2:
                            System.Threading.Thread.Sleep(3000);
                            Assert.AreEqual(true, driver.Title.Contains("Customers Management"), "Page did not load correctly.");
                            fnSort();

                            break;

                        case 3:
                            System.Threading.Thread.Sleep(3000);
                            Assert.AreEqual(true, driver.Title.Contains("Guest Management"), "Page did not load correctly.");
                            fnSort();

                            break;

                        default:

                            continue;
                    }
                }

            }
        }
        public static void fnSort()
        {
            string sortstatus;
            try
            {
                fnClickFirstNameHeader();
                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_FIRSTNAME_HEADER_DESC)).Count > 0, "Sorted");
                sortstatus = "Pass";
            }
            catch
            {
                sortstatus = "Fail";
                Assert.Fail();
            }
            try
            {
                fnClickLastNameHeader();
                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_LASTNAME_HEADER_DESC)).Count > 0, "Sorted");
                sortstatus = "Pass";
            }
            catch
            {
                sortstatus = "Fail";
                Assert.Fail();
            }
            try
            {
                fnClickEmailHeader();
                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_EMAIL_HEADER_DESC)).Count > 0, "Sorted");
                sortstatus = "Pass";
            }
            catch
            {
                sortstatus = "Fail";
                Assert.Fail();
            }
            try
            {
                fnClickActiveHeader();
                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_ACTIVE_HEADER_DESC)).Count > 0, "Sorted");
                sortstatus = "Pass";
            }
            catch
            {
                sortstatus = "Fail";
                Assert.Fail();
            }
            try
            {
                fnClickLastLoginHeader();
                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_LASTLOGIN_HEADER_DESC)).Count > 0, "Sorted");
                sortstatus = "Pass";                
            }
            catch
            {
                sortstatus = "Fail";
                Assert.Fail();
            }
            fnClickAccounts();
        }
    }
}
