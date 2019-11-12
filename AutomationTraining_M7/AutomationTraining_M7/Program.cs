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

namespace AutomationTraining_M7
{
    class Program : BaseTest
    {
        static void Main(string[] args)
        {
            Triangle x = new Triangle();
            Prism y = new Prism();
            x.SetValues(3.3, 2.2, 3, 4, 5);
            x.CalculatePerimeter();
            x.CalculateArea();
            y.SetValues(5.5, 3, 4);
            y.CalculateVolume();
            x.DisplayInfo();
            y.DisplayInfo();
            Console.ReadKey();
            //I did not had time to write something, I had to attend some client emails, I am very sorry about it.
            //I can retake this if needed.
            
        }
    }
}
