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
using System.Threading;
using AutomationTraining_M7.Reporting;

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
        readonly static string STRREMEMBERME_LNK = "//label[@class='checkbox']";
        readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";
        //readonly static string STR_ISCHATMAXIMAZED_TXT = "//div[text()= 'Welcome to LiveChat']";
        //readonly static string STR_ISCHATMINIMIZED_TXT = "//";
        readonly static string STR_MINIMIZE_CHAT_BTN = "e1mwfyk10 lc-4rgplc e1m5b1js0";
        readonly static string STR_TOTALADMIN_TXT = "//a[text()= ' Total Admins ']";
        readonly static string STR_TOTALSUPPLIERS_TXT = "//a[text()= ' Total Suppliers ']";
        readonly static string STR_TOTALCUSTOMERS_TXT = "//a[text()= ' Total Customers ']";
        readonly static string STR_TOTALGUESTS_TXT = "//a[text()= ' Total Guests ']";
        readonly static string STR_TOTALBOOKINGS_TXT = "//a[text()= ' Total Bookings ']";
        readonly static string STR_SIDE_MENU_BTN = "//*[text()=' General']";
        

        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 20));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt => driver.FindElement(By.Name(STR_EMAIL_TXT)); 
        private static IWebElement objPasswordTxt => driver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeLnk => driver.FindElement(By.XPath(STRREMEMBERME_LNK));
        private static IWebElement objForgotPassLnk => driver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn => driver.FindElement(By.XPath(STR_LOGIN_BTN));
        private static IWebElement objMinChat => driver.FindElement(By.ClassName(STR_MINIMIZE_CHAT_BTN));
        private static IWebElement objTotalAdminTXT => driver.FindElement(By.XPath(STR_TOTALADMIN_TXT));
        private static IWebElement objTotalSuppiersTXT => driver.FindElement(By.XPath(STR_TOTALSUPPLIERS_TXT));
        private static IWebElement objTotalCustomersTXT => driver.FindElement(By.XPath(STR_TOTALCUSTOMERS_TXT));
        private static IWebElement objTotalGuestsTXT => driver.FindElement(By.XPath(STR_TOTALGUESTS_TXT));
        private static IWebElement objTotalBookingsTXT => driver.FindElement(By.XPath(STR_TOTALBOOKINGS_TXT));
        private static IWebElement objSideMenuBtn => driver.FindElement(By.XPath(STR_SIDE_MENU_BTN));
        private static IWebElement objChildSideMenuBtn => driver.FindElement(By.XPath(STR_SIDE_MENU_BTN));

        //private static IList<IWebElement> tableElements = driver.FindElements(By.XPath("//tr[@class='xcrud-th']//child::th"));
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
            return objLoginBtn;
        }

        public static void fnClickLoginButton()
        {

            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LOGIN_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LOGIN_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LOGIN_BTN)));
            objLoginBtn.Click();
        }

        /*Hamburger Button*/
        public static void fnWaitHamburgerMenu()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.Id(STR_HAMBURGER_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_HAMBURGER_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.Id(STR_HAMBURGER_BTN)));
        }

        //MINIMIZE CHAT

        //private IWebElement GetChatMax() {
        //    return objIsChatMax;
        //}

        //private IWebElement GetChatMin() {
        //    return objIsChatMin;
        //}
        //private IWebElement GetMinimizeChatButton()
        //{
        //    return objMinChat;
        //}
        //public static void fnMinimizeChat()
        //{
        //    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(STR_ISCHATMINIMIZED_TXT))); 

        //    if (objIsChatMax.Displayed) //(driver.FindElements(By.XPath(STR_ISCHATMAXIMAZED_TXT)).Count > 0) 
        //    {
        //        _driverWait.Until(ExpectedConditions.ElementExists(By.ClassName(STR_MINIMIZE_CHAT_BTN)));
        //        _driverWait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(STR_MINIMIZE_CHAT_BTN)));
        //        _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName(STR_MINIMIZE_CHAT_BTN)));
        //        objMinChat.Click();
        //    }
        //    else { 
        //        _driverWait.Until(ExpectedConditions.ElementExists(By.ClassName(STR_ISCHATMINIMIZED_TXT)));
        //        _driverWait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(STR_ISCHATMINIMIZED_TXT)));
        //        _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName(STR_ISCHATMINIMIZED_TXT)));
        //        objIsChatMin.Click();

        //    }
        //}

        //Print the stats of the page
        public static void fnPrintStats()
        {
            Console.WriteLine(objTotalAdminTXT.Text);
            objRM.fnAddStepLog(objTest, objTotalAdminTXT.Text, "Pass");
            Console.WriteLine("");
            Console.WriteLine(objTotalSuppiersTXT.Text);
            objRM.fnAddStepLog(objTest, objTotalSuppiersTXT.Text, "Pass");
            Console.WriteLine("");
            Console.WriteLine(objTotalCustomersTXT.Text);
            objRM.fnAddStepLog(objTest, objTotalGuestsTXT.Text, "Pass");
            Console.WriteLine("");
            Console.WriteLine(objTotalGuestsTXT.Text);
            objRM.fnAddStepLog(objTest, objTotalGuestsTXT.Text, "Pass");
            Console.WriteLine("");
            Console.WriteLine(objTotalBookingsTXT.Text);
            objRM.fnAddStepLog(objTest, objTotalBookingsTXT.Text, "Pass");
        }

        private IWebElement GetSideMenu() {
            return objSideMenuBtn;
        }
        private IWebElement GetChildMenu()
        {
            return objChildSideMenuBtn;
        }

        public static void fnSideMenuBtn (string strMenuString)
        {
           
            IList<IWebElement> listSideMenu = driver.FindElements(By.XPath("//ul[@class='list-unstyled components']//child::li/a"));

            foreach (IWebElement SideElement in listSideMenu)
            {
                
                if (SideElement.Text == strMenuString.ToUpper()) {

                    
                    SideElement.Click();
                    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@class='wow fadeIn animated list-unstyled collapse in']")));
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@class='wow fadeIn animated list-unstyled collapse in']")));
                    IList<IWebElement> listSideSubMenu = driver.FindElements(By.XPath("//ul[@class='wow fadeIn animated list-unstyled collapse in']//child::li/a"));
                    

                    foreach (IWebElement SubMenuElements in listSideSubMenu) {

                        SubMenuElements.Click();
                        
                        //SubMenuElements.GetAttribute("class");
                        
                        //string classSideSubMenu = SubMenuElements.GetAttribute("class");

                        _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//tr[@class='xcrud-th']")));
                        _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//tr[@class='xcrud-th']")));

                        IList<IWebElement> tableElements = driver.FindElements(By.XPath("//tr[@class='xcrud-th']//child::th"));
                        int intTableElements = tableElements.Count();
                        

                        for (int i = 2; i <= intTableElements; i++)
                        {
                            string valSortingBef = "";
                            string valSortingAft = "";
                            string valContains = "";
                            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//tr[@class='xcrud-th']//child::th")));
                            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//tr[@class='xcrud-th']//child::th")));
                            
                            //tableElements[i].GetAttribute("data-order");
                            valSortingBef = tableElements[i].GetAttribute("data-order");
                            tableElements[i].Click();
                            //Thread.Sleep(5000);
                            _driverWait.Until(ExpectedConditions.StalenessOf(tableElements[i]));
                            
                            tableElements = driver.FindElements(By.XPath("//tr[@class='xcrud-th']//child::th"));
                            valSortingAft = tableElements[i].GetAttribute("data-order");
                            _driverWait.Until(ExpectedConditions.ElementToBeClickable(tableElements[i]));
                            valContains = tableElements[i].Text;
                            if (valContains.Contains("↓")) {
                                Assert.AreNotEqual(valSortingBef, valSortingAft);
                                objRM.fnAddStepLog(objTest, tableElements[i].Text, "PASS");


                            }
                            
                            //Thread.Sleep(5000);

                            //_driverWait.Until(ExpectedConditions.ElementToBeClickable(tableElements[i]));


                        }

                        //foreach (var tElements in tableElements)
                        //{

                        //    //string valSortingBef = tElements.GetAttribute("data-order");
                        //    tElements.Click();
                        //    //string valSortingAft = tElements.GetAttribute("data-order");

                        //    //Assert.AreNotEqual(valSortingBef, valSortingAft);
                        //}



                        //SideElement.Click();
                    }

                    
                }
            
            }
        }

        public static void fnSideMenu()
        {
            
        
        }
    }
}
