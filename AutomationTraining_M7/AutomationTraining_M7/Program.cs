using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.FinalM7;
using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7
{
    class Program : BaseTest
    {
        static void Main(string[] args)
        {

            SetUp();
            Linkedin_LoginPage objLogin = new Linkedin_LoginPage(driver);
            Linkedin_LoginPage.FnEnterUserName(ConfigurationManager.AppSettings.Get("username"));
            Linkedin_LoginPage.FnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            Linkedin_LoginPage.fnClickSingInButton();

            
            Console.ReadKey();

        }
    }
}
