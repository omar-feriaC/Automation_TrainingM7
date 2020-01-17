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
            string temp1;
            //int temp1;
            do
            {
                Console.Write("How many strings will you save? (Type only numbers)\n");
                temp1 = Console.ReadLine();

                //if (temp1 != null)
                if (!string.IsNullOrEmpty(temp1))//was trying to also add non numbers but already took too much time :(
                {
                    Console.WriteLine($"Thank you.\n");
                    n = Convert.ToInt32(temp1);
                    arr1 = new string[n];

                    for (i = 0; i < n; i++)
                    {
                        Console.Write($"Type String #{i + 1}:");
                        arr1[i] = Console.ReadLine();
                    }

                    Console.Write("\n------------------------------------------------------\n");
                    var stringQuery = from value in arr1
                                      select value;

                    foreach (var value in stringQuery)
                    {
                        Console.Write($"Value: {value}\t Lenght: {value.Length}\n");
                    }
                }
                else
                {
                    Console.WriteLine("Empty input, please try again");
                }
            }
            //while (temp1 = null);
            while (string.IsNullOrEmpty(temp1));

            Console.ReadLine();

            var dir = @"C:/Test";  // folder location

            if (!Directory.Exists(dir))  // if it doesn't exist, create
                Directory.CreateDirectory(dir);

            // use Path.Combine to combine 2 strings to a path
            File.WriteAllText(Path.Combine(dir, "abcd.txt"), "test1");
            File.WriteAllText(Path.Combine(dir, "simple_file.txt"), "test2");
            File.WriteAllText(Path.Combine(dir, "xyz.txt"), "test3");
            //-------------------------------------------------
            //Excersie 2
            //-------------------------------------------------

            string[] dirfiles = Directory.GetFiles("C:/Test");
            // there are three files in the directory abcd are :
            // abcd.txt, simple_file.txt and xyz.txt

            Console.Write("\nLINQ : Calculate the Size of File : ");
            Console.Write("\n------------------------------------\n");

            //Write Your code
            var files = from file in dirfiles
                        select file;

            foreach (var file in files)
            {
                FileInfo objFile = new FileInfo(file);
                Console.WriteLine($"File: {objFile.Name}\t Size: {objFile.Length} bytes");
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
            Console.ReadLine();





            //-------------------------------------------------
            //Excersie 4
            //-------------------------------------------------
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.Write("\nLINQ : Display the name of the days of a week : ");
            Console.Write("\n------------------------------------------------\n");

            //Write Your code
            Console.ReadLine();





            //-------------------------------------------------
            //Excersie 5
            //-------------------------------------------------
            var arr3 = new[] { 3, 9, 2, 8, 6, 5 };

            Console.Write("\nLINQ : Print the number and its square from an array: ");
            Console.Write("\n------------------------------------------------------------------------\n");

            //Write Your code
            Console.ReadLine();

        }
    }

}
