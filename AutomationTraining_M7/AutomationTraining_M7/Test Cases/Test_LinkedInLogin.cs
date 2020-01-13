using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_LinkedInLogin : BaseTest
    {
        LinkedIn_LoginPage objLogin;

        [Test]
        public void TestLogin()
        {
            objLogin = new LinkedIn_LoginPage(driver);
            Assert.AreEqual(true, driver.Title.Contains("Login"), "Could not find the login page https://www.linkedin.com/login");
            LinkedIn_LoginPage.fnEnterUserName(ConfigurationManager.AppSettings.Get("username"));
            LinkedIn_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            LinkedIn_LoginPage.fnClickSignInBtn();

            Assert.AreNotEqual(true, driver.Title.Contains("Login"), "Login Failed");
        }

    }
}
