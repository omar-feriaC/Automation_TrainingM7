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

            
            //Exercise 1
            
            string[] arr1;
            int n, i;

            Console.Write("\nLINQ : Print the lenght of the strings in the array : ");
            Console.Write("\n------------------------------------------------------\n");

            //Write Your code Here

            Console.Write("Input number of strings to  store in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            arr1 = new string[n];
            Console.Write("\nInput {0} strings for the array  :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Element[{0}] : ", i);
                arr1[i] = Console.ReadLine();
            }

            var words = from word in arr1
                        select word;

            foreach (var word in words)
            {
                Console.WriteLine("Word: {0}, Length: {1}", word, word.Length);
            }


            Console.ReadLine();
           
            //Exercise 2
            
            string[] dirfiles = Directory.GetFiles("C:/Users/Mau/Documents/MauricioG_M10");
            

            Console.Write("\nLINQ : Calculate the Size of File : ");
            Console.Write("\n------------------------------------\n");

            //Write Your code
            if (dirfiles.Count() > 0)
            {
                Console.WriteLine("Number of files: " + dirfiles.Count());

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


            
            //Exercise 3
            
            //  The first part is Data source.
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Basic structure of LINQ : ");
            Console.WriteLine("---------------------------");

            //Write Your code

            //The Second part is LINQ Query creation.

            var numbers = from number in n1
                          select number;

            // The third part is Query execution.

            Console.WriteLine("Array contains the following numbers:");

            foreach (var number in numbers)
            {
                Console.WriteLine("{0}", number);
            }

            Console.ReadLine();


            
            //Exercise 4
            
            string[] dayWeek = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.WriteLine("LINQ : Display the name of the days of a week : ");
            Console.WriteLine("------------------------------------------------");

            //Write Your code
            var days = from day in dayWeek
                       select day;

            foreach (var day in days)
            {
                Console.WriteLine("Day of the week: {0}", day);
            }


            Console.ReadLine();


            
            //Exercise 5
            
            var arr3 = new[] { 3, 9, 2, 8, 6, 5 };

            Console.Write("\nLINQ : Print the number and its square from an array: ");
            Console.Write("\n------------------------------------------------------------------------\n");

            //Write Your code
            var squares = from square in arr3
                          select square;
            foreach (var square in squares)
            {
                double sqr = Math.Pow(square, 2);
                Console.WriteLine("Number: {0}. Square from number: {1}", square, sqr);
            }

            Console.ReadLine();

        }
    }

}
