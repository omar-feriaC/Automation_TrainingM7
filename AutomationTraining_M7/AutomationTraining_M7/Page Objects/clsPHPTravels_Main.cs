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
        private static IWebElement objTotalAdmins => _objDriver.FindElement(By.XPath(strTotalAdmins)); 
        private static IWebElement objTotalSuppliers => _objDriver.FindElement(By.XPath(strTotalSuppliers));
        private static IWebElement objTotalCustomerss => _objDriver.FindElement(By.XPath(strTotalCustomerss));
        private static IWebElement objTotalGuests => _objDriver.FindElement(By.XPath(strTotalGuests));
        private static IWebElement objTotalBookings => _objDriver.FindElement(By.XPath(strTotalBookings));

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
        public static void fnPHPTravels_Main_Menu_click(string strMenu, string strMenuSub)
        {
            string strXpath;
            if (strMenu.Length > 0) 
            {
                if (strMenuSub.Length > 0)
                {
                    strXpath = "//li[a[contains(text(),'"+ strMenu + "')]]//a[text()='" + strMenuSub + "']";
                }
                else 
                {
                    strXpath = "//a[contains(text(),'" + strMenu + "')]";
                }
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(strXpath)));
                _objDriver.FindElement(By.XPath(strXpath)).Click();
            }
        }
        public static bool fnPHPTravels_Menu_Assert(string strExpected)
        {
            string strXpath= "//*[@class='panel-heading']";
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(strXpath)));
            string strVal= _objDriver.FindElement(By.XPath(strXpath)).Text;
            if (strExpected.ToUpper().Trim() == strVal.ToUpper().Trim()) 
            {
                return true;
            }    
            return false;
        }

        public static string fnPHPTravels_Column_First_Name_Sort()
        {
            string strReturn = "The First name Sort is not working";
            string strXpath = "//th[contains(text(),'First Name')]";
            string strTableXpath = "//table[@class='xcrud-list table table-striped table-hover']/tbody/tr";
            string strTableFirst = "//table[@class='xcrud-list table table-striped table-hover']/tbody/tr[1]/td[@class='xcrud-current']";
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(strXpath)));
            if (_objDriver.FindElements(By.XPath(strTableXpath)).Count() > 1)
            {
                string strVal = _objDriver.FindElement(By.XPath(strTableFirst)).Text;
                _objDriver.FindElement(By.XPath(strXpath)).Click();
                if (strVal == _objDriver.FindElement(By.XPath(strTableFirst)).Text)
                {
                    strReturn = "Success";
                }
            }
            else 
            {
                strReturn = "There are not enough rows to validate";
            }
            //table[@class='xcrud-list table table-striped table-hover']/tbody/tr
            return strReturn;
        }
        public static string fnPHPTravels_Column_Last_Name_Sort()
        {
            string strReturn = "The last name Sort is not working";
            string strXpath = "//th[contains(text(),'Last Name')]";
            string strTableXpath = "//table[@class='xcrud-list table table-striped table-hover']/tbody/tr";
            string strTableFirst = "//table[@class='xcrud-list table table-striped table-hover']/tbody/tr[1]/td[@class='xcrud-current']";
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(strXpath)));
            if (_objDriver.FindElements(By.XPath(strTableXpath)).Count() > 1)
            {
                string strVal = _objDriver.FindElement(By.XPath(strTableFirst)).Text;
                _objDriver.FindElement(By.XPath(strXpath)).Click();
                if (strVal == _objDriver.FindElement(By.XPath(strTableFirst)).Text)
                {
                    strReturn = "Success";
                }
            }
            else
            {
                strReturn = "There are not enough rows to validate";
            }
            return strReturn;
        }
        public static string fnPHPTravels_Column_Email_Sort()
        {
            string strReturn = "The Email sort is not working";
            string strXpath = "//th[contains(text(),'Email')]";
            string strTableXpath = "//table[@class='xcrud-list table table-striped table-hover']/tbody/tr";
            string strTableFirst = "//table[@class='xcrud-list table table-striped table-hover']/tbody/tr[1]/td[@class='xcrud-current']";
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(strXpath)));
            if (_objDriver.FindElements(By.XPath(strTableXpath)).Count() > 1)
            {
                string strVal = _objDriver.FindElement(By.XPath(strTableFirst)).Text;
                _objDriver.FindElement(By.XPath(strXpath)).Click();
                if (strVal == _objDriver.FindElement(By.XPath(strTableFirst)).Text)
                {
                    strReturn = "Success";
                }
            }
            else
            {
                strReturn = "There are not enough rows to validate";
            }
            return strReturn;
        }
        public static string fnPHPTravels_Column_Active_Sort()
        {
            string strReturn = "The Email sort is not working or All the Users are in the same status and can't be verified";
            string strXpath = "//th[contains(text(),'Active')]";
            string strTableXpath = "//table[@class='xcrud-list table table-striped table-hover']/tbody/tr";
            string strTableFirst = "//table[@class='xcrud-list table table-striped table-hover']/tbody/tr[1]/td[6]/i";
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(strXpath)));
            if (_objDriver.FindElements(By.XPath(strTableXpath)).Count() > 1)
            {
                string strVal = _objDriver.FindElement(By.XPath(strTableFirst)).GetAttribute("class");
                _objDriver.FindElement(By.XPath(strXpath)).Click();
                if (strVal == _objDriver.FindElement(By.XPath(strTableFirst)).GetAttribute("class"))
                {
                    strReturn = "Success";
                }
            }
            else
            {
                strReturn = "There are not enough rows to validate";
            }
            return strReturn;
        }
        public static string fnPHPTravels_Column_LastLoguin_Sort()
        {
            string strReturn = "The Last Loguin sort is not working";
            string strXpath = "//th[contains(text(),'Last Login')]";
            string strTableXpath = "//table[@class='xcrud-list table table-striped table-hover']/tbody/tr";
            string strTableFirst = "//table[@class='xcrud-list table table-striped table-hover']/tbody/tr[1]/td[7]";
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(strXpath)));
            if (_objDriver.FindElements(By.XPath(strTableXpath)).Count() > 1)
            {
                string strVal = _objDriver.FindElement(By.XPath(strTableFirst)).Text;
                _objDriver.FindElement(By.XPath(strXpath)).Click();
                if (strVal == _objDriver.FindElement(By.XPath(strTableFirst)).Text)
                {
                    if (strVal.Length > 0 && strVal != null) 
                    {
                        strReturn = "Success";
                    }
                    strReturn = "All dates are null there is no data to verify this sort";
                }
            }
            else
            {
                strReturn = "There are not enough rows to validate";
            }
            return strReturn;
        }
    }
}
