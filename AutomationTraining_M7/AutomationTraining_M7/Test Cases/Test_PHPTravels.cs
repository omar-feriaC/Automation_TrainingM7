using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {

        clsPHPTravels_LoginPage objPHP;
        [Test, Order(0)]
        public void Test_M9Exercise()
        {
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            //Init objects
            objPHP = new clsPHPTravels_LoginPage(driver);

            //Login Action
            Assert.AreEqual(true, driver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail("admin@phptravels.com");
            clsPHPTravels_LoginPage.fnEnterPassword("demoadmin");
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");
            //Init objects
            
            //Print counts in console
            Console.WriteLine(clsPHPTravels_LoginPage.GetAdminsLbl().Text);            
            Console.WriteLine(clsPHPTravels_LoginPage.GetSuppliersLbl().Text);           
            Console.WriteLine(clsPHPTravels_LoginPage.GetCustomersLbl().Text);          
            Console.WriteLine(clsPHPTravels_LoginPage.GetGuestsLbl().Text);           
            Console.WriteLine(clsPHPTravels_LoginPage.GetBookingsLbl().Text);
            //Add counts comments in report
            objTest.Log(Status.Info, (clsPHPTravels_LoginPage.GetAdminsLbl().Text));
            objTest.Log(Status.Info, (clsPHPTravels_LoginPage.GetSuppliersLbl().Text));
            objTest.Log(Status.Info, (clsPHPTravels_LoginPage.GetCustomersLbl().Text));
            objTest.Log(Status.Info, (clsPHPTravels_LoginPage.GetGuestsLbl().Text));
            objTest.Log(Status.Info, (clsPHPTravels_LoginPage.GetBookingsLbl().Text));
            
            //Select and click menu
            try 
            {
                clsPHPTravels_LoginPage.fnClickIWebElement(clsPHPTravels_LoginPage.GetElement("//div/ul/li/a[contains(text(),'Accounts')]"));
            }
            catch (Exception ex)
            {
                objTest.Log(Status.Fail, "Menu Accounts does not exist : " + ex.ToString());
            }

            
            //Select and click submenu
            List<string> lstSubmenus = GetHREFNamesFromList(clsPHPTravels_LoginPage.GetListOfElements("//div/ul/li/ul/li/a"));

            foreach (string submenu in lstSubmenus)
            {
                try {
                    clsPHPTravels_LoginPage.fnClickIWebElement(clsPHPTravels_LoginPage.GetElement("//a[contains(@href,'"+ submenu + "')]")); 
                }
                catch (Exception ex) {
                    objTest.Log(Status.Fail, "Submenu "+submenu+" does not exist : " + ex.ToString());
                }
                //Validate table and 
                clsPHPTravels_LoginPage.fnWaitTable();
                if (clsPHPTravels_LoginPage.IsTableEmpty()) {
                    objTest.Log(Status.Info, (clsPHPTravels_LoginPage.getTableHeader() + " table is empty."));
                    clsPHPTravels_LoginPage.fnClickIWebElement(clsPHPTravels_LoginPage.GetElement("//div/ul/li/a[contains(text(),'Accounts')]"));
                }
                else
                { //valdiate sorting xpath for column header button "//th/@data-order"
                    objTest.Log(Status.Info, ("Inside " + clsPHPTravels_LoginPage.getTableHeader() + " table for submenu "+ submenu + " ."));
                    int control = 1;
                    string[] pstrColumns = { "3,First Name", "4,Last Name", "5,Email", "6,Active", "7,Last Login" };
                    foreach (string col in pstrColumns)
                    {
                        //get base column value(s)
                        List<string> lstBaseValues = FnGeTWebElementsNames(clsPHPTravels_LoginPage.GetListOfElements("//table[@class='xcrud-list table table-striped table-hover']/tbody//td[" + col.Split(',').First() + "]"));
                        //click column title for sorting asc
                        clsPHPTravels_LoginPage.fnClickIWebElement(clsPHPTravels_LoginPage.GetElement("//th[contains(text(),'" + col.Split(',').Last() + "')]"));
                        //WAIT!!!!
                        clsPHPTravels_LoginPage.fnWaitElement("//th[contains(text(),'↓ " + col.Split(',').Last() + "')]");
                        //Get new column value()
                        List<string> lstSortedValFromPage = FnGeTWebElementsNames(clsPHPTravels_LoginPage.GetListOfElements("//table[@class='xcrud-list table table-striped table-hover']/tbody//td[" + col.Split(',').First() + "]"));
                        //compare /assert
                        List<string> lstManuallySorted = lstBaseValues.OrderByDescending(o => o).ToList();
                        try
                        {
                            Assert.AreEqual(true, lstSortedValFromPage.SequenceEqual(lstManuallySorted), "Column " + col.Split(',').Last()+" descendign sorting is incorrect.");
                            objTest.Log(Status.Pass, "Column " + col.Split(',').Last() + " descendign sorting is correct.");
                        }
                        catch (Exception ex)
                        {
                            objTest.Log(Status.Fail, col.Split(',').Last() + " descendign sort failed: " + ex.Message.ToString());
                            string content = System.String.Empty;
                            foreach (string cnt in lstSortedValFromPage)
                            {
                                content += cnt + " ,";
                            }
                            objTest.Log(Status.Info, col.Split(',').Last() + " page des sorted: " + content);
                            content = System.String.Empty;
                            foreach (string cnt in lstManuallySorted)
                            {
                                content += cnt + " ,";
                            }
                            objTest.Log(Status.Info, col.Split(',').Last() + " manual des sorted: " + content);
                        }
                        //Clean lists
                        lstSortedValFromPage.Clear();
                        lstManuallySorted.Clear();
                        //click column title for sorting desc
                        clsPHPTravels_LoginPage.fnClickIWebElement(clsPHPTravels_LoginPage.GetElement("//th[contains(text(),'" + col.Split(',').Last() + "')]"));
                        //WAIT!!!!
                        clsPHPTravels_LoginPage.fnWaitElement("//th[contains(text(),'↑ " + col.Split(',').Last() + "')]");
                        //Get new column value()
                        lstSortedValFromPage = FnGeTWebElementsNames(clsPHPTravels_LoginPage.GetListOfElements("//table[@class='xcrud-list table table-striped table-hover']/tbody//td[" + col.Split(',').First() + "]"));
                        //compare /assert
                        lstManuallySorted = lstBaseValues.OrderBy(o => o).ToList();
                        try
                        {
                            Assert.AreEqual(true, lstSortedValFromPage.SequenceEqual(lstManuallySorted), "Column " + col.Split(',').Last() + " ascendign sorting is incorrect.");
                            objTest.Log(Status.Pass, "Column " + col.Split(',').Last() + " ascendign sorting is correct.");
                        }
                        catch (Exception ex)
                        {
                            objTest.Log(Status.Fail, col.Split(',').Last() + " ascendign sort failed: " + ex.Message.ToString());
                            string content = System.String.Empty;
                            foreach (string cnt in lstSortedValFromPage)
                            {
                                content += cnt + " ,";
                            }
                            objTest.Log(Status.Info, col.Split(',').Last() + " page asc sorted: " + content);
                            content = System.String.Empty;
                            foreach (string cnt in lstManuallySorted)
                            {
                                content += cnt + " ,";
                            }
                            objTest.Log(Status.Info, col.Split(',').Last() + " manual asc sorted: " + content);
                        }
                        control++;
                        //click column title for 3rd time since the sorting of one column affects the first sorting of a new column
                        clsPHPTravels_LoginPage.fnClickIWebElement(clsPHPTravels_LoginPage.GetElement("//th[contains(text(),'" + col.Split(',').Last() + "')]"));
                        //WAIT!!!!
                        clsPHPTravels_LoginPage.fnWaitElement("//th[contains(text(),'↓ " + col.Split(',').Last() + "')]");
                    }

                    clsPHPTravels_LoginPage.fnClickIWebElement(clsPHPTravels_LoginPage.GetElement("//div/ul/li/a[contains(text(),'Accounts')]"));

                }

            }

        }
    }
}
