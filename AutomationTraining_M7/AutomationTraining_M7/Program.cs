using AutomationTraining_M7.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.DanielLuna_M7_Final
{
    class Program 
    {
        static void Main(string[] args)
        {
            SalaryEmployee objSalaryEmployee1 = new SalaryEmployee(2000, 1001, "Daniel");
            objSalaryEmployee1.fnDisplayInfo();

            Console.WriteLine("**********************");

            HourlyEmployee objHourlyEmployee1 = new HourlyEmployee(40, 50, 1001, "Daniel");
            objHourlyEmployee1.fnCalculatePayroll();
            objHourlyEmployee1.fnDisplayInfo();

            Console.WriteLine("**********************");

            CommissionEmployee objCommission1 = new CommissionEmployee(500, 2000, 1001, "Daniel");
            objCommission1.fnCalculatePayroll();
            objCommission1.fnDisplayInfo();

            Console.ReadKey();

        }
    }
}
