using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.EdmundoSainz_M7_Final;
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salary Employee****************");
            SalaryEmployee objSEmp = new SalaryEmployee(1,"Jorge",10 );
            objSEmp.fnDisplayInfo();
            Console.WriteLine("Hourly Employee****************");
            HourlyEmployee objHEmp = new HourlyEmployee(1, "Jorge", 10, 2);
            objHEmp.fnDisplayInfo();
            Console.WriteLine("Commission Employee****************");
            CommissionEmployee objCEmp = new CommissionEmployee(1, "Jorge", 10, 2);
            objCEmp.fnDisplayInfo();
            Console.ReadKey();

        }
    }
}
