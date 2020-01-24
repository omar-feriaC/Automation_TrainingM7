using AutomationTraining_M7.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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




        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 60));
        }

        /*OBJECT DEFINITION*/
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

        //Click Accounts Menu
        private IWebElement GetButton()
        {
            return objAccountsBtn;
        }

        public static void fnClickAccounts()
        {
            objAccountsBtn = _objDriver.FindElement(By.XPath(STR_ACCOUNTS_BTN));
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ACCOUNTS_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ACCOUNTS_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath (STR_ACCOUNTS_BTN)));
            objAccountsBtn.Click();
        }

        public static void fnClickSubmenu(string SubMenu)
        {
            objSubMenuBtn = driver.FindElement(By.XPath(SubMenu));
            objSubMenuBtn.Click();
        }

        //Account Subpages
        private IWebElement FirstNameHeader()
        {
            return objFirstNameHeader;
        }

        public static void fnClickFirstNameHeader()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_FIRSTNAME_HEADER_DESC)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_FIRSTNAME_HEADER_DESC)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_FIRSTNAME_HEADER_DESC)));
            objFirstNameHeader = _objDriver.FindElement(By.XPath(STR_FIRSTNAME_HEADER));
            objFirstNameHeader.Click();
        }

        private IWebElement LastNameHeader()
        {
            return objLastNameHeader;
        }

        public static void fnClickLastNameHeader()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_LASTNAME_HEADER_DESC));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LASTNAME_HEADER_DESC));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_LASTNAME_HEADER_DESC));
            objLastNameHeader = _objDriver.FindElement(By.XPath(STR_LASTNAME_HEADER));
            objLastNameHeader.Click();
            

        }

        private IWebElement GetEmailHeader()
        {
            return objEmailHeader;
        }

        public static void fnClickEmailHeader()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_EMAIL_HEADER_DESC));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_EMAIL_HEADER_DESC));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_EMAIL_HEADER_DESC));
            objEmailHeader = _objDriver.FindElement(By.XPath(STR_EMAIL_HEADER));
            objEmailHeader.Click();
            
        }

        private IWebElement GetActiveHeader()
        {
            return objActiveHeader;
        }

        public static void fnClickActiveHeader()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_ACTIVE_HEADER_DESC));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_ACTIVE_HEADER_DESC));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_ACTIVE_HEADER_DESC));
            objActiveHeader = _objDriver.FindElement(By.XPath(STR_ACTIVE_HEADER));
            objActiveHeader.Click();
            
        }

        private IWebElement GetLastLoginHeader()
        {
            return objLastLoginHeader;
        }

        public static void fnClickLastLoginHeader()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_LASTLOGIN_HEADER_DESC));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LASTLOGIN_HEADER_DESC));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_LASTLOGIN_HEADER_DESC));
            objLastLoginHeader = _objDriver.FindElement(By.XPath(STR_LASTLOGIN_HEADER));
            objLastLoginHeader.Click();
            
        }

        public static void fnGetMenuSubmenu(string pstrMenuOption)
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
                            Assert.AreEqual(true, driver.Title.Contains("Admins Management"), "Page did not load correctly.");
                            fnSort();


                            break;

                        case 1:
                            Assert.AreEqual(true, driver.Title.Contains("Suppliers Management"), "Page did not load correctly.");
                            fnSort();

                            break;

                        case 2:
                            Assert.AreEqual(true, driver.Title.Contains("Customers Management"), "Page did not load correctly.");
                            fnSort();

                            break;

                        case 3:
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
