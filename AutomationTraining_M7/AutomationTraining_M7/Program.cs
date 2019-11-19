using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Daniel_Luna_M7_Exercise;
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
            Shape2D objS2D = new Shape2D();
            objS2D.fnDisplayInfo();

            Console.WriteLine("**********************");

            Shape3D objS3D = new Shape3D();
            objS3D.fnDisplayInfo();

            Console.WriteLine("**********************");

            Pentagon objPentagon1 = new Pentagon(5, 10);
            objPentagon1.fnDisplayInfo();

            Console.WriteLine("**********************");

            Cone objCone1 = new Cone(5, 5);
            objCone1.fnDisplayInfo();

            Console.ReadKey();
            
        }
    }
}
