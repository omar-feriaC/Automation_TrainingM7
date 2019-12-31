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

namespace AutomationTraining_M7.Page_Objects
{
    class clsPHPTravels_LoginPage : BaseTest
    {
        /*ATTRIBUTES*/
        public static WebDriverWait wait;
        private static IWebDriver _objDriver;


        /*LOCATORS DESCRIPTION*/
        readonly static string STR_EMAIL_TXT = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STR_LOGIN_BTN = "//span[contains(text(),'Login')]";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";
        readonly static string STR_CHAT_FRAME = "chat-widget";
        readonly static string STR_POPUP_WINDOW = "livechat-eye-catcher";
        readonly static string STR_POPUP_BTN = "//div[contains(text(),'×')]";
        readonly static string STR_CHAT_LNK = "//div[@id='chat-widget-container']";
        readonly static string STR_MIN_CHAT_BTN = "//button[@class='e1mwfyk10 lc-4rgplc e1m5b1js0']";
        readonly static string STR_CHAT_MAX_CHAT = "//div[@id='chat-widget-container' and contains(@style,'height: 652px')] ";
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
        readonly static string STR_ACCOUNTS_BTN = "//a[contains(text(), 'Accounts')]";


        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            wait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 60));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt; 
        private static IWebElement objPasswordTxt; 
        private static IWebElement objLoginBtn; 
        private static IWebElement objPopUpBtn; 
        private static IWebElement objChatLnk; 
        public static IWebElement objHeader;
        public static IWebElement objFirstNHeader; 
        public static IWebElement objLastNHeader; 
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
            objEmailTxt = _objDriver.FindElement(By.Name(STR_EMAIL_TXT));
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
            objPasswordTxt = _objDriver.FindElement(By.Name(STR_PASSWORD_TXT));
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
            objLoginBtn = _objDriver.FindElement(By.XPath(STR_LOGIN_BTN));
            objLoginBtn.Click();
        }

        //Hamburger Button
        public static void fnWaitHamburgerMenu()
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id(STR_HAMBURGER_BTN)));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_HAMBURGER_BTN)));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(STR_HAMBURGER_BTN)));
        }

        //Close "Need Help?" Pop Up
        private IWebElement GetPopUpButton()
        {
            return objPopUpBtn;
        }

        public static void fnClosePopUp()
        {
            objPopUpBtn = _objDriver.FindElement(By.XPath(STR_POPUP_BTN));
            objPopUpBtn.Click();
        }

        // Minimize LiveChat
        private IWebElement GetChat()
        {
            return objChatLnk;
        }


        //Minimize LiveChat 
        public static void fnMinimizeLiveChat()
        {
            if (driver.FindElements(By.XPath(STR_CHAT_MAX_CHAT)).Count > 0)
            {
                driver.SwitchTo().Frame(driver.FindElement(By.XPath(STR_CHAT_FRAME)));
                clsDriver.fnWaitForElementToExist(By.XPath(STR_MIN_CHAT_BTN));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_MIN_CHAT_BTN));
                clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_MIN_CHAT_BTN));
                driver.FindElement(By.XPath(STR_MIN_CHAT_BTN)).Click();
                driver.SwitchTo().ParentFrame();
            }
        }

        //Function to Click the Accounts Meny
        private IWebElement GetButton()
        {
            return objAccountsBtn;
        }

        public static void fnClickAccounts()
        {
            objAccountsBtn = _objDriver.FindElement(By.XPath(STR_ACCOUNTS_BTN));
            clsDriver.fnWaitForElementToExist(By.XPath(STR_ACCOUNTS_BTN));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_ACCOUNTS_BTN));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_ACCOUNTS_BTN));
            objAccountsBtn.Click();
        }

        //Function to click the Submenu option
        /*private IWebElement GetSubMenuButton()
        {
            return objSubMenuBtn;
        }
        public static void fnClickSubmenu(string pXPathValue)
        {
            var StringXPath = pXPathValue;
            objSubMenuBtn = StringXPath;
            objSubMenuBtn = _objDriver.FindElement(By.XPath("setAttribute("pXPathValue));
            driver.findElement(By.xpath("//input[@id='invoice_supplier_id'])).setAttribute("value", "your value")
        }*/

        //Functions used for clicking the headers on the Accounts Page's subpages
        private IWebElement GetFirstNameH()
        {
            return objFirstNHeader;
        }

        public static void fnClickFirstNameH()
        {
            objFirstNHeader = _objDriver.FindElement(By.XPath(STR_FIRSTNAME_HEADER));
            objFirstNHeader.Click();
            clsDriver.fnWaitForElementToExist(By.XPath(STR_FIRSTNAME_HEADER_DESC));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_FIRSTNAME_HEADER_DESC));
        }

        private IWebElement GetLastNameH()
        {
            return objLastNHeader;
        }

        public static void fnClickLastNameH()
        {
            objLastNHeader = _objDriver.FindElement(By.XPath(STR_LASTNAME_HEADER));
            objLastNHeader.Click();
            clsDriver.fnWaitForElementToExist(By.XPath(STR_LASTNAME_HEADER_DESC));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LASTNAME_HEADER_DESC));
        }

        private IWebElement GetEmailH()
        {
            return objEmailHeader;
        }

        public static void fnClickEmailH()
        {
            objEmailHeader = _objDriver.FindElement(By.XPath(STR_EMAIL_HEADER));
            objEmailHeader.Click();
            clsDriver.fnWaitForElementToExist(By.XPath(STR_EMAIL_HEADER_DESC));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_EMAIL_HEADER_DESC));
        }

        private IWebElement GetActiveH()
        {
            return objActiveHeader;
        }

        public static void fnClickActiveH()
        {
            objActiveHeader = _objDriver.FindElement(By.XPath(STR_ACTIVE_HEADER));
            objActiveHeader.Click();
            clsDriver.fnWaitForElementToExist(By.XPath(STR_ACTIVE_HEADER_DESC));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_ACTIVE_HEADER_DESC));
        }

        private IWebElement GetLastLoginH()
        {
            return objLastLoginHeader;
        }

        public static void fnClickLastLoginH()
        {
            objLastLoginHeader = _objDriver.FindElement(By.XPath(STR_LASTLOGIN_HEADER));
            objLastLoginHeader.Click();
            clsDriver.fnWaitForElementToExist(By.XPath(STR_LASTLOGIN_HEADER_DESC));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LASTLOGIN_HEADER_DESC));
        }



        //Function for sorting asserts
        public static void fnTryCatchSort(string pXPath)
        {
            try
            {
                objHeader.Click();
                clsDriver.fnWaitForElementToExist(By.XPath(STR_FIRSTNAME_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_FIRSTNAME_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_FIRSTNAME_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                //clsReportManager.fnStepCaptureImage(objExtent, objTest, objDriver, "Information is sorted correctly", status, timeDate);
            }

            catch
            {
                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                Assert.Fail();
            }
        }

        //Get Menus and Submenus
        public static void  fnGetMenuSubmenu(string pstrMenuOption)
        {
            IList<IWebElement> ElementList2 = driver.FindElements(By.XPath("//a[contains(text()," + pstrMenuOption.ToUpper() + ")]"));
            if (ElementList2.Count > 0)
            {
                fnWaitHamburgerMenu();
                fnClickAccounts();
                IList<IWebElement> ElementList3 = driver.FindElements(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li//a"));
                //ElementList2[0].Click();
                for (int i = 0; i < ElementList3.Count; i++)
                {
                    string status;
                    int listValue = i + 1;
                    string XPathValue = "//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + listValue.ToString() + "]//a[1]";

                    //Adding a Switch to work on every page and verify asserts work
                    wait.Until(ExpectedConditions.ElementExists(By.XPath(XPathValue)));
                    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XPathValue)));
                    wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(XPathValue)));
                    //fnClickSubmenu(XPathValue);
                    ElementList3[i].Click();
                    string y = "The Submenu page did not load correctly.";
                    fnWaitHamburgerMenu();
                    //fnMinimizeLiveChat();

                    switch (i)
                        {
                            case 0:
                            Assert.AreEqual(true, driver.Title.Contains("Admins Management"), "The Submenu page did not load correctly.");

                            try
                            {
                                fnClickFirstNameH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_FIRSTNAME_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(objExtent, objTest, objDriver, "Information is sorted correctly", status, "");
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                fnClickLastNameH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_LASTNAME_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                fnClickEmailH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_EMAIL_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(objExtent, objTest, _objDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                fnClickActiveH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_ACTIVE_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                fnClickLastLoginH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_LASTLOGIN_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            fnClickAccounts();

                            break;

                            case 1:
                            Assert.AreEqual(true, driver.Title.Contains("Suppliers Management"), "The Submenu page did not load correctly.");

                            try
                            {
                                fnClickFirstNameH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_FIRSTNAME_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(objExtent, objTest, objDriver, "Information is sorted correctly", status, "");
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                fnClickLastNameH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_LASTNAME_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                fnClickEmailH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_EMAIL_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(objExtent, objTest, _objDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                fnClickActiveH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_ACTIVE_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                fnClickLastLoginH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_LASTLOGIN_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }


                            fnClickAccounts();

                            break;

                            case 2:
                            Assert.AreEqual(true, driver.Title.Contains("Customers Management"), "The Submenu page did not load correctly.");

                            try
                            {
                                fnClickFirstNameH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_FIRSTNAME_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(objExtent, objTest, objDriver, "Information is sorted correctly", status, "");
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                fnClickLastNameH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_LASTNAME_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                fnClickEmailH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_EMAIL_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(objExtent, objTest, _objDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                fnClickActiveH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_ACTIVE_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                fnClickLastLoginH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_LASTLOGIN_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }


                            fnClickAccounts();

                            break;

                            case 3:
                            Assert.AreEqual(true, driver.Title.Contains("Guest Management"), "The Submenu page did not load correctly.");

                            try
                            {
                                fnClickFirstNameH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_FIRSTNAME_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(objExtent, objTest, objDriver, "Information is sorted correctly", status, "");
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                fnClickLastNameH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_LASTNAME_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                fnClickEmailH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_EMAIL_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(objExtent, objTest, _objDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                fnClickActiveH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_ACTIVE_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                fnClickLastLoginH();
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_LASTLOGIN_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }


                            fnClickAccounts();

                            break;

                            default:
                            
                                continue;
                        }

                }


            }
        }
    
    }
}