using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Carlos_Paz_M7_Final;
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
            Console.WriteLine("Hourly Employee");
            HourlyEmployee hourly = new HourlyEmployee(1, "Roberto", 40, 50);
            hourly.fnDisplayInfo();

            Console.WriteLine();

            Console.WriteLine("Salary Employee");
            SalaryEmployee salary = new SalaryEmployee(2,"Carlos",5000);
            salary.fnDisplayInfo();

            Console.WriteLine();
            
            Console.WriteLine("Commission Employee");
            CommissionEmployee commission = new CommissionEmployee(3, "Juan", 5000, 2000);
            commission.fnDisplayInfo();

            Console.WriteLine();

            Console.WriteLine("Press any key to close");

            Console.ReadKey();

        }
    }
}
