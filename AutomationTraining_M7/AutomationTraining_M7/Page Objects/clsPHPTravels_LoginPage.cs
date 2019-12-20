using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Reporting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;


namespace AutomationTraining_M7.Page_Objects
{
    class clsPHPTravels_LoginPage : BaseTest
    {
        /*ATTRIBUTES*/

        private static IWebDriver _objDriver;
        public static clsReportManager objRep = new clsReportManager();



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
        readonly static string STR_CHAT_FRAME = "chat-widget";
        readonly static string STR_CHAT_MAXIMIZEDWINDOW = "//div[@id='chat-widget-container' and contains(@style,'height: 652px')] ";
        readonly static string STR_CHAT_MINIMIZE_BTN = "//button[@class='e1mwfyk10 lc-4rgplc e1m5b1js0']";
        readonly static string STR_CHAT_HELPWINDOW = "livechat-eye-catcher";
        readonly static string STR_CHAT_HELPWINDOW_X = "//div[contains(text(),'×')]";

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


        //Selects a Menu and Submenu based on parameters passed
        public static void fnSelectMenuSubMenu(String pMenu, String pSubMenu)
        {

            clsDriver.fnWaitForElementToExist(By.XPath(pMenu));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(pMenu));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(pMenu));

            driver.FindElement(By.XPath(pMenu)).Click();

