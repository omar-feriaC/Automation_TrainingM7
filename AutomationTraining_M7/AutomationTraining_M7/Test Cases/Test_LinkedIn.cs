﻿using AutomationTraining_M7.Base_Files;
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
            Assert.AreEqual(true, driver.Title.Contains("Login,"), "Title not mach");
            LinkedIn_LoginPage.fnEnterUserName(ConfigurationManager.AppSettings.Get("username"));
            LinkedIn_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            LinkedIn_LoginPage.fnClickSignInButton();
            
            //Assert.AreEqual(true, driver.Title.Contains("Login,"), "Title not mach");
            //Assert.AreEqual(driver.Title, "AnotherTitle");
            Assert.AreNotEqual(true, driver.Title.Contains("Login,"), "Title not mach");
            Assert.IsTrue(driver.Title.Contains("LinkedIn"));
        }



    }
}
