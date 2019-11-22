using AutomationTraining_M7.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.HectorCastillo_M7_Final
{
    class Program : BaseTest
    {
        static void Main(string[] args)
        {
            SalaryEmployee objSalaryEmployee = new SalaryEmployee(1, "Hector", 20000);
            objSalaryEmployee.fnDisplayInfo();

            Console.WriteLine("*******************************");

            Console.ReadKey();

            HourlyEmployee objHourlyEmployee = new HourlyEmployee(2, "Pedro", 5, 2);
            objHourlyEmployee.fnDisplayInfo();

            Console.WriteLine("*******************************");

            Console.ReadKey();

            ComissionEmployee objComissionEmployee = new ComissionEmployee(3, "Juan", 2000, 5);
            objComissionEmployee.fnDisplayInfo();

            Console.WriteLine("*******************************");

            Console.ReadKey();

        }
    }
}
