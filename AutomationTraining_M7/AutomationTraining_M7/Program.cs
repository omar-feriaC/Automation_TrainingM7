using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.KevinMaldonado_M7_Final;
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


            SalaryEmployee objSE = new SalaryEmployee();
            objSE.fnDisplayInfo();

            Console.WriteLine("********");

            CommisionEmployee objCE = new CommisionEmployee();



         
            Console.ReadKey();
           

        }
    }
}
