using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Mauricio_Guillermo_M7_Excercise;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog; //NuGet Added

namespace AutomationTraining_M7
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Trapezium objTrapezium = new Trapezium(5, 8, 10, 9);
            objTrapezium.fnDisplayInfo();


            Console.WriteLine("-------------------");

            Cube objCube = new Cube(4);
            objCube.fnDisplayInfo();
            
            Console.ReadKey();
        }
    }
}
