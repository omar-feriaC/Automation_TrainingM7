using AutomationTraining_M7.Base_Files;
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
        readonly static string STR_SIDEBAR_MENU = "//div[@class='social-sidebar']";
        readonly static string STR_DASHBOARD_LNK = "//a[text()='Dashboard']";
        readonly static string STR_UPDATES_LNK = "//a[text()='Updates']";
        readonly static string STR_MODULES_LNK = "//a[text()='Modules']";
        readonly static string STR_GENERAL_DD = "//a[text()=' General']";
        readonly static string STR_GENERAL_MENU = "//ul[@id='menu-ui']";
        readonly static string STR_GENSETTINGS_SUBM = "//li[text()='Settings']";
        readonly static string STR_OCURRENCIES_SUBM = "//li[text()='Currencies']";
        readonly static string STR_PYMTGTW_SUBM = "//li[text()='Payment Gateways']";
        readonly static string STR_SOCIALCONN_SUBM = "//li[text()='Social Connections']";
        readonly static string STR_WIDGETS_SUBM = "//li[text()='Widgets']";
        readonly static string STR_SLIDERS_SUBM = "//li[text()='Sliders']";
        readonly static string STR_EMAILTEMP_SUBM = "//li[text()='Email Templates']";
        readonly static string STR_SMSAPISET_SUBM = "//li[text()='SMS API Settings']";
        readonly static string STR_BACKUP_SUBM = "//li[text()='BackUp']";
        readonly static string STR_ACCOUNTS_DD = "//a[text()=' Accounts                ']";
        readonly static string STR_ACCOUNTS_MENU = "//ul[@id='ACCOUNTS']";
        readonly static string STR_ADMINS_SUBM = "//li[text()='Admins']";
        readonly static string STR_SUPPLIERS_SUBM = "//li[text()='Suppliers']";
        readonly static string STR_CUSTOMERS_SUBM = "//li[text()='Customers']";
        readonly static string STR_GUESTCUSTOMERS_SUBM = "//li[text()='GuestCustomers']";
        readonly static string STR_CMS_DD = "//a[text()='CMS']";
        readonly static string STR_CMS_MENU = "//ul[@id='CMS']";
        readonly static string STR_PAGES_SUBM = "//li[text()='Pages']";
        readonly static string STR_THHOTEL_DD = "//a[text()='Travelhope Hotels']";
        readonly static string STR_THHOTEL_MENU = "//ul[@id='TravelhopeHotels']";
        readonly static string STR_THHBOOKINGS_SUBM = "//ul[@id='TravelhopeHotels'][text()='Bookings']";
        readonly static string STR_THHSETTINGS_SUBM = "//ul[@id='TravelhopeHotels'][text()='Settings']";
        readonly static string STR_THFLIGHT_DD = "//a[text()='Travelhope Flights']";
        readonly static string STR_THFLIGHT_MENU = "//ul[@id='TravelhopeFlights']";
        readonly static string STR_THFBOOKINGS_SUBM = "//ul[@id='TravelhopeFlights'][text()='Bookings']";
        readonly static string STR_THFSETTINGS_SUBM = "//ul[@id='TravelhopeFlights'][text()='Settings']";
        readonly static string STR_TOURS_DD = "//a[text()='Tours']";
        readonly static string STR_TOURS_MENU = "//ul[@id='Tours']";
        readonly static string STR_TOURTOURS_SUBM = "//ul[@id='Tours'][text()='Tours']";
        readonly static string STR_TOURADDNEW_SUBM = "//ul[@id='Tours'][text()='Add New']";
        readonly static string STR_TOUREXTRAS_SUBM = "//ul[@id='Tours'][text()='Extras']";
        readonly static string STR_TOURREVIEWS_SUBM = "//ul[@id='Tours'][text()='Reviews']";
        readonly static string STR_TOURSETTINGS_SUBM = "//ul[@id='Tours'][text()='Settings']";
        readonly static string STR_CARS_DD = "//a[text()='Cars']";
        readonly static string STR_CARS_MENU = "//ul[@id='Cars']";
        readonly static string STR_CARSCARS_SUBM = "//ul[@id='Cars'][text()='Cars']";
        readonly static string STR_CARSEXTRAS_SUBM = "//ul[@id='Cars'][text()='Extras']";
        readonly static string STR_CARSETTINGS_SUBM = "//ul[@id='Cars'][text()='Cars Settings']";
        readonly static string STR_VISA_DD = "//a[text()='Visa']";
        readonly static string STR_VISA_MENU = "//ul[@id='Ivisa']";
        readonly static string STR_VISASETTINGS_SUBM = "//ul[@id='Ivisa'][text()='Settings']";
        readonly static string STR_VISABOOKINS_SUBM = "//ul[@id='Ivisa'][text()='Bookins']";
        readonly static string STR_BLOG_DD = "//a[text()='Blog']";
        readonly static string STR_BLOG_MENU = "//ul[@id='Blog']";
        readonly static string STR_BLOGPOST_SUBM = "//ul[@id='Blog'][text()='Posts']";
        readonly static string STR_BLOGCATEGORIES_SUBM = "//ul[@id='Blog'][text()='Blog Categories']";
        readonly static string STR_BLOGSETTINGS_SUBM = "//ul[@id='Blog'][text()='Blog Settings']";
        readonly static string STR_LOCATIONS_DD = "//a[text()='Locations']";
        readonly static string STR_LOCATIONS_MENU = "//ul[@id='Locations']";
        readonly static string STR_LOCATIONLIST_SUBM = "//ul[@id='Locations'][text()='Locations List']";
        readonly static string STR_OFFERS_DD = "//a[text()=' Offers']";
        readonly static string STR_OFFERS_MENU = "//ul[@id='SPECIAL_OFFERS']";
        readonly static string STR_MANAGEOFFERS_SUBM = "//ul[@id='SPECIAL_OFFERS'][text()='Manage Offers']";
        readonly static string STR_OFFERSETTINGS_SUBM = "//ul[@id='SPECIAL_OFFERS'][text()='Offers Settings']";




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
        private static IWebElement objSidebarMenu => _objDriver.FindElement(By.XPath(STR_SIDEBAR_MENU));
        private static IWebElement objGeneralDD => _objDriver.FindElement(By.XPath(STR_GENERAL_DD));
        private static IWebElement objGenMenu => _objDriver.FindElement(By.XPath(STR_GENERAL_MENU));
        private static IWebElement objAccountDD => _objDriver.FindElement(By.XPath(STR_ACCOUNTS_DD));
        private static IWebElement objCMSDD => _objDriver.FindElement(By.XPath(STR_CMS_DD));
        private static IWebElement objTHHotelDD => _objDriver.FindElement(By.XPath(STR_THHOTEL_DD));
        private static IWebElement objTHFlightsDD => _objDriver.FindElement(By.XPath(STR_THFLIGHT_DD));
        private static IWebElement objToursDD => _objDriver.FindElement(By.XPath(STR_TOURS_DD));
        private static IWebElement objCarsDD => _objDriver.FindElement(By.XPath(STR_CARS_DD));
        private static IWebElement objVisaDD => _objDriver.FindElement(By.XPath(STR_VISA_DD));
        private static IWebElement objBlogDD => _objDriver.FindElement(By.XPath(STR_BLOG_DD));
        private static IWebElement objLocationsDD => _objDriver.FindElement(By.XPath(STR_LOCATIONS_DD));
        private static IWebElement objOffersDD => _objDriver.FindElement(By.XPath(STR_OFFERS_DD));





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

        private IWebElement GetSideBar()
        {
            return objSidebarMenu;
        }

        public static void fnGeneral()
        {
            objGeneralDD.Click();
            //Console.WriteLine(objGenMenu.Text);
            objRM.fnAddStepLog(objTest, objGenMenu.Text, "Pass");
        }
        public static void fnPrintSidebarMenu()
        {
            objOffersDD.Click();
            objLocationsDD.Click();
            objBlogDD.Click();
            objVisaDD.Click();
            objCarsDD.Click();
            objToursDD.Click();
            objTHFlightsDD.Click();
            objTHHotelDD.Click();
            objCMSDD.Click();
            objAccountDD.Click();
            objGeneralDD.Click();
            Console.WriteLine(objSidebarMenu.Text);
            objRM.fnAddStepLog(objTest, objSidebarMenu.Text, "Pass");
        }


    }
}
