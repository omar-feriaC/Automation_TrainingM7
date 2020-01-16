using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {
        [Test]
        public void Test_M9Exercise()
        {
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);

            //Login action(s)
            Assert.AreEqual(true, driver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail(ConfigurationManager.AppSettings.Get("email"));
            clsPHPTravels_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            //Dashboard action(s)
            Console.WriteLine(ClsPHPTravels_Dashboard_Page.GetTotalAdminsLink().Text);
            objTest.Log(Status.Info, ClsPHPTravels_Dashboard_Page.GetTotalAdminsLink().Text);
            Console.WriteLine(ClsPHPTravels_Dashboard_Page.GetTotalSuppliersLink().Text);
            objTest.Log(Status.Info, ClsPHPTravels_Dashboard_Page.GetTotalSuppliersLink().Text);
            Console.WriteLine(ClsPHPTravels_Dashboard_Page.GetTotalCustomersLink().Text);
            objTest.Log(Status.Info, ClsPHPTravels_Dashboard_Page.GetTotalCustomersLink().Text);
            Console.WriteLine(ClsPHPTravels_Dashboard_Page.GetTotalGuestsLink().Text);
            objTest.Log(Status.Info, ClsPHPTravels_Dashboard_Page.GetTotalGuestsLink().Text);
            Console.WriteLine(ClsPHPTravels_Dashboard_Page.GetTotalBookingsLink().Text);
            objTest.Log(Status.Info, ClsPHPTravels_Dashboard_Page.GetTotalBookingsLink().Text);

            //Click Accounts menu & sub - menus

            //****** NOTE: the example for the excercise will be only with Suppliers since the other tables do not have data *********//
            ClsPHPTravels_Dashboard_Page.fnClickSideMenu(By.XPath("//a[contains(text(), 'Accounts')]"));
            ClsPHPTravels_Dashboard_Page.fnClickSideMenu(By.XPath("//a[contains(text(), 'Suppliers')]"));
            ClsPHPTravels_Dashboard_Page.fnWaitSuppliersDiv();
            Assert.AreEqual(true, driver.Title.Contains("Suppliers Management"), "The Suppliers grid was not loaded correctly.");

            //test
            IList<string> lstColumnCells = new List<string>();
            IList<string> lstSortedColumnCellsAsc = new List<string>();
            IList<string> lstSortedColumnCellsDesc = new List<string>();

            //sort first name in DESC order
            //ClsPHPTravels_Dashboard_Page.FnSortFirstNameColumn("desc");
            ClsPHPTravels_Dashboard_Page.FnSortFirstNameColumn(ClsPHPTravels_Dashboard_Page.Sort.Desc);
            lstSortedColumnCellsDesc = ClsPHPTravels_Dashboard_Page.FnSortColumnCells(ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(3), ClsPHPTravels_Dashboard_Page.Sort.Desc);
            ClsPHPTravels_Dashboard_Page.FnWaitFirstNameSortedDesc();
            lstColumnCells = ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(3);

            Console.WriteLine("List from WebPage");
            foreach (string s in lstColumnCells) { Console.WriteLine(s); }
            Console.WriteLine("");
            Console.WriteLine("Sorted list in desc order");
            foreach (string s in lstSortedColumnCellsDesc) { Console.WriteLine(s); }
            Console.WriteLine("");
            try
            {
                Assert.AreEqual(true, lstColumnCells.SequenceEqual(lstSortedColumnCellsDesc), "The sorting is incorrect");
                objTest.Log(Status.Pass, "First name desc sorting passed");
            }
            catch (Exception e)
            {
                objTest.Log(Status.Fail, "First name desc sorting failed " + e.ToString());
            }

            //sort first name in ASC order
            ClsPHPTravels_Dashboard_Page.FnSortFirstNameColumn(ClsPHPTravels_Dashboard_Page.Sort.Asc);
            lstSortedColumnCellsAsc = ClsPHPTravels_Dashboard_Page.FnSortColumnCells(ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(3), ClsPHPTravels_Dashboard_Page.Sort.Asc);
            ClsPHPTravels_Dashboard_Page.FnWaitFirstNameSortedAsc();
            lstColumnCells = ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(3);

            Console.WriteLine("List from WebPage");
            foreach (string s in lstColumnCells) { Console.WriteLine(s); }
            Console.WriteLine("");
            Console.WriteLine("Sorted list in asc order");
            foreach (string s in lstSortedColumnCellsAsc) { Console.WriteLine(s); }
            Console.WriteLine("");
            try
            {
                Assert.AreEqual(true, lstColumnCells.SequenceEqual(lstSortedColumnCellsAsc), "The sorting is incorrect");
                objTest.Log(Status.Pass, "First name asc sorting passed");
            }
            catch (Exception e)
            {
                objTest.Log(Status.Fail, "First name asc sorting failed " + e.ToString());
            }

            //sort last name in DESC order
            ClsPHPTravels_Dashboard_Page.FnSortLastNameColumn("desc");
            lstSortedColumnCellsDesc = ClsPHPTravels_Dashboard_Page.FnSortColumnCells(ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(4), ClsPHPTravels_Dashboard_Page.Sort.Desc);
            ClsPHPTravels_Dashboard_Page.FnWaitLastNameSortedDesc();
            lstColumnCells = ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(4);

            Console.WriteLine("List from WebPage");
            foreach (string s in lstColumnCells) { Console.WriteLine(s); }
            Console.WriteLine("");
            Console.WriteLine("Sorted list in desc order");
            foreach (string s in lstSortedColumnCellsDesc) { Console.WriteLine(s); }
            Console.WriteLine("");
            try
            {
                Assert.AreEqual(true, lstColumnCells.SequenceEqual(lstSortedColumnCellsDesc), "The sorting is incorrect");
                objTest.Log(Status.Pass, "last name desc sorting passed");
            }
            catch (Exception e)
            {
                objTest.Log(Status.Fail, "last name desc sorting failed " + e.ToString());
            }

            //sort last name in ASC order
            ClsPHPTravels_Dashboard_Page.FnSortLastNameColumn("asc");
            lstSortedColumnCellsAsc = ClsPHPTravels_Dashboard_Page.FnSortColumnCells(ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(4), ClsPHPTravels_Dashboard_Page.Sort.Asc);
            ClsPHPTravels_Dashboard_Page.FnWaitLastNameSortedAsc();
            lstColumnCells = ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(4);

            Console.WriteLine("List from WebPage");
            foreach (string s in lstColumnCells) { Console.WriteLine(s); }
            Console.WriteLine("");
            Console.WriteLine("Sorted list in asc order");
            foreach (string s in lstSortedColumnCellsAsc) { Console.WriteLine(s); }
            Console.WriteLine("");
            try
            {
                Assert.AreEqual(true, lstColumnCells.SequenceEqual(lstSortedColumnCellsAsc), "The sorting is incorrect");
                objTest.Log(Status.Pass, "last name asc sorting passed");
            }
            catch (Exception e)
            {
                objTest.Log(Status.Fail, "last name asc sorting failed " + e.ToString());
            }

            //sort email in DESC order
            ClsPHPTravels_Dashboard_Page.FnSortEmailColumn("desc");
            lstSortedColumnCellsDesc = ClsPHPTravels_Dashboard_Page.FnSortColumnCells(ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(5), ClsPHPTravels_Dashboard_Page.Sort.Desc);
            ClsPHPTravels_Dashboard_Page.FnWaitEmailSortedDesc();
            lstColumnCells = ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(5);

            Console.WriteLine("List from WebPage");
            foreach (string s in lstColumnCells) { Console.WriteLine(s); }
            Console.WriteLine("");
            Console.WriteLine("Sorted list in desc order");
            foreach (string s in lstSortedColumnCellsDesc) { Console.WriteLine(s); }
            Console.WriteLine("");
            try
            {
                Assert.AreEqual(true, lstColumnCells.SequenceEqual(lstSortedColumnCellsDesc), "The sorting is incorrect");
                objTest.Log(Status.Pass, "email desc sorting passed");
            }
            catch (Exception e)
            {
                objTest.Log(Status.Fail, "email desc sorting failed " + e.ToString());
            }

            //sort email in ASC order
            ClsPHPTravels_Dashboard_Page.FnSortEmailColumn("asc");
            lstSortedColumnCellsAsc = ClsPHPTravels_Dashboard_Page.FnSortColumnCells(ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(5), ClsPHPTravels_Dashboard_Page.Sort.Asc);
            ClsPHPTravels_Dashboard_Page.FnWaitEmailSortedAsc();
            lstColumnCells = ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(5);

            Console.WriteLine("List from WebPage");
            foreach (string s in lstColumnCells) { Console.WriteLine(s); }
            Console.WriteLine("");
            Console.WriteLine("Sorted list in asc order");
            foreach (string s in lstSortedColumnCellsAsc) { Console.WriteLine(s); }
            Console.WriteLine("");
            try
            {
                Assert.AreEqual(true, lstColumnCells.SequenceEqual(lstSortedColumnCellsAsc), "The sorting is incorrect");
                objTest.Log(Status.Pass, "email asc sorting passed");
            }
            catch (Exception e)
            {
                objTest.Log(Status.Fail, "email asc sorting failed " + e.ToString());
            }

            //sort active in DESC order
            ClsPHPTravels_Dashboard_Page.FnSortActiveColumn("desc");
            lstSortedColumnCellsDesc = ClsPHPTravels_Dashboard_Page.FnSortColumnCells(ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(6), ClsPHPTravels_Dashboard_Page.Sort.Desc);
            ClsPHPTravels_Dashboard_Page.FnWaitActiveSortedDesc();
            lstColumnCells = ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(6);

            Console.WriteLine("List from WebPage");
            foreach (string s in lstColumnCells) { Console.WriteLine(s); }
            Console.WriteLine("");
            Console.WriteLine("Sorted list in desc order");
            foreach (string s in lstSortedColumnCellsDesc) { Console.WriteLine(s); }
            Console.WriteLine("");
            try
            {
                Assert.AreEqual(true, lstColumnCells.SequenceEqual(lstSortedColumnCellsDesc), "The sorting is incorrect");
                objTest.Log(Status.Pass, "active desc sorting passed");
            }
            catch (Exception e)
            {
                objTest.Log(Status.Fail, "active desc sorting failed " + e.ToString());
            }

            //sort active in ASC order
            ClsPHPTravels_Dashboard_Page.FnSortActiveColumn("asc");
            lstSortedColumnCellsAsc = ClsPHPTravels_Dashboard_Page.FnSortColumnCells(ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(6), ClsPHPTravels_Dashboard_Page.Sort.Asc);
            ClsPHPTravels_Dashboard_Page.FnWaitActiveSortedAsc();
            lstColumnCells = ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(6);

            Console.WriteLine("List from WebPage");
            foreach (string s in lstColumnCells) { Console.WriteLine(s); }
            Console.WriteLine("");
            Console.WriteLine("Sorted list in asc order");
            foreach (string s in lstSortedColumnCellsAsc) { Console.WriteLine(s); }
            Console.WriteLine("");
            try
            {
                Assert.AreEqual(true, lstColumnCells.SequenceEqual(lstSortedColumnCellsAsc), "The sorting is incorrect");
                objTest.Log(Status.Pass, "active asc sorting passed");
            }
            catch (Exception e)
            {
                objTest.Log(Status.Fail, "active asc sorting failed " + e.ToString());
            }

            //sort last login in DESC order
            ClsPHPTravels_Dashboard_Page.FnSortLastLoginColumn("desc");
            lstSortedColumnCellsDesc = ClsPHPTravels_Dashboard_Page.FnSortColumnCells(ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(7), ClsPHPTravels_Dashboard_Page.Sort.Desc);
            ClsPHPTravels_Dashboard_Page.FnWaitLastLoginSortedDesc();
            lstColumnCells = ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(7);

            Console.WriteLine("List from WebPage");
            foreach (string s in lstColumnCells) { Console.WriteLine(s); }
            Console.WriteLine("");
            Console.WriteLine("Sorted list in desc order");
            foreach (string s in lstSortedColumnCellsDesc) { Console.WriteLine(s); }
            Console.WriteLine("");
            try
            {
                Assert.AreEqual(true, lstColumnCells.SequenceEqual(lstSortedColumnCellsDesc), "The sorting is incorrect");
                objTest.Log(Status.Pass, "last login desc sorting passed");
            }
            catch (Exception e)
            {
                objTest.Log(Status.Fail, "last login desc sorting failed " + e.ToString());
            }

            //sort last login in ASC order
            ClsPHPTravels_Dashboard_Page.FnSortLastLoginColumn("asc");
            lstSortedColumnCellsAsc = ClsPHPTravels_Dashboard_Page.FnSortColumnCells(ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(7), ClsPHPTravels_Dashboard_Page.Sort.Asc);
            ClsPHPTravels_Dashboard_Page.FnWaitLastLoginSortedAsc();
            lstColumnCells = ClsPHPTravels_Dashboard_Page.FnGetCellsFromColumn(7);

            Console.WriteLine("List from WebPage");
            foreach (string s in lstColumnCells) { Console.WriteLine(s); }
            Console.WriteLine("");
            Console.WriteLine("Sorted list in asc order");
            foreach (string s in lstSortedColumnCellsAsc) { Console.WriteLine(s); }
            Console.WriteLine("");
            try
            {
                Assert.AreEqual(true, lstColumnCells.SequenceEqual(lstSortedColumnCellsAsc), "The sorting is incorrect");
                objTest.Log(Status.Pass, "last login asc sorting passed");
            }
            catch (Exception e)
            {
                objTest.Log(Status.Fail, "last login asc sorting failed " + e.ToString());
            }
        }
    }
}
