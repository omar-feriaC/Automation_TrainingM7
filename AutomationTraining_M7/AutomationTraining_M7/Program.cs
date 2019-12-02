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
    class Program : Base_Files.LinkedIn_LoginPage
    {
        static void Main(string[] args)
        {
            SetUp();
            Page_Objects.LinkedIn_LoginPage objLogin = new Page_Objects.LinkedIn_LoginPage(driver);
            Page_Objects.LinkedIn_LoginPage.fnEnterUserName(ConfigurationManager.AppSettings.Get("username"));
            Page_Objects.LinkedIn_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            Page_Objects.LinkedIn_LoginPage.fnClickSignInButton();

            /*
            SalaryEmployee objSalary = new SalaryEmployee(0, "Carlos Ruiz", 100.10);
            HourlyEmployee objHourly = new HourlyEmployee(1, "Cesar Padilla", 5, 10.5);
            CommissionEmployee objComm = new CommissionEmployee(2, "Omar Feria", 1000, 500.30);

            objSalary.fnDisplayInfo();
            objHourly.fnDisplayInfo();
            objComm.fnDisplayInfo();
            */

            Console.ReadKey();

        }
    }
}
