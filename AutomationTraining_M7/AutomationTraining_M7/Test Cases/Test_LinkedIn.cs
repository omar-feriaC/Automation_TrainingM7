using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_LinkedIn : BaseTest
    {
        LinkedIn_LoginPage objLogin;

        [Test]
        public void Login_LinkedIn()
        {
            objLogin = new LinkedIn_LoginPage(driver);
            Assert.AreEqual(true, driver.Title.Contains("Login"), "Title not match");
            LinkedIn_LoginPage.fnEnterUserName(ConfigurationManager.AppSettings.Get("username")); 
            LinkedIn_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            LinkedIn_LoginPage.fnClickSignInButton();

            //Assert.AreNotEqual(true, driver.Title.Contains("Login"), "Title not match");

            //Xpath People filter
            //$x("//span[text()='People']|//span[text()='Gente']")
            //$x("//span[text()='People' or text()='Gente']")
            //Xpath AllFilters button
            //$x("//button[span[text()='All Filters']]")
        }
    }
}
