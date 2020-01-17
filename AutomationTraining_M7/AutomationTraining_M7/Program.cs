using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AutomationTraining_M7.Reporting;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7
{
    class Program
    {
        //Delegates
        delegate void LambdasNoParams(); //(1)

        


        static void Main(string[] args)
        {

            //-------------------------------------------------
            //Excersie 1
            //-------------------------------------------------
            string[] arr1 = { "Mexico", "USA", "Canada", "Australia", "Switzerland" };

            Console.Write("\nLINQ : Print the length of the strings in the array : ");
            Console.Write("\n------------------------------------------------------\n");

            //Write Your code Here
            var resultx = from w in arr1
                          select w;
            string[] strWords = resultx.ToArray();
            foreach (string w in strWords) { Console.WriteLine(w.Length.ToString()); }
            //foreach (string s in arr1){Console.WriteLine($"The length for string \"{s}\" is: {s.Length}");}
            Console.ReadLine();





            //-------------------------------------------------
            //Excersie 2
            //-------------------------------------------------
            string[] dirfiles = Directory.GetFiles("C:/Users/DannyAlexanderBeltra/Documents/Automation/Training/AutomationTraining_M7/Test/");
            // there are three files in the directory abcd are :
            // abcd.txt, simple_file.txt and xyz.txt/

            Console.Write("\nLINQ : Calculate the Size of File : ");
            Console.Write("\n------------------------------------\n");

            //Write Your code
            var res = dirfiles.Select(s => new FileInfo(s).Length.ToString());
            //fileSize = dirfiles.Select(f => new FileInfo(f).Length);
            foreach (var s in res)
            {
                //String FileSize = new FileInfo(s).Length.ToString();
                Console.WriteLine(s.ToString()); 
            }
            
            Console.ReadLine();





            //-------------------------------------------------
            //Excersie 3
            //-------------------------------------------------
            //  The first part is Data source.
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("\nBasic structure of LINQ : ");
            Console.Write("\n---------------------------\n");

            //Write Your code
            //second part
            var result = from r in n1
                         where r > 2 && r <= 7
                         select r;
            int[] intNums = result.ToArray();
            //third part
            foreach (int num in intNums){Console.WriteLine(num.ToString());}
            Console.ReadLine();





            //-------------------------------------------------
            //Excersie 4
            //-------------------------------------------------
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.Write("\nLINQ : Display the name of the days of a week :");
            Console.Write("\n------------------------------------------------\n");

            //Write Your code
            var result2 = from d in dayWeek
                          select d;
            string[] strDays = result2.ToArray();
            foreach (string day in strDays) { Console.WriteLine(day.ToString()); }
            Console.ReadLine();





            //-------------------------------------------------
            //Excersie 5
            //-------------------------------------------------
            int[] arr3 = new[] { 3, 9, 2, 8, 6, 5 };

            Console.Write("\nLINQ : Print the number and its square from an array: ");
            Console.Write("\n------------------------------------------------------------------------\n");

            //Write Your code
            var result3 = from number in arr3
                          let square = number * number
                          select "Number:" + number + ", Square:" + square;

            var numsAndSqrs = result3;
            foreach (var x in numsAndSqrs){Console.WriteLine(x);}
            Console.ReadLine();
        }
    }
}
