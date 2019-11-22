using AutomationTraining_M7.AlejandroVillarreal_M7_Final;
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
            HourlyEmployee objHourlyEmployee = new HourlyEmployee();
            objHourlyEmployee.fnDisplayInfo();


            Console.ReadKey();

        }
    }
}
