using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class clsPHPTravels_Dashboard_Page : BaseTest
    {
        /*ATTRIBUTES*/
        public static WebDriverWait _driverWait;
        private static IWebDriver _objDriver;

        /*LOCATORS DESCRIPTION*/

        readonly static string STR_TOTALADMINS_LNK = "//a[contains(text(), 'Total Admins')]";
        readonly static string STR_TOTALSUPPLIERS_LNK = "//a[contains(text(), 'Total Suppliers')]";
        readonly static string STR_TOTALCUSTOMERS_LNK = "//a[contains(text(), 'Total Customers')]";
        readonly static string STR_TOTALGUESTS_LNK = "//a[contains(text(), 'Total Guests')]";
        readonly static string STR_TOTALBOOKINGS_LNK = "//a[contains(text(), 'Total Bookings')]";

        /*CONSTRUCTOR*/
        public clsPHPTravels_Dashboard_Page(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objTotalAdminsLnk = driver.FindElement(By.XPath(STR_TOTALADMINS_LNK));
        private static IWebElement objTotalSuppliersLnk = driver.FindElement(By.XPath(STR_TOTALSUPPLIERS_LNK));
        private static IWebElement objTotalCustomersLnk = driver.FindElement(By.XPath(STR_TOTALCUSTOMERS_LNK));
        private static IWebElement objTotalGuestsLnk = driver.FindElement(By.XPath(STR_TOTALGUESTS_LNK));
        private static IWebElement objTotalBookingsLnk = driver.FindElement(By.XPath(STR_TOTALBOOKINGS_LNK));

        //Total admins link
        public static IWebElement GetTotalAdminsLink()
        {
            return objTotalAdminsLnk;
        }

        //Total suppliers link
        public static IWebElement GetTotalSuppliersLink()
        {
            return objTotalSuppliersLnk;
        }

        //Total customers link
        public static IWebElement GetTotalCustomersLink()
        {
            return objTotalCustomersLnk;
        }
        //Total guests link
        public static IWebElement GetTotalGuestsLink()
        {
            return objTotalGuestsLnk;
        }
        //Total bookings link
        public static IWebElement GetTotalBookingsLink()
        {
            return objTotalBookingsLnk;
        }
    }
}
