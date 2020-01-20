using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace AutomationTraining_M7.Page_Objects
{
    class clsPHPTravels_Main
    {
        /*ATTRIBUTES*/
        public static WebDriverWait _driverWait;
        private static IWebDriver _objDriver;
        public static Dictionary<string, string> lisValues = new Dictionary<string, string>();

        /*LOCATORS DESCRIPTION*/
        readonly static string strTotalAdmins = "//descendant::*[text()=' Total Admins ']//child::b";
        readonly static string strTotalSuppliers = "//descendant::*[text()=' Total Suppliers ']//child::b";
        readonly static string strTotalCustomerss = "//descendant::*[text()=' Total Customers ']//child::b";
        readonly static string strTotalGuests = "//descendant::*[text()=' Total Guests ']//child::b";
        readonly static string strTotalBookings = "//descendant::*[text()=' Total Bookings ']//child::b";
        
        readonly static string strAdmins = "Admins";
        readonly static string strSuppliers = "Suppliers";
        readonly static string strCustomerss = "Customers";
        readonly static string strGuests = "Guests";
        readonly static string strBookings = "Bookings";

        /*CONSTRUCTOR*/
        public clsPHPTravels_Main(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objTotalAdmins = _objDriver.FindElement(By.Name(strTotalAdmins)); 
        private static IWebElement objTotalSuppliers = _objDriver.FindElement(By.Name(strTotalSuppliers));
        private static IWebElement objTotalCustomerss = _objDriver.FindElement(By.XPath(strTotalCustomerss));
        private static IWebElement objTotalGuests = _objDriver.FindElement(By.XPath(strTotalGuests));
        private static IWebElement objTotalBookings = _objDriver.FindElement(By.XPath(strTotalBookings));


        /*METHODS/FUNCTIONS*/

        public Dictionary<string, string> CreateReport()
        {
            lisValues.Add(strAdmins, objTotalAdmins.ToString());
            lisValues.Add(strSuppliers, objTotalSuppliers.ToString());
            lisValues.Add(strCustomerss, objTotalCustomerss.ToString());
            lisValues.Add(strGuests, objTotalGuests.ToString());
            lisValues.Add(strBookings, objTotalBookings.ToString());
            return lisValues;
        }

       
 


    }
}
