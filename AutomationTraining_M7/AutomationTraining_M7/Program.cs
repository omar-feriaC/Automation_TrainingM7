using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Luis_Esperon_M7_Excercise;
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
    class Program : Shape2D
    {
        static void Main(string[] args)
        {

            Shape2D objS2D = new Shape2D();
            objS2D.fnDisplayInfo();


            Console.WriteLine("********************");

            Shape3D objS3D = new Shape3D();
            objS3D.fnDisplayInfo();


            Console.WriteLine("********************");

            Pentagon objPentagon1 = new Pentagon(5, 10);

            objPentagon1.fnDisplayInfo();

            Console.ReadKey();
            
        }
    }
}
