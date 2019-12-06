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
    class Test_LinkdIn : BaseTest
    {
        Linkedin_LoginPage objLogin;
        [Test]
        public void Login_LinkedIn()
        {
            objLogin = new Linkedin_LoginPage(driver);
            Assert.AreEqual(true, driver.Title.Contains("Login"), "title not match");
            Linkedin_LoginPage.FnEnterUserName(ConfigurationManager.AppSettings.Get("username"));
            Linkedin_LoginPage.FnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            Linkedin_LoginPage.fnClickSingInButton();
        }


    }
}
