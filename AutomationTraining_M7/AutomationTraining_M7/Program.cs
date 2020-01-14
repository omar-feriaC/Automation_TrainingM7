using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.LINQ_Tests;
using AutomationTraining_M7.Page_Objects;
using AutomationTraining_M7.Reporting;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7
{
    class Program : BaseTest
    {
        static void Main(string[] args)
        {
            LINQ_Exercises objLINQ = new LINQ_Exercises();

            objLINQ.Exercise1();
            /*objLINQ.Exercise2();
            objLINQ.Exercise3();
            objLINQ.Exercise4();
            objLINQ.Exercise5();*/
            Console.ReadKey();
        }
    }

}