            clsDriver.fnWaitForElementToExist(By.XPath(pSubMenu));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(pSubMenu));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(pSubMenu));


            driver.FindElement(By.XPath(pSubMenu)).Click();
        }


        //Clicks on the element sent as parameter making sure it exists and visible
        public static void fnClick(string pHeader)
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



        //Minimize Chat Window
        public static void fnMinimizeChatWindowifPresent()
        {


            if (driver.FindElements(By.XPath(STR_CHAT_MAXIMIZEDWINDOW)).Count > 0)
            {

                driver.SwitchTo().Frame(driver.FindElement(By.Id(STR_CHAT_FRAME)));
                clsDriver.fnWaitForElementToExist(By.XPath(STR_CHAT_MINIMIZE_BTN));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_CHAT_MINIMIZE_BTN));
                clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_CHAT_MINIMIZE_BTN));
                driver.FindElement(By.XPath(STR_CHAT_MINIMIZE_BTN)).Click();
                driver.SwitchTo().ParentFrame();

            }



        }



        //Cloaw Help Window
        public static void fnCloseHelpWindowifPresent()
        {


            if (driver.FindElements(By.Id(STR_CHAT_HELPWINDOW)).Count > 0)
            {


                IWebElement web_Element_To_Be_Hovered = driver.FindElement(By.Id(STR_CHAT_HELPWINDOW));
                Actions action = new Actions(driver);
                action.MoveToElement(web_Element_To_Be_Hovered).Build().Perform();
                clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_CHAT_HELPWINDOW_X));
                driver.FindElement(By.XPath(STR_CHAT_HELPWINDOW_X)).Click();
               

            }



        }


        //Works with all of the Sorting Headers in each of the SubMenus

        public static void fnAccountsMenuSubMenusSorting(string pMenuSubmenuAcronym)
        {
            string status;

            try
            {
                fnClick(STR_FIRSTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(STR_FIRSTNAME_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_FIRSTNAME_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_FIRSTNAME_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_FirstNameSortingDesc_Test", status, $"{pMenuSubmenuAcronym}_FirstNameSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_FirstNameSortingDesc_Test", status, $"{pMenuSubmenuAcronym}_FirstNameSortingDesc_Test");
                Assert.Fail();
            }




            try
            {
                fnClick(STR_FIRSTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(STR_FIRSTNAME_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_FIRSTNAME_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_FIRSTNAME_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_FirstNameSortingAsc_Test", status, $"{pMenuSubmenuAcronym}_FirstNameSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_FirstNameSortingAsc_Test", status, $"{pMenuSubmenuAcronym}_FirstNameSortingAsc_Test");
                Assert.Fail();
            }







            try
            {
                fnClick(STR_LASTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(STR_LASTNAME_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LASTNAME_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_LASTNAME_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_LastNameSortingAsc_Test", status, $"{pMenuSubmenuAcronym}_LastNameSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_LastNameSortingAsc_Test", status, $"{pMenuSubmenuAcronym}_LastNameSortingAsc_Test");
                Assert.Fail();
            }




            try
            {
                fnClick(STR_LASTNAME_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(STR_LASTNAME_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LASTNAME_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_LASTNAME_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_LastNameSortingDesc_Test", status, $"{pMenuSubmenuAcronym}_LastNameSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_LastNameSortingDesc_Test", status, $"{pMenuSubmenuAcronym}_LastNameSortingDesc_Test");
                Assert.Fail();
            }



            try
            {
                fnClick(STR_EMAIL_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(STR_EMAIL_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_EMAIL_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_EMAIL_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_EmailSortingDesc_Test", status, $"{pMenuSubmenuAcronym}_EmailSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_EmailSortingDesc_Test", status, $"{pMenuSubmenuAcronym}_EmailSortingDesc_Test");
                Assert.Fail();
            }




            try
            {
                fnClick(STR_EMAIL_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(STR_EMAIL_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_EMAIL_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_EMAIL_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_EmailSortingAsc_Test", status, $"{pMenuSubmenuAcronym}_EmailSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_EmailSortingAsc_Test", status, $"{pMenuSubmenuAcronym}_EmailSortingAsc_Test");
                Assert.Fail();
            }





            try
            {
                fnClick(STR_ACTIVE_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(STR_ACTIVE_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_ACTIVE_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_ACTIVE_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_ActiveSortingAsc_Test", status, $"{pMenuSubmenuAcronym}_ActiveSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_ActiveSortingAsc_Test", status, $"{pMenuSubmenuAcronym}_ActiveSortingAsc_Test");
                Assert.Fail();
            }

            try
            {

                fnClick(STR_ACTIVE_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(STR_ACTIVE_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_ACTIVE_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_ACTIVE_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_ActiveSortingDesc_Test", status, $"{pMenuSubmenuAcronym}_ActiveSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_ActiveSortingDesc_Test", status, $"{pMenuSubmenuAcronym}_ActiveSortingDesc_Test");
                Assert.Fail();
            }



            try
            {
                fnClick(STR_LASTLOGIN_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(STR_LASTLOGIN_HEADER_DESC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LASTLOGIN_HEADER_DESC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_LASTLOGIN_HEADER_DESC)).Count > 0, "The Descending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_LastLoginSortingDesc_Test", status, $"{pMenuSubmenuAcronym}_LastLoginSortingDesc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_LastLoginSortingDesc_Test", status, $"{pMenuSubmenuAcronym}_LastLoginSortingDesc_Test");
                Assert.Fail();
            }


            try
            {
                fnClick(STR_LASTLOGIN_HEADER);
                clsDriver.fnWaitForElementToExist(By.XPath(STR_LASTLOGIN_HEADER_ASC));
                clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LASTLOGIN_HEADER_ASC));
                Assert.AreEqual(true, driver.FindElements(By.XPath(STR_LASTLOGIN_HEADER_ASC)).Count > 0, "The Ascending Sort did not work");
                status = "Passed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_LastLoginSortingAsc_Test", status, $"{pMenuSubmenuAcronym}_LastLoginSortingAsc_Test");
            }

            catch
            {
                status = "Failed";
                objRep.fnStepCaptureImage(objExtent, objTest, driver, $"{pMenuSubmenuAcronym}_LastLoginSortingAsc_Test", status, $"{pMenuSubmenuAcronym}_LastLoginSortingAsc_Test");
                Assert.Fail();
            }





        }



    }
}
