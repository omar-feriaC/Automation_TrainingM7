using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Rodrigo_Dominguez_M7;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7 {
    class Program {
        static void Main(string[] args)
        {
            Triangle x = new Triangle(3.3, 2.2, 3, 4, 5, "TriangleTest");
            Prism y = new Prism(5.5, 4, "PrismTest");
            x.DisplayInfo();
            y.DisplayInfo();
            Console.ReadKey();

        }
    }
}
