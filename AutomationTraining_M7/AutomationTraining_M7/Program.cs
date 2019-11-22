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
            IShape objPyramid = new Pyramid(3, 3, 2);
            objPyramid.fnDisplayInfo();
            Console.WriteLine();

            IShape objPentagon2 = new Pentagon(5, 10);
            objPentagon2.fnDisplayInfo();
            Console.WriteLine();

            //Pyramid objPyramid = new Pyramid(3,3,2);
            //objPyramid.fnDisplayInfo();
            //Console.WriteLine();

            Console.WriteLine("* Interface **********************");
            IShape objPyramidI = objPyramid;
            IShape objPyramidI2 = new Pyramid(3, 5, 2);
            objPyramidI.fnDisplayInfo();
            //objPyramidI2.fnDisplayInfo();

            //Console.ReadLine();
            //Console.WriteLine("* Shape 2D**********************");
            //Shape2D objPyramid2D = objPyramid;
            //objPyramid2D.fnDisplayInfo();

            //Console.WriteLine("* Shape 3D**********************");
            //Shape3D objPyramid3d = objPyramid;
            //objPyramid3d.fnDisplayInfo();
            //IShape objPyramid2 = objPyramid;
                                 
            //Console.WriteLine("**********************");

            //Shape2D objS2D = new Shape2D();
            //objS2D.fnDisplayInfo();

            //Console.WriteLine("**********************");

            //Shape3D objS3D = new Shape3D();
            //objS3D.fnDisplayInfo();

            Console.ReadKey();
        }
    }
}
