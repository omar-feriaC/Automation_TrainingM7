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

            Console.WriteLine("*****2D Figure*****");
            Pentagon objPentagon = new Pentagon(4, 5);
            objPentagon.fnDisplayInfo();

            Console.WriteLine();

            Console.WriteLine("*****3D Figure*****");
            Pentaedrom objPentaedrom = new Pentaedrom(6, 4, 5);
            objPentaedrom.fnDisplayInfo();

            Console.ReadKey();
        }
    }
}
