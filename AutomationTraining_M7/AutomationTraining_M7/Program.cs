using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.RodrigoDominguez_M7_Final;
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
            CommissionEmployee Commission = new CommissionEmployee(5);
            SalaryEmployee Salary = new SalaryEmployee(180, "Rodrigo", 10);
            HourlyEmployee Hourly = new HourlyEmployee(120, "Pepe", 5, 40);
            Console.WriteLine("***Salary");
            Salary.fnDisplayInfo();
            Console.WriteLine("***Hours");
            Hourly.fnDisplayInfo();
            Console.WriteLine("***Commission");
            Commission.fnDisplayInfo();
            Console.ReadKey();

        }
    }
}
