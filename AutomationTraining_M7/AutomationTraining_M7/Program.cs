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
            string[] arr1;
            int n, i;

            Console.Write("\nLINQ : Print the lenght of the strings in the array : ");
            Console.Write("\n------------------------------------------------------\n");

            //Write Your code Here
            Console.Write("Provide the number (if enter a value different a number the program will be fail): ");
            n = Convert.ToInt32(Console.ReadLine());
            arr1 = new string[n];
            Console.Write($"\nProvide {n} string for the array :\n");

            for (i = 0; i < n; i++)
            {
                Console.Write($"String[{i}] : ");
                arr1[i] = Console.ReadLine();
            }

            var strings = from element in arr1
                          select element;
            Console.WriteLine("\n");

            foreach (var element in strings)
            {
                Console.WriteLine($"String: {element}, Length: {element.Length}");
            }




            //-------------------------------------------------
            //Excersie 2
            //-------------------------------------------------
            string[] dirfiles = Directory.GetFiles("C:/Test");
            // there are three files in the directory abcd are :
            // abcd.txt, simple_file.txt and xyz.txt

            Console.Write("\nLINQ : Calculate the Size of File : ");
            Console.Write("\n---------------------------------\n");

            //Write Your code
            var files = from file in dirfiles
                        select file;


            foreach (var file in files)
            {
                FileInfo objFile = new FileInfo(file);
                Console.WriteLine($"File Name: {objFile.Name} -  Size of the File: {objFile.Length} bytes ");

            }

            Console.ReadLine();





            //-------------------------------------------------
            //Excersie 3
            //-------------------------------------------------
            //  The first part is Data source.
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("\nBasic structure of LINQ : ");
            Console.Write("\n---------------------------");

            //Write Your code
            var integers = from integer in n1
                           select integer;
            int d = 1;

            Console.Write($"\nData Source : Array n1 ");
            Console.Write($"\nQuery : from integer in select integer; ");

            Console.Write("\nQuery Execution :  \n ");

            foreach (var integer in integers)
            {
                Console.WriteLine($"Value {d}: {integer}");
                d++;
            }

            Console.ReadLine();

                                          
            //-------------------------------------------------
            //Excersie 4
            //-------------------------------------------------
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.Write("\nLINQ : Display the name of the days of a week : ");
            Console.Write("\n------------------------------------------------\n");

            //Write Your code
            int x = 1;
            var days = from day in dayWeek
                       select day;

            foreach (var day in days)
            {
                Console.WriteLine($"Day{x}: {day}");
                x++;
            }

            Console.ReadLine();





            //-------------------------------------------------
            //Excersie 5
            //-------------------------------------------------
            var arr3 = new[] { 3, 9, 2, 8, 6, 5 };

            Console.Write("\nLINQ : Print the number and its square from an array: ");
            Console.Write("\n------------------------------------------------------------------------\n");

            //Write Your code
            var numbers = from number in arr3
                          select number;

            foreach (var number in numbers)
            {
                Console.WriteLine($"Number: {number}, Square: {number * number}");


            }
                                 
            Console.ReadLine();

        }
    }

}
