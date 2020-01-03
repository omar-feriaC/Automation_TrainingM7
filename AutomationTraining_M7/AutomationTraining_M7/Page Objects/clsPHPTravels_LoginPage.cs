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
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class clsPHPTravels_LoginPage
    {
        /*ATTRIBUTES*/
        public static WebDriverWait _driverWait;
        private static IWebDriver _objDriver;
        private static clsReportManager objReport = new clsReportManager();
        private static ExtentReports _objExtent; 
        private static ExtentTest _objTest; 

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_EMAIL_TXT = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        //MENU STRING
        readonly static string STR_DASHBOARD_MNU = "//i[contains(@class,'fa fa-desktop')]";
        readonly static string STR_UPDATES_MNU = "//i[contains(@class,'fa fa-refresh')]";
        readonly static string STR_MODULES_MNU = "//i[contains(@class,'fa fa-cube')]";
        readonly static string STR_GENERAL_MNU = "//ul[@id='menu-ui']";
        readonly static string STR_ACCOUNTS_MNU = "//a[contains(text(),'Accounts')]";
        readonly static string STR_CMS_MNU = "//ul[@id='CMS']";
        readonly static string STR_TRABELHOPE_HOTEL_MNU = "//ul[@id='TravelhopeHotels']";
        readonly static string STR_TRABELHOPE_FLIGHTS_MNU = "//ul[@id='TravelhopeFlights']";
        readonly static string STR_TOURS_MNU = "//ul[@id='Tours']";
        readonly static string STR_CARS_MNU = "//ul[@id='Cars']";
        readonly static string STR_VISA_MNU = "//ul[@id='Ivisa']";
        readonly static string STR_BLOG_MNU = "//ul[@id='Blog']";
        readonly static string STR_LOCATIONS_MNU = "//ul[@id='Locations']";
        readonly static string STR_OFFERS_MNU = "//ul[@id='SPECIAL_OFFERS']";
        readonly static string STR_COUPONS_MNU = "//i[contains(@class,'fa fa-asterisk')]";
        readonly static string STR_NEWSLETTER_MNU = "//i[contains(@class,'fa fa-envelope')]";
        readonly static string STR_BOOKINGS_MNU = "//i[contains(@class,'fa fa-list w30')]";
        //SUBMENU STRING
        readonly static string STR_ACCOUNT_ADMINS_CLP = "//ul[@id='ACCOUNTS']//a[contains(text(),'Admins')]";
        readonly static string STR_ACCOUNT_SUP_CLP = "//ul[@id='ACCOUNTS']//a[contains(text(),'Suppliers')]";
        readonly static string STR_ACCOUNT_CUST_CLP = "//ul[@id='ACCOUNTS']//a[contains(text(),'Customers')]";
        readonly static string STR_ACCOUNT_GCUST_CLP = "//ul[@id='ACCOUNTS']//a[contains(text(),'GuestCustomers')]";
        //HEADERS
        readonly static string STR_FIRSTNAME_LBL = "//th[contains(text(),'First Name')]";
        readonly static string STR_FIRSTNAME_LBL_ASC = "//th[contains(text(),'↓ First Name')]";
        readonly static string STR_FIRSTNAME_LBL_DESC = "//th[contains(text(),'↑ First Name')]";
        readonly static string STR_LASTNAME_LBL = "//th[contains(text(),'Last Name')]";
        readonly static string STR_LASTNAME_LBL_ASC = "//th[contains(text(),'↓ Last Name')]";
        readonly static string STR_LASTNAME_LBL_DESC = "//th[contains(text(),'↑ Last Name')]";
        readonly static string STR_EMAIL_LBL = "//th[contains(text(),'Email')]";
        readonly static string STR_EMAIL_LBL_ASC = "//th[contains(text(),'↓ Email')]";
        readonly static string STR_EMAIL_LBL_DESC = "//th[contains(text(),'↑ Email')]";
        readonly static string STR_ACTIVE_LBL = "//th[contains(text(),'Active')]";
        readonly static string STR_ACTIVE_LBL_ASC = "//th[contains(text(),'↓ Active')]";
        readonly static string STR_ACTIVE_LBL_DESC = "//th[contains(text(),'↑ Active')]";
        readonly static string STR_LASTLOGIN_LBL = "//th[contains(text(),'Last Login')]";
        readonly static string STR_LASTLOGIN_LBL_ASC = "//th[contains(text(),'↓ Last Login')]";
        readonly static string STR_LASTLOGIN_LBL_DESC = "//th[contains(text(),'↑ Last Login')]";

        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver, ExtentReports objExtent, ExtentTest objTest)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
            _objExtent = objExtent;
            _objTest = objTest;
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt => _objDriver.FindElement(By.Name(STR_EMAIL_TXT)); 
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objForgotPassLnk => _objDriver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn => _objDriver.FindElement(By.XPath(STR_LOGIN_BTN));
        //MENU OBJ
        private static IWebElement objDASHBOARDMenuBtn => _objDriver.FindElement(By.XPath(STR_DASHBOARD_MNU));
        private static IWebElement objUPDATESMenuBtn => _objDriver.FindElement(By.XPath(STR_UPDATES_MNU));
        private static IWebElement objMODULESMenuBtn => _objDriver.FindElement(By.XPath(STR_MODULES_MNU));
        private static IWebElement objGENERALMenuBtn => _objDriver.FindElement(By.XPath(STR_GENERAL_MNU));
        private static IWebElement objACCOUNTSMenuBtn => _objDriver.FindElement(By.XPath(STR_ACCOUNTS_MNU));
        private static IWebElement objCMSMenuBtn => _objDriver.FindElement(By.XPath(STR_CMS_MNU));
        private static IWebElement objTRABELHOPE_HOTELMenuBtn => _objDriver.FindElement(By.XPath(STR_TRABELHOPE_HOTEL_MNU));
        private static IWebElement objTRABELHOPE_FLIGHTSMenuBtn => _objDriver.FindElement(By.XPath(STR_TRABELHOPE_FLIGHTS_MNU));
        private static IWebElement objTOURSMenuBtn => _objDriver.FindElement(By.XPath(STR_TOURS_MNU));
        private static IWebElement objCARSMenuBtn => _objDriver.FindElement(By.XPath(STR_CARS_MNU));
        private static IWebElement objVISAMenuBtn => _objDriver.FindElement(By.XPath(STR_VISA_MNU));
        private static IWebElement objBLOGMenuBtn => _objDriver.FindElement(By.XPath(STR_BLOG_MNU));
        private static IWebElement objLOCATIONSMenuBtn => _objDriver.FindElement(By.XPath(STR_LOCATIONS_MNU));
        private static IWebElement objOFFERSMenuBtn => _objDriver.FindElement(By.XPath(STR_OFFERS_MNU));
        private static IWebElement objCOUPONSMenuBtn => _objDriver.FindElement(By.XPath(STR_COUPONS_MNU));
        private static IWebElement objNEWSLETTERMenuBtn => _objDriver.FindElement(By.XPath(STR_NEWSLETTER_MNU));
        private static IWebElement objBOOKINGSMenuBtn => _objDriver.FindElement(By.XPath(STR_BOOKINGS_MNU));
        //SUBMENU OBJ
        private static IWebElement objSubMenuAdminBtn => _objDriver.FindElement(By.XPath(STR_ACCOUNT_ADMINS_CLP));
        private static IWebElement objSubMenuSupBtn => _objDriver.FindElement(By.XPath(STR_ACCOUNT_SUP_CLP));
        private static IWebElement objSubMenuCustBtn => _objDriver.FindElement(By.XPath(STR_ACCOUNT_CUST_CLP));
        private static IWebElement objSubMenuGCustBtn => _objDriver.FindElement(By.XPath(STR_ACCOUNT_GCUST_CLP));
        //HEADERS
        private static IWebElement objFNameBtn => _objDriver.FindElement(By.XPath(STR_FIRSTNAME_LBL));
        private static IWebElement objLNameBtn => _objDriver.FindElement(By.XPath(STR_LASTNAME_LBL));
        private static IWebElement objEmailBtn => _objDriver.FindElement(By.XPath(STR_EMAIL_LBL));
        private static IWebElement objActiveBtn => _objDriver.FindElement(By.XPath(STR_ACTIVE_LBL));
        private static IWebElement objLLoginBtn => _objDriver.FindElement(By.XPath(STR_LASTLOGIN_LBL));



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
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@class='serverHeader__statsList']")));
        }

        //Menu

        public static void fnClickMenu(string Menu_Option)
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_DASHBOARD_MNU)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_DASHBOARD_MNU)));
            switch (Menu_Option)
            {
                case "DASHBOARD":
                    objDASHBOARDMenuBtn.Click();
                    break;
                case "UPDATES":
                    objUPDATESMenuBtn.Click();
                    break;
                case "MODULES":
                    objMODULESMenuBtn.Click();
                    break;
                case "GENERAL":
                    objGENERALMenuBtn.Click();
                    break;
                case "ACCOUNTS":
                    objACCOUNTSMenuBtn.Click();
                    break;
                case "CMS":
                    objCMSMenuBtn.Click();
                    break;
                case "TRABELHOPE_HOTEL":
                    objTRABELHOPE_HOTELMenuBtn.Click();
                    break;
                case "TRABELHOPE_FLIGHTS":
                    objTRABELHOPE_FLIGHTSMenuBtn.Click();
                    break;
                case "TOURS":
                    objTOURSMenuBtn.Click();
                    break;
                case "CARS":
                    objCARSMenuBtn.Click();
                    break;
                case "VISA":
                    objVISAMenuBtn.Click();
                    break;
                case "BLOG":
                    objBLOGMenuBtn.Click();
                    break;
                case "LOCATIONS":
                    objLOCATIONSMenuBtn.Click();
                    break;
                case "OFFERS":
                    objOFFERSMenuBtn.Click();
                    break;
                case "COUPONS":
                    objCOUPONSMenuBtn.Click();
                    break;
                case "NEWSLETTER":
                    objNEWSLETTERMenuBtn.Click();
                    break;
                case "BOOKINGS":
                    objBOOKINGSMenuBtn.Click();
                    break;
                default:
                    break;
            }
        }


        //Submenu
        public static void fnClickSubMenuAdmins()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ACCOUNT_ADMINS_CLP)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ACCOUNT_ADMINS_CLP)));
            objSubMenuAdminBtn.Click();
        }
        public static void fnClickSubMenuSuppliers()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ACCOUNT_SUP_CLP)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ACCOUNT_SUP_CLP)));
            objSubMenuSupBtn.Click();
        }
        public static void fnClickSubMenuCustomer()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ACCOUNT_CUST_CLP)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ACCOUNT_CUST_CLP)));
            objSubMenuCustBtn.Click();
        }
        public static void fnClickSubMenuGuestCustomer()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ACCOUNT_GCUST_CLP)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ACCOUNT_GCUST_CLP)));
            objSubMenuGCustBtn.Click();
        }

        //Sorting
        public static void fnSortingAdmins()
        {
            string Status;
            string Order;
            fnClickSubMenuAdmins();
            try
            {
                Status = "Pass";
                //FirstName
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_FIRSTNAME_LBL)));
                Order = objFNameBtn.GetAttribute("data-order");
                objFNameBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_FIRSTNAME_LBL_ASC)));
                Assert.AreNotEqual(Order, objFNameBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_FirstNameSorting_Test", Status, $"Admins_FirstNameSorting_Test");
                //LastName
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LASTNAME_LBL)));
                Order = objLNameBtn.GetAttribute("data-order");
                objLNameBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LASTNAME_LBL_ASC)));
                Assert.AreNotEqual(Order, objLNameBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_LastNameSorting_Test", Status, $"Admins_LastNameSorting_Test");
                //EMail
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_EMAIL_LBL)));
                Order = objEmailBtn.GetAttribute("data-order");
                objEmailBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_EMAIL_LBL_ASC)));
                Assert.AreNotEqual(Order, objEmailBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_eMailSorting_Test", Status, $"Admins_eMailSorting_Test");
                //Active
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ACTIVE_LBL)));
                Order = objActiveBtn.GetAttribute("data-order");
                objActiveBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_ACTIVE_LBL_ASC)));
                Assert.AreNotEqual(Order, objActiveBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_ActiveSorting_Test", Status, $"Admins_ActiveSorting_Test");
                //LastLogin
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LASTLOGIN_LBL)));
                Order = objLLoginBtn.GetAttribute("data-order");
                objLLoginBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LASTLOGIN_LBL_ASC)));
                Assert.AreNotEqual(Order, objLLoginBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_LastLoginSorting_Test", Status, $"Admins_LastLoginSorting_Test");
            }
            catch (Exception e)
            {
                Status = "Fail";
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_Sorting_Test", Status, $"Admins_Sorting_Test");
            }
        }
        public static void fnSortingSuppliers()
        {
            string Status;
            string Order;
            fnClickSubMenuSuppliers();
            try
            {
                Status = "Pass";
                //FirstName
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_FIRSTNAME_LBL)));
                Order = objFNameBtn.GetAttribute("data-order");
                objFNameBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_FIRSTNAME_LBL_ASC)));
                Assert.AreNotEqual(Order, objFNameBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_FirstNameSorting_Test", Status, $"Admins_FirstNameSorting_Test");
                //LastName
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LASTNAME_LBL)));
                Order = objLNameBtn.GetAttribute("data-order");
                objLNameBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LASTNAME_LBL_ASC)));
                Assert.AreNotEqual(Order, objLNameBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_LastNameSorting_Test", Status, $"Admins_LastNameSorting_Test");
                //EMail
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_EMAIL_LBL)));
                Order = objEmailBtn.GetAttribute("data-order");
                objEmailBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_EMAIL_LBL_ASC)));
                Assert.AreNotEqual(Order, objEmailBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_eMailSorting_Test", Status, $"Admins_eMailSorting_Test");
                //Active
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ACTIVE_LBL)));
                Order = objActiveBtn.GetAttribute("data-order");
                objActiveBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_ACTIVE_LBL_ASC)));
                Assert.AreNotEqual(Order, objActiveBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_ActiveSorting_Test", Status, $"Admins_ActiveSorting_Test");
                //LastLogin
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LASTLOGIN_LBL)));
                Order = objLLoginBtn.GetAttribute("data-order");
                objLLoginBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LASTLOGIN_LBL_ASC)));
                Assert.AreNotEqual(Order, objLLoginBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_LastLoginSorting_Test", Status, $"Admins_LastLoginSorting_Test");

            }
            catch (Exception e)
            {
                Status = "Fail";
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_Sorting_Test", Status, $"Admins_Sorting_Test");
            }
        }
        public static void fnSortingCustomer()
        {
            string Status;
            string Order;
            fnClickSubMenuCustomer();
            try
            {
                Status = "Pass";
                //FirstName
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_FIRSTNAME_LBL)));
                Order = objFNameBtn.GetAttribute("data-order");
                objFNameBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_FIRSTNAME_LBL_ASC)));
                Assert.AreNotEqual(Order, objFNameBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_FirstNameSorting_Test", Status, $"Admins_FirstNameSorting_Test");
                //LastName
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LASTNAME_LBL)));
                Order = objLNameBtn.GetAttribute("data-order");
                objLNameBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LASTNAME_LBL_ASC)));
                Assert.AreNotEqual(Order, objLNameBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_LastNameSorting_Test", Status, $"Admins_LastNameSorting_Test");
                //EMail
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_EMAIL_LBL)));
                Order = objEmailBtn.GetAttribute("data-order");
                objEmailBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_EMAIL_LBL_ASC)));
                Assert.AreNotEqual(Order, objEmailBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_eMailSorting_Test", Status, $"Admins_eMailSorting_Test");
                //Active
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ACTIVE_LBL)));
                Order = objActiveBtn.GetAttribute("data-order");
                objActiveBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_ACTIVE_LBL_ASC)));
                Assert.AreNotEqual(Order, objActiveBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_ActiveSorting_Test", Status, $"Admins_ActiveSorting_Test");
                //LastLogin
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LASTLOGIN_LBL)));
                Order = objLLoginBtn.GetAttribute("data-order");
                objLLoginBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LASTLOGIN_LBL_ASC)));
                Assert.AreNotEqual(Order, objLLoginBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_LastLoginSorting_Test", Status, $"Admins_LastLoginSorting_Test");

            }
            catch (Exception e)
            {
                Status = "Fail";
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_Sorting_Test", Status, $"Admins_Sorting_Test");
            }
        }
        public static void fnSortingGuestCustomer()
        {
            string Status;
            string Order;
            fnClickSubMenuGuestCustomer();
            try
            {
                Status = "Pass";
                //FirstName
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_FIRSTNAME_LBL)));
                Order = objFNameBtn.GetAttribute("data-order");
                objFNameBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_FIRSTNAME_LBL_ASC)));
                Assert.AreNotEqual(Order, objFNameBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_FirstNameSorting_Test", Status, $"Admins_FirstNameSorting_Test");
                //LastName
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LASTNAME_LBL)));
                Order = objLNameBtn.GetAttribute("data-order");
                objLNameBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LASTNAME_LBL_ASC)));
                Assert.AreNotEqual(Order, objLNameBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_LastNameSorting_Test", Status, $"Admins_LastNameSorting_Test");
                //EMail
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_EMAIL_LBL)));
                Order = objEmailBtn.GetAttribute("data-order");
                objEmailBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_EMAIL_LBL_ASC)));
                Assert.AreNotEqual(Order, objEmailBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_eMailSorting_Test", Status, $"Admins_eMailSorting_Test");
                //Active
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ACTIVE_LBL)));
                Order = objActiveBtn.GetAttribute("data-order");
                objActiveBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_ACTIVE_LBL_ASC)));
                Assert.AreNotEqual(Order, objActiveBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_ActiveSorting_Test", Status, $"Admins_ActiveSorting_Test");
                //LastLogin
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LASTLOGIN_LBL)));
                Order = objLLoginBtn.GetAttribute("data-order");
                objLLoginBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LASTLOGIN_LBL_ASC)));
                Assert.AreNotEqual(Order, objLLoginBtn.GetAttribute("data-order"));
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_LastLoginSorting_Test", Status, $"Admins_LastLoginSorting_Test");

            }
            catch (Exception e)
            {
                Status = "Fail";
                objReport.fnStepCaptureImage(_objExtent, _objTest, _objDriver, $"Admins_Sorting_Test", Status, $"Admins_Sorting_Test");
            }
        }
    }
}
