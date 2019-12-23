using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AutomationTraining_M7.Reporting;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {
        public static WebDriverWait wait2;
        clsPHPTravels_LoginPage objPHP;
        
        [Test]
        public void Test_M9Exercise()
        {
            //Init objects
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            objPHP = new clsPHPTravels_LoginPage(driver);
            //Login Action
            Assert.AreEqual(true, driver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnMinimizeLiveChat();
            clsPHPTravels_LoginPage.fnEnterEmail(ConfigurationManager.AppSettings.Get("email"));
            clsPHPTravels_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, driver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");
            clsPHPTravels_LoginPage.fnMinimizeLiveChat();


            //Print in the console and Report the totals and values for Total links
            IList <IWebElement> ElementList = driver.FindElements(By.XPath("//div[contains(@class,'serverHeader')]//li"));
            for (int x = 2; x < ElementList.Count; x++)
            {
                Console.WriteLine(ElementList[x].Text);

                objTest.Log(Status.Info, ElementList[x].Text);
            }

            //Verify all Submenus from a Menu choosen
            //Test_PHPTravels.fnGetMenuSubmenu("Accounts");

        }




        //Get Menus and Submenus
        public static void fnGetMenuSubmenu(string pstrMenuOption)
        {
            IList<IWebElement> ElementList2 = driver.FindElements(By.XPath("//a[contains(text()," + pstrMenuOption + ")]"));
            if (ElementList2.Count > 0)
            {
                ElementList2[0].Click();
                wait2.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li//a")));
                wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li//a")));
                wait2.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li//a")));
                IList<IWebElement> ElementList3 = driver.FindElements(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li//a"));
                string menuPath = "//ul[@id='" + pstrMenuOption.ToUpper() + "']//li//a";
                for (int i = 0; i < ElementList3.Count; i++)
                {
                    //string status;

                    //Adding a Switch to work on every page and verify asserts work
                    switch (i)
                    {
                        case 0:
                            wait2.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            wait2.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            ElementList3[i].Click();
                            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
                            clsPHPTravels_LoginPage.fnMinimizeLiveChat();
                            Assert.AreEqual(true, driver.Title.Contains("Admins Management"), "The Submenu page did not load correctly.");

                            try
                            {
                                clsPHPTravels_LoginPage.objFirstNHeader.Click();
                                clsDriver.fnWaitForElementToExist(By.XPath("//th[contains(text(),'↓ Last Name')]"));
                                clsDriver.fnWaitForElementToBeVisible(By.XPath("//th[contains(text(),'↓ Last Name')]"));
                                Assert.AreEqual(true, driver.FindElements(By.XPath("//th[contains(text(),'↓ Last Name')]")).Count > 0, "Information was sorted in descending way");
                                //status = "Passed";
                                objTest.Log(Status.Pass, "First Sort Worked As Expected");
                                //timeDate.substring("Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss"));
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information is sorted correctly", status, "");
                            }

                            catch
                            {
                                //status = "Failed";
                                //var timeDate = "Sub1_FN_Filter" + date.ToString("MMddyyyy_HHmmss");
                                //clsReportManager.fnStepCaptureImage(pobjExtent, pobjTest, pobjDriver, "Information was not sorted", status, timeDate);
                                Assert.Fail();
                                objTest.Log(Status.Pass, "First Sort Did Not Worked As Expected");
                            }



                            ElementList2[0].Click();

                            break;

                        case 1:
                            wait2.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            wait2.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            ElementList3[i].Click();
                            Assert.AreEqual(true, driver.Title.Contains("Suppliers Management"), "The Submenu page did not load correctly.");

                            break;

                        case 2:
                            wait2.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            wait2.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            ElementList3[i].Click();
                            Assert.AreEqual(true, driver.Title.Contains("Customers Management"), "The Submenu page did not load correctly.");

                            break;

                        case 3:
                            wait2.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            wait2.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//ul[@id='" + pstrMenuOption.ToUpper() + "']//li[" + i + "]//a")));
                            ElementList3[i].Click();
                            Assert.AreEqual(true, driver.Title.Contains("Admins Management"), "The Submenu page did not load correctly.");

                            break;

                        default:

                            continue;
                    }

                }


            }
        }
    }
}
