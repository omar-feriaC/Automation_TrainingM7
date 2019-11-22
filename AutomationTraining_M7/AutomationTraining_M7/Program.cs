using AutomationTraining_M7.Base_Files;
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
            SalaryEmployee SEmployee = new SalaryEmployee(1, "Benito Juarez", 1000);
            HourlyEmployee HEmployee = new HourlyEmployee(2, "Miguel Hidalgo", 80, 10);
            ComissionEmployee CEmployee = new ComissionEmployee(3, "Danny Beltran", 1000, 200);

            SEmployee.FnDisplayInfo();
            HEmployee.FnDisplayInfo();
            CEmployee.FnDisplayInfo();
            Console.ReadKey();
        }
    }
}
