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
    class ClsPHPTravels_Dashboard_Page : BaseTest
    {
        /*ATTRIBUTES*/
        public static WebDriverWait _driverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 40));

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_TOTALADMINS_LNK = "//a[contains(text(), 'Total Admins')]";
        readonly static string STR_TOTALSUPPLIERS_LNK = "//a[contains(text(), 'Total Suppliers')]";
        readonly static string STR_TOTALCUSTOMERS_LNK = "//a[contains(text(), 'Total Customers')]";
        readonly static string STR_TOTALGUESTS_LNK = "//a[contains(text(), 'Total Guests')]";
        readonly static string STR_TOTALBOOKINGS_LNK = "//a[contains(text(), 'Total Bookings')]";
        readonly static string STR_ADMINSMGMT_DIV = "//div[contains(text(), 'Admins Management')]";
        readonly static string STR_SUPPLIERSMGMT_DIV = "//div[contains(text(), 'Suppliers Management')]";
        readonly static string STR_FIRSTNAME_TH = "//th[@data-orderby='pt_accounts.ai_first_name']"; //"//th[contains(text(),'First Name')]";
        readonly static string STR_FIRSTNAMEDESC_TH = "//th[contains(text(),'↓ First Name')]";
        readonly static string STR_FIRSTNAMEASC_TH = "//th[contains(text(),'↑ First Name')]";

        readonly static string STR_LASTNAME_TH = "//th[contains(text(),'Last Name')]";
        readonly static string STR_LASTNAMEDESC_TH = "//th[contains(text(),'↓ Last Name')]";
        readonly static string STR_LASTNAMEASC_TH = "//th[contains(text(),'↑ Last Name')]";

        readonly static string STR_EMAIL_TH = "//th[contains(text(),'Email')]";
        readonly static string STR_EMAILDESC_TH = "//th[contains(text(),'↓ Email')]";
        readonly static string STR_EMAILASC_TH = "//th[contains(text(),'↑ Email')]";

        readonly static string STR_ACTIVE_TH = "//th[contains(text(),'Active')]";
        readonly static string STR_ACTIVEDESC_TH = "//th[contains(text(),'↓ Active')]";
        readonly static string STR_ACTIVEASC_TH = "//th[contains(text(),'↑ Active')]";

        readonly static string STR_LASTLOGIN_TH = "//th[contains(text(),'Last Login')]";
        readonly static string STR_LASTLOGINDESC_TH = "//th[contains(text(),'↓ Last Login')]";
        readonly static string STR_LASTLOGINASC_TH = "//th[contains(text(),'↑ Last Login')]";

        /*OBJECT DEFINITION*/
        private static IWebElement objTotalAdminsLnk = driver.FindElement(By.XPath(STR_TOTALADMINS_LNK));
        private static IWebElement objTotalSuppliersLnk = driver.FindElement(By.XPath(STR_TOTALSUPPLIERS_LNK));
        private static IWebElement objTotalCustomersLnk = driver.FindElement(By.XPath(STR_TOTALCUSTOMERS_LNK));
        private static IWebElement objTotalGuestsLnk = driver.FindElement(By.XPath(STR_TOTALGUESTS_LNK));
        private static IWebElement objTotalBookingsLnk = driver.FindElement(By.XPath(STR_TOTALBOOKINGS_LNK));

        public enum Sort
        {
            Asc,
            Desc
        }

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

        internal static void fnWaitAdminsdIV()
        {
            throw new NotImplementedException();
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
        public static void fnClickSideMenu(By by)
        {
            _driverWait.Until(ExpectedConditions.ElementExists(by));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(by));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(by));
            driver.FindElement(by).Click();
        }
        public static void fnWaitAdminsDiv()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ADMINSMGMT_DIV)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ADMINSMGMT_DIV)));
        }
        public static void fnWaitSuppliersDiv()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SUPPLIERSMGMT_DIV)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_SUPPLIERSMGMT_DIV)));
        }
        public static void FnSortFirstNameColumn(Sort sortMode)
        {
            string strHeaderDescOrAsc;
            Sort orderedAs = Sort.Desc;
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_FIRSTNAME_TH)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_FIRSTNAME_TH)));
            strHeaderDescOrAsc = driver.FindElement(By.XPath(STR_FIRSTNAME_TH)).GetAttribute("data-order");
            if (strHeaderDescOrAsc == "desc") { orderedAs = Sort.Desc; } else if  (strHeaderDescOrAsc == "asc"){ orderedAs = Sort.Asc; }
            try
            {
                
                do
                {
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_FIRSTNAME_TH)));
                    driver.FindElement(By.XPath(STR_FIRSTNAME_TH)).Click();
                } while (sortMode != orderedAs);
            }
            catch (Exception e)
            {
                do
                {
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_FIRSTNAME_TH)));
                    driver.FindElement(By.XPath(STR_FIRSTNAME_TH)).Click();
                } while (sortMode != orderedAs);
            }
        }
        public static void FnSortLastNameColumn(string pstrSortMode)
        {
            string strHeaderDescOrAsc;
            try
            {
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LASTNAME_TH)));
                _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LASTNAME_TH)));
                strHeaderDescOrAsc = driver.FindElement(By.XPath(STR_LASTNAME_TH)).GetAttribute("data-order");
                do
                {

                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LASTNAME_TH)));
                    driver.FindElement(By.XPath(STR_LASTNAME_TH)).Click();
                } while (pstrSortMode != strHeaderDescOrAsc);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LASTNAME_TH)));
                _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LASTNAME_TH)));
                strHeaderDescOrAsc = driver.FindElement(By.XPath(STR_LASTNAME_TH)).GetAttribute("data-order");
                do
                {
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LASTNAME_TH)));
                    driver.FindElement(By.XPath(STR_LASTNAME_TH)).Click();
                } while (pstrSortMode != strHeaderDescOrAsc);
            }
        }
        public static void FnSortEmailColumn(string pstrSortMode)
        {
            string strHeaderDescOrAsc;
            try
            {
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_EMAIL_TH)));
                _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_EMAIL_TH)));
                strHeaderDescOrAsc = driver.FindElement(By.XPath(STR_EMAIL_TH)).GetAttribute("data-order");
                do
                {

                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_EMAIL_TH)));
                    driver.FindElement(By.XPath(STR_EMAIL_TH)).Click();
                } while (pstrSortMode != strHeaderDescOrAsc);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_EMAIL_TH)));
                _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_EMAIL_TH)));
                strHeaderDescOrAsc = driver.FindElement(By.XPath(STR_EMAIL_TH)).GetAttribute("data-order");
                do
                {
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_EMAIL_TH)));
                    driver.FindElement(By.XPath(STR_EMAIL_TH)).Click();
                } while (pstrSortMode != strHeaderDescOrAsc);
            }
        }
        public static void FnSortActiveColumn(string pstrSortMode)
        {
            string strHeaderDescOrAsc;
            try
            {
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ACTIVE_TH)));
                _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ACTIVE_TH)));
                strHeaderDescOrAsc = driver.FindElement(By.XPath(STR_ACTIVE_TH)).GetAttribute("data-order");
                do
                {

                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_ACTIVE_TH)));
                    driver.FindElement(By.XPath(STR_ACTIVE_TH)).Click();
                } while (pstrSortMode != strHeaderDescOrAsc);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ACTIVE_TH)));
                _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ACTIVE_TH)));
                strHeaderDescOrAsc = driver.FindElement(By.XPath(STR_ACTIVE_TH)).GetAttribute("data-order");
                do
                {
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_ACTIVE_TH)));
                    driver.FindElement(By.XPath(STR_ACTIVE_TH)).Click();
                } while (pstrSortMode != strHeaderDescOrAsc);
            }
        }
        public static void FnSortLastLoginColumn(string pstrSortMode)
        {
            string strHeaderDescOrAsc;
            try
            {
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LASTLOGIN_TH)));
                _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LASTLOGIN_TH)));
                strHeaderDescOrAsc = driver.FindElement(By.XPath(STR_LASTLOGIN_TH)).GetAttribute("data-order");
                do
                {

                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LASTLOGIN_TH)));
                    driver.FindElement(By.XPath(STR_LASTLOGIN_TH)).Click();
                } while (pstrSortMode != strHeaderDescOrAsc);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LASTLOGIN_TH)));
                _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LASTLOGIN_TH)));
                strHeaderDescOrAsc = driver.FindElement(By.XPath(STR_LASTLOGIN_TH)).GetAttribute("data-order");
                do
                {
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LASTLOGIN_TH)));
                    driver.FindElement(By.XPath(STR_LASTLOGIN_TH)).Click();
                } while (pstrSortMode != strHeaderDescOrAsc);
            }
        }

        public static void FnWaitFirstNameSortedDesc()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_FIRSTNAMEDESC_TH)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_FIRSTNAMEDESC_TH)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_FIRSTNAMEDESC_TH)));
        }
        public static void FnWaitFirstNameSortedAsc()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_FIRSTNAMEASC_TH)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_FIRSTNAMEASC_TH)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_FIRSTNAMEASC_TH)));
        }
        public static void FnWaitLastNameSortedDesc()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LASTNAMEDESC_TH)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LASTNAMEDESC_TH)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LASTNAMEDESC_TH)));
        }
        public static void FnWaitLastNameSortedAsc()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LASTNAMEASC_TH)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LASTNAMEASC_TH)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LASTNAMEASC_TH)));
        }
        public static void FnWaitEmailSortedDesc()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_EMAILDESC_TH)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_EMAILDESC_TH)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_EMAILDESC_TH)));
        }
        public static void FnWaitEmailSortedAsc()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_EMAILASC_TH)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_EMAILASC_TH)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_EMAILASC_TH)));
        }
        public static void FnWaitActiveSortedDesc()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ACTIVEDESC_TH)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ACTIVEDESC_TH)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_ACTIVEDESC_TH)));
        }
        public static void FnWaitActiveSortedAsc()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ACTIVEASC_TH)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ACTIVEASC_TH)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_ACTIVEASC_TH)));
        }
        public static void FnWaitLastLoginSortedDesc()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LASTLOGINDESC_TH)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LASTLOGINDESC_TH)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LASTLOGINDESC_TH)));
        }
        public static void FnWaitLastLoginSortedAsc()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LASTLOGINASC_TH)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LASTLOGINASC_TH)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LASTLOGINASC_TH)));
        }        
        public static IList<string> FnGetCellsFromColumn(int intColId)
        {
            IList<string> lstColumnCells = new List<string>();
            IList<IWebElement> cells = driver.FindElements(By.XPath($"//table[@class='xcrud-list table table-striped table-hover']/tbody//td[{intColId.ToString()}]"));
            foreach (IWebElement cell in cells)
            {
                lstColumnCells.Add(cell.Text);
            }
            return lstColumnCells;
        }

        public static IList<string> FnSortColumnCells(IList<string> plstColumnCells, Sort sortMode)
        {
            IList<string> lstSortedColumnCells = new List<string>();
            if(sortMode == Sort.Asc)
            {
                lstSortedColumnCells = plstColumnCells.OrderBy(q => q).ToList();
            }
            else if (sortMode == Sort.Desc)
            {
                lstSortedColumnCells = plstColumnCells.OrderByDescending(q => q).ToList();
            }
            return lstSortedColumnCells;
        }
    }
}