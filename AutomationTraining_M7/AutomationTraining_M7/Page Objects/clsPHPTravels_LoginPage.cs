using AutomationTraining_M7.Base_Files;
using NUnit.Framework;
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
        public static WebDriverWait _driverWait;
        private static IWebDriver _objDriver;

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_CHAT_WID = "//p[text()='Chat now']";
        readonly static string STR_MINIMIZECHAT_BTN = "//button[class='e1mwfyk10 lc-4rgplc e1m5b1js0']";
        readonly static string STR_EMAIL_TXT = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STRREMEMBERME_LNK = "//input[@value='remember-me']";
        readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";
        readonly static string STR_TOTALADMINS_TXT = "//a[text()=' Total Admins ']";
        readonly static string STR_TOTALSUPPLIERS_TXT = "//a[text()=' Total Suppliers ']";
        readonly static string STR_TOTALCUSTOMERS_TXT = "//a[text()=' Total Customers ']";
        readonly static string STR_TOTALGUESTS_TXT = "//a[text()=' Total Guests ']";
        readonly static string STR_TOTALBOOKINGS_TXT = "//a[text()=' Total Bookings ']";

        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objChatWidget => _objDriver.FindElement(By.XPath(STR_CHAT_WID));
        private static IWebElement objMinimizeChat => _objDriver.FindElement(By.XPath(STR_MINIMIZECHAT_BTN));
        private static IWebElement objEmailTxt => _objDriver.FindElement(By.Name(STR_EMAIL_TXT)); 
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeLnk => _objDriver.FindElement(By.XPath(STRREMEMBERME_LNK));
        private static IWebElement objForgotPassLnk => _objDriver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn => _objDriver.FindElement(By.XPath(STR_LOGIN_BTN));
        private static IWebElement objTotAdminTxt => _objDriver.FindElement(By.XPath(STR_TOTALADMINS_TXT));
        private static IWebElement objTotSuppTxt => _objDriver.FindElement(By.XPath(STR_TOTALSUPPLIERS_TXT));
        private static IWebElement objTotCustomerTxt => _objDriver.FindElement(By.XPath(STR_TOTALCUSTOMERS_TXT));
        private static IWebElement objTotGuestTxt => _objDriver.FindElement(By.XPath(STR_TOTALGUESTS_TXT));
        private static IWebElement objTotBookTxt => _objDriver.FindElement(By.XPath(STR_TOTALBOOKINGS_TXT));


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
            _driverWait.Until(ExpectedConditions.ElementExists(By.Name(STR_PASSWORD_TXT)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Name(STR_PASSWORD_TXT)));
            objPasswordTxt.Clear();
            objPasswordTxt.SendKeys(pstrPass);
        }

        //Login Button
        private IWebElement GetLoginButton()
        {
            return objRememberMeLnk;
        }

        public static void fnClickLoginButton()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='Login']")));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Login']")));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Login']")));
            objLoginBtn.Click();
        }

        /*Hamburger Button*/
        public static void fnWaitHamburgerMenu()
        {
            
            _driverWait.Until(ExpectedConditions.ElementExists(By.Id(STR_HAMBURGER_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_HAMBURGER_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.Id(STR_HAMBURGER_BTN)));
        }

        //Print the stats of the page
        public static void fnPrintStats()
        {
            Console.WriteLine(objTotAdminTxt.Text);
            objRM.fnAddStepLog(objTest, objTotAdminTxt.Text, "Pass");
            Console.WriteLine("");
            Console.WriteLine(objTotSuppTxt.Text);
            objRM.fnAddStepLog(objTest, objTotSuppTxt.Text, "Pass");
            Console.WriteLine("");
            Console.WriteLine(objTotCustomerTxt.Text);
            objRM.fnAddStepLog(objTest, objTotCustomerTxt.Text, "Pass");
            Console.WriteLine("");
            Console.WriteLine(objTotGuestTxt.Text);
            objRM.fnAddStepLog(objTest, objTotGuestTxt.Text, "Pass");
            Console.WriteLine("");
            Console.WriteLine(objTotBookTxt.Text);
            objRM.fnAddStepLog(objTest, objTotBookTxt.Text, "Pass");
        }

        //Get the desired menu and click it.
        public static void fnClickSideMenu(string strMenuString)
        {

            IList<IWebElement> listSideMenu = driver.FindElements(By.XPath("//ul[@class='list-unstyled components']//child::li/a"));

            foreach (IWebElement SideElement in listSideMenu)
            {

                if (SideElement.Text == strMenuString.ToUpper())
                {
                    SideElement.Click();
                    objRM.fnAddStepLogScreen(objTest, driver, "Click on Menu: " + SideElement.Text, SideElement.Text + ".png", "Pass");
                }
            }
        }

        //Get a list of the sub menues.
        public static IList<IWebElement> fnGetSubMenu()
        {
            IList<IWebElement> listSideSubMenu = driver.FindElements(By.XPath("//ul[@class='wow fadeIn animated list-unstyled collapse in']//child::li/a"));
            return listSideSubMenu;
        }

        public static IList<IWebElement> fnTableElementsPage()
        {
            IList<IWebElement> tableElements = driver.FindElements(By.XPath("//tr[@class='xcrud-th']//child::th"));
            return tableElements;
        }

        //Go through the Sub Menu's content and validate the sorting.
        public static void fnSideMenuBtn(string strMenuString)
        {


            fnClickSideMenu(strMenuString);
            IList<IWebElement> listSideSubMenu1 = fnGetSubMenu();


            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@class='wow fadeIn animated list-unstyled collapse in']")));
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@class='wow fadeIn animated list-unstyled collapse in']")));


            for (int a = 0; a < listSideSubMenu1.Count; a++)
            {


                _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@class='wow fadeIn animated list-unstyled collapse in']")));
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@class='wow fadeIn animated list-unstyled collapse in']")));

                IList<IWebElement> listSideSubMenu = fnGetSubMenu();
                listSideSubMenu1 = listSideSubMenu;
                objRM.fnAddStepLogScreen(objTest, driver, "Click on SubMenu: " + listSideSubMenu1[a].Text, listSideSubMenu1[a].Text + ".png", "Pass");
                listSideSubMenu1[a].Click();


                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//tr[@class='xcrud-th']")));
                _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//tr[@class='xcrud-th']")));

                IList<IWebElement> tableElements = fnTableElementsPage();
                int intTableElements = tableElements.Count();

                for (int i = 0; i < intTableElements; i++)
                {
                    string valSortingBef = "";
                    string valSortingAft = "";
                    string valContains = "";
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//tr[@class='xcrud-th']//child::th")));
                    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//tr[@class='xcrud-th']//child::th")));


                    valSortingBef = tableElements[i].GetAttribute("data-order");
                    if (valSortingBef != null)
                    {
                        tableElements[i].Click();
                        _driverWait.Until(ExpectedConditions.StalenessOf(tableElements[i]));

                        tableElements = driver.FindElements(By.XPath("//tr[@class='xcrud-th']//child::th"));
                        valSortingAft = tableElements[i].GetAttribute("data-order");
                        _driverWait.Until(ExpectedConditions.ElementToBeClickable(tableElements[i]));
                        valContains = tableElements[i].Text;
                        if (valContains.Contains("↓"))
                        {
                            Assert.AreNotEqual(valSortingBef, valSortingAft);
                            objRM.fnAddStepLogScreen(objTest, driver, "Click on Column: " + tableElements[i].Text, tableElements[i] + ".png", "Pass");
                        }
                    }



                }
                fnClickSideMenu(strMenuString);
            }
        }

        

    }
}