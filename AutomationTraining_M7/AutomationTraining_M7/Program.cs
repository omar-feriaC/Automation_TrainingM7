
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
    class Program 
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**********2D Class********");

            Shape2D objS2D = new Shape2D();
            objS2D.fnDisplayInfo();


            Console.WriteLine("*********3D Class**********");

            Shape3D objS3D = new Shape3D();
            objS3D.fnDisplayInfo();


            Console.WriteLine("*********PENTAGON Class**********");

            Pentagon objPentagon1 = new Pentagon(5, 10);

            objPentagon1.fnDisplayInfo();

            Console.WriteLine("*********RHOMBOID Class*********");

            Rhomboid objRhomboid1 = new Rhomboid(2, 3, 2, 4);

            objRhomboid1.fnDisplayInfo();


            Console.WriteLine("*********PENTAHEDROM Class*********");

            Pentahedrom objPentahedrom1= new Pentahedrom(3,5,6);

             objPentahedrom1.fnDisplayInfo();

            Console.ReadKey();
            
        }
    }
}
