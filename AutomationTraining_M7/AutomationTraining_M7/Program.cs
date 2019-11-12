using AutomationTraining_M7.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTraining_M7.Jose_Tziu_M7_Excercise;

namespace AutomationTraining_M7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Radius:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(radius);
            

            Console.WriteLine("Input Height:");
            double height = Convert.ToDouble(Console.ReadLine());
            Cone cone = new Cone(radius, height);

            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            Console.WriteLine($"Circle Perimeter: {circle.CalculatePerimeter()}");

            Console.WriteLine($"Cone BaseArea: {cone.CalculateBaseArea()}");
            Console.WriteLine($"Cone Volume:{cone.CalculateVolume()}");
            Console.WriteLine($"Cone Perimeter:{cone.CalculatePerimeter()}");
            Console.ReadKey();
        }
    }
}
