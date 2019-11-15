using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.M7_Review;
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

            Console.ReadKey();
        }
    }
}
