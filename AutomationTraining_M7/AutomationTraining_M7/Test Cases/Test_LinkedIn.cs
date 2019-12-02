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
    class Test_LinkedIn : Base_Files.LinkedIn_LoginPage
    {
        Page_Objects.LinkedIn_LoginPage objLogin;

        [Test]
        public void Login_LinkedIn()
        {
            objLogin = new Page_Objects.LinkedIn_LoginPage(driver);
            Assert.AreEqual(true, driver.Title.Contains("Login"), "Title not mach");
            Page_Objects.LinkedIn_LoginPage.fnEnterUserName(ConfigurationManager.AppSettings.Get("username"));
            Page_Objects.LinkedIn_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            Page_Objects.LinkedIn_LoginPage.fnClickSignInButton();
            
            //Assert.AreEqual(true, driver.Title.Contains("Login,"), "Title not mach");
            //Assert.AreEqual(driver.Title, "AnotherTitle");
            Assert.AreNotEqual(true, driver.Title.Contains("Login"), "Title not mach");
            //Assert.IsTrue(driver.Title.Contains("LinkedIn"));
        }



    }
}
