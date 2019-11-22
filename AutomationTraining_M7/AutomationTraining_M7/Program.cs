using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.JoseNovelo_M7_Final;
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
            SalaryEmployee objSalary = new SalaryEmployee();
            objSalary.FnDisplayInfo();

            Console.WriteLine("======================================");


            HourlyEmployee objHourly = new HourlyEmployee();
            objHourly.FnDisplayInfo();

            Console.WriteLine("======================================");


            ComissionEmployee objComission = new ComissionEmployee (1010, "Jose", 100, 10);
            objComission.FnDisplayInfo();

            Console.WriteLine("======================================");
            

            Console.ReadKey();

        }
    }
}
