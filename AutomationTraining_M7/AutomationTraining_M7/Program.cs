﻿using AutomationTraining_M7.Base_Files;
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
            LinkedIn_LoginPage objLogin = new LinkedIn_LoginPage(driver);
            LinkedIn_LoginPage.fnEnterUserName(ConfigurationManager.AppSettings.Get("username"));
            LinkedIn_LoginPage.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
            LinkedIn_LoginPage.fnClickSignInButton();

            LinkedIn_SearchPage objSearch = new LinkedIn_SearchPage(driver);
            LinkedIn_SearchPage.fnEnterSearch("Jose Luis");


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
