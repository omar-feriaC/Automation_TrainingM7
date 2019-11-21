using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Hector_Castillo_M7_Excercise;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Hector_Castillo_M7_Excercise
{
    class Program 
    {
        static void Main(string[] args)
        {
            Hexagon objHexagon1 = new Hexagon(10, 5);
            objHexagon1.fnDisplayInfo2();

            Console.WriteLine("*******************************");

            Console.ReadKey();

            Cylinder objCylinder1 = new Cylinder(5, 4);
            objCylinder1.fnDisplayInfo();
            
            Console.WriteLine("*******************************");

            Console.ReadKey();
            //IShape objHexagon2 = new Hexagon(5, 10);
            // IShape objCylinder2 = new Cylinder(2, 2);

            // objHexagon2.fnDisplayInfo();
            //objCylinder2.fnDisplayInfo();

            Console.ReadKey();

        }
    }
}
