using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.M7_Exercise.Jaime_Couoh_M7_Exercise;
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
            Console.WriteLine("-----Square----");
            clsSquare objSquare = new clsSquare(4, "Square");
            objSquare.FnCalculateArea();
            objSquare.FnCalculatePerimtr();
            objSquare.DisplayInfo();

            Console.WriteLine();
            Console.WriteLine("-----Prism----");
            clsPrism objPrism = new clsPrism(2,6, "Prism");
            objPrism.FnCalculateVolume();
            objPrism.DisplayInfo();
                                               
            Console.ReadKey();
        }
    }
}
