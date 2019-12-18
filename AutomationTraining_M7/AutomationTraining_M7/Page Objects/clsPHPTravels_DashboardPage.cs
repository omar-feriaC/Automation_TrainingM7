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
    class clsPHPTravels_DashboardPage : BaseTest
    {
        /*ATTRIBUTES*/
        public static WebDriverWait _driverWait;
        private static IWebDriver _objDriver;

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_ADMINS_LBL = "(//a[i[@class='fa fa-user']])[1]";
        readonly static string STR_SUPPLIERS_LBL = "(//a[i[@class='fa fa-user']])[2]";
        readonly static string STR_CUSTOMERS_LBL = "(//a[i[@class='fa fa-users']])[1]";
        readonly static string STR_GUESTS_LBL = "(//a[i[@class='fa fa-users']])[2]";
        readonly static string STR_BOOKINGS_LBL = "//a[i[@class='fa fa-tag']]";


        /*CONSTRUCTOR*/
        public clsPHPTravels_DashboardPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objAdminsLbl = driver.FindElement(By.XPath(STR_ADMINS_LBL));
        private static IWebElement objSuppliersLbl = driver.FindElement(By.XPath(STR_SUPPLIERS_LBL));
        private static IWebElement objCustomersLbl = driver.FindElement(By.XPath(STR_CUSTOMERS_LBL));
        private static IWebElement objGuestsLbl = driver.FindElement(By.XPath(STR_GUESTS_LBL));
        private static IWebElement objBookingsLbl = driver.FindElement(By.XPath(STR_BOOKINGS_LBL));

        /*METHODS/FUNCTIONS*/

        //Administators count
        public static IWebElement GetAdminsLbl()
        {
            return objAdminsLbl;
        }
        //Suppliers count
        public static IWebElement GetSuppliersLbl()
        {
            return objSuppliersLbl;
        }
        //Customers count
        public static IWebElement GetCustomersLbl()
        {
            return objCustomersLbl;
        }
        //Guests count
        public static IWebElement GetGuestsLbl()
        {
            return objGuestsLbl;
        }
        //Bookings count
        public static IWebElement GetBookingsLbl()
        {
            return objBookingsLbl;
        }
    }
}

