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
        public static IWebDriver objDriver;


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
        readonly static string STR_FIRSTNAME_HEADER_DESC = "//th[contains(text(),'↓ First Name')]";
        readonly static string STR_FIRSTNAME_HEADER_ASC = "//th[contains(text(),'↑ First Name')]";
        readonly static string STR_LASTNAME_HEADER = "//th[contains(text(),'Last Name')]";
        readonly static string STR_LASTNAME_HEADER_DESC = "//th[contains(text(),'↓ Last Name')]";
        readonly static string STR_LASTNAME_HEADER_ASC = "//th[contains(text(),'↑ Last Name')]";
        readonly static string STR_EMAIL_HEADER = "//th[contains(text(),'Email')]";
        readonly static string STR_EMAIL_HEADER_DESC = "//th[contains(text(),'↓ Email')]";
        readonly static string STR_EMAIL_HEADER_ASC = "//th[contains(text(),'↑ Email')]";
        readonly static string STR_ACTIVE_HEADER = "//th[contains(text(),'Active')]";
        readonly static string STR_ACTIVE_HEADER_DESC = "//th[contains(text(),'↓ Active')]";
        readonly static string STR_ACTIVE_HEADER_ASC = "//th[contains(text(),'↑ Active')]";
        readonly static string STR_LASTLOGIN_HEADER = "//th[contains(text(),'Last Login')]";
        readonly static string STR_LASTLOGIN_HEADER_DESC = "//th[contains(text(),'↓ Last Login')]";
        readonly static string STR_LASTLOGIN_HEADER_ASC = "//th[contains(text(),'↑ Last Login')]";


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
        private static IWebElement objPopUpBtn = driver.FindElement(By.XPath(STR_POPUP_BTN));
        private static IWebElement objChatLnk = driver.FindElement(By.XPath(STR_CHAT_LNK));
        private static IWebElement objMinChatBtn = driver.FindElement(By.XPath(STR_MIN_CHAT_BTN));
        public static IWebElement objFirstNHeader = driver.FindElement(By.XPath(STR_FIRSTNAME_HEADER));
        public static IWebElement objLastNHeader = driver.FindElement(By.XPath(STR_LASTNAME_HEADER));
        public static IWebElement objEmailHeader = driver.FindElement(By.XPath(STR_EMAIL_HEADER));
        public static IWebElement objActiveHeader = driver.FindElement(By.XPath(STR_ACTIVE_HEADER));
        public static IWebElement objLastLoginHeader = driver.FindElement(By.XPath(STR_LASTLOGIN_HEADER));
        


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

        //Close "Need Help?" Pop Up
        private IWebElement GetPopUpButton()
        {
            return objPopUpBtn;
        }

        public static void fnClosePopUp()
        {
            objPopUpBtn.Click();
        }

        // Minimize LiveChat
        private IWebElement GetChat()
        {
            return objChatLnk;
        }

        private IWebElement GetMinimizeButton()
        {
            return objMinChatBtn;
        }

        //Minimize LiveChat 
        public static void fnMinimizeLiveChat()
        {


            if (driver.FindElements(By.XPath(STR_CHAT_MAX_CHAT)).Count > 0)
            {
                driver.SwitchTo().Frame(driver.FindElement(By.Id(STR_CHAT_FRAME)));
                clsDriver.fnWaitForElementToExist(By.XPath(STR_MIN_CHAT_BTN));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_MIN_CHAT_BTN));
                clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_MIN_CHAT_BTN));
                driver.FindElement(By.XPath(STR_MIN_CHAT_BTN)).Click();
                driver.SwitchTo().ParentFrame();
            }
        }

        //Function for sorting asserts
        public static void fnTryCatchSort()
        {
            //try
            //{
            //    objFirstNHeader.Click();
            //    clsDriver.fnWaitForElementToExist(By.XPath(STR_FIRSTNAME_HEADER_DESC));
            //    clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_FIRSTNAME_HEADER_DESC));
            //    Assert.AreEqual(true, driver.FindElements(By.XPath(STR_FIRSTNAME_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
            //    status = "Passed";
            //    timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
            //    clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
            //}

            //catch
            //{
            //    status = "Failed";
            //    timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
            //    clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
            //    Assert.Fail();
            //}

            //try
            //{
            //    objFirstNHeader.Click();
            //    clsDriver.fnWaitForElementToExist(By.XPath(STR_LASTNAME_HEADER_DESC));
            //    clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LASTNAME_HEADER_DESC));
            //    Assert.AreEqual(true, driver.FindElements(By.XPath(STR_LASTNAME_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
            //    status = "Passed";
            //    timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
            //    clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
            //}

            //catch
            //{
            //    status = "Failed";
            //    timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
            //    clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
            //    Assert.Fail();
            //}

            //try
            //{
            //    objFirstNHeader.Click();
            //    clsDriver.fnWaitForElementToExist(By.XPath(STR_EMAIL_HEADER_DESC));
            //    clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_EMAIL_HEADER_DESC));
            //    Assert.AreEqual(true, driver.FindElements(By.XPath(STR_EMAIL_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
            //    status = "Passed";
            //    timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
            //    clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
            //}

            //catch
            //{
            //    status = "Failed";
            //    timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
            //    clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
            //    Assert.Fail();
            //}

            //try
            //{
            //    objFirstNHeader.Click();
            //    clsDriver.fnWaitForElementToExist(By.XPath(STR_ACTIVE_HEADER_DESC));
            //    clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_ACTIVE_HEADER_DESC));
            //    Assert.AreEqual(true, driver.FindElements(By.XPath(STR_ACTIVE_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
            //    status = "Passed";
            //    timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
            //    clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
            //}

            //catch
            //{
            //    status = "Failed";
            //    timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
            //    clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
            //    Assert.Fail();
            //}

            //try
            //{
            //    objFirstNHeader.Click();
            //    clsDriver.fnWaitForElementToExist(By.XPath(STR_LASTLOGIN_HEADER_DESC));
            //    clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LASTLOGIN_HEADER_DESC));
            //    Assert.AreEqual(true, driver.FindElements(By.XPath(STR_LASTLOGIN_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
            //    status = "Passed";
            //    timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
            //    clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
            //}

            //catch
            //{
            //    status = "Failed";
            //    timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
            //    clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
            //    Assert.Fail();
            //}
        }

        //Get Menus and Submenus
        /*
        public static void fnGetMenuInfoStep1(string pstrMenuOption, out IWebElement outMenuItem, out IList<IWebElement> outSubMenuList )
        {
            outMenuItem = null;
            outSubMenuList = null;
            IList<IWebElement> ElementList2 = driver.FindElements(By.XPath("//a[contains(text()," + pstrMenuOption + ")]"));
            if (ElementList2.Count > 1)
            {
                outMenuItem = ElementList2[0];
                outMenuItem.Click();
                wait.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@id='" + pstrMenuOption + "']//li//a")));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@id='" + pstrMenuOption + "']//li//a")));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//ul[@id='" + pstrMenuOption + "']//li//a")));
                outSubMenuList = driver.FindElements(By.XPath("//ul[@id='" + pstrMenuOption + "']//li//a"));
                outMenuItem.Click();                
            }
        }

        public static void  fnGetMenuSubmenu(string pstrMenuOption, ExtentReports pobjExtent, ExtentTest pobjTest, IWebDriver pobjDriver)
        {
            IWebElement m1 = null;
            IList<IWebElement> smlist1 = null;
            fnGetMenuInfoStep1(pstrMenuOption, out m1, out smlist1);
            IList<IWebElement> ElementList2 = driver.FindElements(By.XPath("//a[contains(text()," + pstrMenuOption + ")]"));
            if (ElementList2.Count > 1)
            {
                ElementList2[0].Click();
                wait.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@id='" + pstrMenuOption + "ACCOUNTS']//li//a")));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@id='" + pstrMenuOption + "ACCOUNTS']//li//a")));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//ul[@id='" + pstrMenuOption + "ACCOUNTS']//li//a")));
                IList<IWebElement> ElementList3 = driver.FindElements(By.XPath("//ul[@id='ACCOUNTS']//li//a"));
                for (int i = 0; i < ElementList3.Count; i++)
                {
                    string status;
                    DateTime date = DateTime.Now;
                    string timeDate = "";

                    //Adding a Switch to work on every page and verify asserts work
                    switch (i)
                        {
                            case 0:
                            wait.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            ElementList3[i].Click();
                            fnWaitHamburgerMenu();
                            fnMinimizeLiveChat();
                            Assert.AreEqual(true, driver.Title.Contains("Admins Management"), "The Submenu page did not load correctly.");

                            try
                            {
                                objFirstNHeader.Click();
                                clsDriver.fnWaitForElementToExist(By.XPath(STR_FIRSTNAME_HEADER_DESC));
                                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_FIRSTNAME_HEADER_DESC));
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_FIRSTNAME_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                //timeDate.substring("Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss"));
                                clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, "");
                            }

                            catch
                            {
                                status = "Failed";
                                //var timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
                                clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                objFirstNHeader.Click();
                                clsDriver.fnWaitForElementToExist(By.XPath(STR_LASTNAME_HEADER_DESC));
                                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LASTNAME_HEADER_DESC));
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_LASTNAME_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
                                clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
                                clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                objFirstNHeader.Click();
                                clsDriver.fnWaitForElementToExist(By.XPath(STR_EMAIL_HEADER_DESC));
                                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_EMAIL_HEADER_DESC));
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_EMAIL_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
                                clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
                                clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                objFirstNHeader.Click();
                                clsDriver.fnWaitForElementToExist(By.XPath(STR_ACTIVE_HEADER_DESC));
                                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_ACTIVE_HEADER_DESC));
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_ACTIVE_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
                                clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
                                clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }

                            try
                            {
                                objFirstNHeader.Click();
                                clsDriver.fnWaitForElementToExist(By.XPath(STR_LASTLOGIN_HEADER_DESC));
                                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LASTLOGIN_HEADER_DESC));
                                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_LASTLOGIN_HEADER_DESC)).Count > 0, "Information was sorted in descending way");
                                status = "Passed";
                                timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
                                clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, timeDate);
                            }

                            catch
                            {
                                status = "Failed";
                                timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
                                clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                            }




                            m1.Click();

                            break;

                            case 1:
                            wait.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            ElementList3[i].Click();
                            Assert.AreEqual(true, driver.Title.Contains("Suppliers Management"), "The Submenu page did not load correctly.");

                            break;

                            case 2:
                            wait.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            ElementList3[i].Click();
                            Assert.AreEqual(true, driver.Title.Contains("Customers Management"), "The Submenu page did not load correctly.");

                            break;

                            case 3:
                            wait.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            ElementList3[i].Click();
                            Assert.AreEqual(true, driver.Title.Contains("Admins Management"), "The Submenu page did not load correctly.");

                            break;

                            default:
                            
                                continue;
                        }

                }


            }
        }
    */
    }
}