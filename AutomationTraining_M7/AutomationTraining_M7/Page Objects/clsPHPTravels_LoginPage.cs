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
        readonly static string STR_MINIMIZE_CHAT_BTN = "e1mwfyk10 lc-4rgplc e1m5b1js0";
        readonly static string STR_TOTALADMIN_TXT = "//a[text()= ' Total Admins ']";
        readonly static string STR_TOTALSUPPLIERS_TXT = "//a[text()= ' Total Suppliers ']";
        readonly static string STR_TOTALCUSTOMERS_TXT = "//a[text()= ' Total Customers ']";
        readonly static string STR_TOTALGUESTS_TXT = "//a[text()= ' Total Guests ']";
        readonly static string STR_TOTALBOOKINGS_TXT = "//a[text()= ' Total Bookings ']";



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

        public static void fnSideMenuBtn(string strMenuString)
        {

            
            fnClickSideMenu(strMenuString);
            IList<IWebElement> listSideSubMenu1 = fnSubMenu();

            
                    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@class='wow fadeIn animated list-unstyled collapse in']")));
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@class='wow fadeIn animated list-unstyled collapse in']")));
            

                for (int a = 0; a < listSideSubMenu1.Count; a++) 
                {

                        
                        _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@class='wow fadeIn animated list-unstyled collapse in']")));
                        _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@class='wow fadeIn animated list-unstyled collapse in']")));
                
                        IList<IWebElement> listSideSubMenu = fnSubMenu();
                        listSideSubMenu1 = listSideSubMenu;
                        objRM.fnAddStepLog(objTest, "Click on SubMenu: " + listSideSubMenu1[a].Text, "PASS");
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
                                IList<IWebElement> tableRowsBefore = fnColumnOrderAfter(i);
                                var ListToCompare = tableRowsBefore.OrderBy(x => x.Text).ToList().ToString();
                                tableElements[i].Click();
                                _driverWait.Until(ExpectedConditions.StalenessOf(tableElements[i]));

                                tableElements = driver.FindElements(By.XPath("//tr[@class='xcrud-th']//child::th"));
                                valSortingAft = tableElements[i].GetAttribute("data-order");
                                _driverWait.Until(ExpectedConditions.ElementToBeClickable(tableElements[i]));
                                valContains = tableElements[i].Text;
                                if (valContains.Contains("↓"))
                                {
                                    IList<IWebElement> tableRowsAfter = fnColumnOrderAfter(i);
                                    var ListToCompareTo = tableRowsAfter.OrderBy(y => y.Text).ToList().ToString();
                                    Assert.AreEqual(ListToCompare,ListToCompareTo);
                                    Assert.AreNotEqual(valSortingBef, valSortingAft);
                                    objRM.fnAddStepLog(objTest, "Data validation on column: " + tableElements[i].Text+" is correct", "PASS");
                                    objRM.fnAddStepLog(objTest, "Click on Column: "+tableElements[i].Text, "PASS");


                                }
                            }

                            

                        }
                        fnClickSideMenu(strMenuString);
                }
        }

        public static void fnClickSideMenu(string strMenuString)
        {

            IList<IWebElement> listSideMenu = driver.FindElements(By.XPath("//ul[@class='list-unstyled components']//child::li/a"));

            foreach (IWebElement SideElement in listSideMenu)
            {

                if (SideElement.Text == strMenuString.ToUpper())
                {
                    SideElement.Click();
                    objRM.fnAddStepLog(objTest, "Click on Menu: " + SideElement.Text, "PASS");
                }
            }
        }

        public static IList<IWebElement> fnSubMenu ()
        {
            IList<IWebElement> listSideSubMenu = driver.FindElements(By.XPath("//ul[@class='wow fadeIn animated list-unstyled collapse in']//child::li/a"));
            return listSideSubMenu;
        }

        public static IList<IWebElement> fnTableElementsPage()
        {
            IList<IWebElement> tableElements = driver.FindElements(By.XPath("//tr[@class='xcrud-th']//child::th"));
            return tableElements;
        }

        public static IList<IWebElement> fnColumnOrderBefore(int tableRow)
        {
            IList<IWebElement> tableRows = driver.FindElements(By.XPath($"//tbody//tr//td[{tableRow}]"));
            return tableRows;
        }

        public static IList<IWebElement> fnColumnOrderAfter(int tableRow)
        {
            IList<IWebElement> tableRows = driver.FindElements(By.XPath($"//tbody//tr//td[{tableRow}]"));
            return tableRows;
        }

    }
}
