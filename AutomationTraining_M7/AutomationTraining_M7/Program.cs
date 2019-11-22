using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.MauricioGuillermo_M7_Final;
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
            SalaryEmployee salempl = new SalaryEmployee();
            salempl.fnDisplayInfo();
            CommissionEmployee comempl = new CommissionEmployee(12,"Mauricio",50,10 );
            comempl.fnDisplayInfo();
            HourlyEmployee hrempl = new HourlyEmployee();
            hrempl.fnDisplayInfo();
        

            Console.ReadKey();


        }
    }
}
