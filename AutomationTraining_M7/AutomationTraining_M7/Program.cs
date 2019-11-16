using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Edmundo_Sainz_M7_Excercise;
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
            Cls_2D_Shape obj2DS = new Cls_2D_Shape();
            obj2DS.fnDisplayInfo();

            Console.WriteLine("****************");

            Cls_3D_Shape obj3DS = new Cls_3D_Shape();
            obj3DS.fnDisplayInfo();
            
            Console.WriteLine("****************");

            Rectangle objRect = new Rectangle(1,2);
            objRect.fnDisplayInfo();

            Console.WriteLine("****************");

            Pyramid objPyra = new Pyramid(1, 2, 3);
            objPyra.fnDisplayInfo();

            Console.ReadKey();
        }
    }
}
