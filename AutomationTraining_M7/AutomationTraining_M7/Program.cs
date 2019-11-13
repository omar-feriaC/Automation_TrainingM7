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
            Triangle x = new Triangle(3.3, 2.2, 3, 4, 5, "triangulin");
            Prism y = new Prism(5.5, 3, 4, "prismon");

            //Triangle x = new Triangle();
            //Prism y = new Prism();

            //x.Triangle(3.3, 2.2, 3, 4, 5, "triangulin");
            x.CalculatePerimeter();
            x.CalculateArea();
            //y.Prism(5.5, 3, 4, "prismon");
            y.CalculateVolume();
            x.DisplayInfo();
            y.DisplayInfo();
            Console.ReadKey();

        }
    }
}
