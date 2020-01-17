﻿using AutomationTraining_M7.Base_Files;
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
            string[] arr1; 
            int n, i;

            Console.Write("\nLINQ : Print the lenght of the strings in the array : ");
            Console.Write("\n------------------------------------------------------\n");

            //Write Your code Here

            Console.Write("How many elements will include your array? :");
            n = Convert.ToInt32(Console.ReadLine());
            arr1 = new string[n];
            Console.Write("\nEnter {0} strings for the array  :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Element[{0}] : ", i);
                arr1[i] = Console.ReadLine();
            }

            var elements = from element in arr1
                       select element;

            foreach (var element in elements)
            {
                Console.WriteLine("String: {0}, Length: {1}", element, element.Length);
            }

            Console.ReadLine();
            

            


            //-------------------------------------------------
            //Excersie 2
            //-------------------------------------------------
            string[] dirfiles = Directory.GetFiles(@"C:\Users\DanielEnriqueLunaRiv\Documents\Automation\M10 Ex\");
            // there are three files in the directory abcd are :
            // abcd.txt, simple_file.txt and xyz.txt

            Console.Write("\nLINQ : Calculate the Size of File : ");
            Console.Write("\n------------------------------------\n");

            //Write Your code

            if (dirfiles.Count() > 0)
            {
                Console.WriteLine("Number of files in the Directory: " + dirfiles.Count());

                var files = from file in dirfiles
                            select file;

                foreach (var file in files)
                {
                    long size = new FileInfo(file).Length;

                    Console.WriteLine("File Name: {0}, Size in bytes: {1}", file
                        , size);

                }

            }

            Console.ReadLine();

            



            //-------------------------------------------------
            //Excersie 3
            //-------------------------------------------------
            //  The first part is Data source.
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("\nBasic structure of LINQ : ");
            Console.WriteLine("\n---------------------------");

            //Write Your code

            //The Second part is create the query in LINQ.

            var numbers = from number in n1
                         select number;

            // The third part is Query execution.

            Console.WriteLine("Array contains the following numbers:");

            foreach (var number in numbers)
            {
                Console.WriteLine("{0}", number);
            }

            Console.ReadLine();

            

            

            //-------------------------------------------------
            //Excersie 4
            //-------------------------------------------------
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.Write("\nLINQ : Display the name of the days of a week : ");
            Console.Write("\n------------------------------------------------\n");

            //Write Your code
            var days = from day in dayWeek
                          select day;
            
            Console.WriteLine("A week consist on the following days:");

            foreach (var day in days)
            {
                Console.WriteLine("{0}", day);
            }
            Console.ReadLine();
            



            
            //-------------------------------------------------
            //Excersie 5
            //-------------------------------------------------
            var arr3 = new[] { 3, 9, 2, 8, 6, 5 };

            Console.Write("\nLINQ : Print the number and its square from an array: ");
            Console.Write("\n------------------------------------------------------------------------\n");

            //Write Your code

            var numbers2 = from number in arr3
                          select number;
            foreach ( var num in numbers2)
            {
                double sqr = Math.Pow(num, 2);
                Console.WriteLine("Number: {0}. Square of the number: {1}", num, sqr);
            }

            Console.ReadLine();


            
        }
    }

}
