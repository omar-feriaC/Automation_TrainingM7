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
            fnExercise1();
            fnExercise2();
            fnExercise3();
            fnExercise4();
            fnExercise5();
        }

        public static void fnExercise1()
        {
            //-------------------------------------------------
            //Excersie 1 - WRITE A PROGRAM IN C SHARP TO PRINT THE LENGTH OF A STRING FROM AN ARRAY OF STRINGS.
            //-------------------------------------------------

            int n = 0;
            int i = 0;
            var total = "";
            int number;

            Console.Write("\nLINQ : Print the lenght of the strings in the array : ");
            Console.Write("\n------------------------------------------------------\n");

            //Write Your code Here

            do
            {
                Console.Write("Insert the number of strings to write: ");
                total = Console.ReadLine();

            } while (!int.TryParse(total, out number));

            n = Convert.ToInt32(total);

            string[] arr1 = new string[n];

            Console.WriteLine();
            Console.WriteLine("Write your strings");

            for (int j = 0; j < n; j++)
            {
                Console.Write($"String {j + 1} = ");
                arr1[j] = Console.ReadLine();
            }

            var totalStrings = from words in arr1
                               select words;

            Console.WriteLine();
            Console.WriteLine("Your Strings");

            foreach (string x in totalStrings)
            {
                Console.WriteLine($"String {i + 1} = {x}, Length: {x.Length}");
                i++;
            }

            Console.WriteLine();
            Console.Write("Press any key");
            Console.ReadKey();
            Console.WriteLine();
        }

        public static void fnExercise2()
        {
            //-------------------------------------------------
            //Excersie 2 - WRITE A PROGRAM IN C SHARP TO PRINT THE SIZE OF A FILE IN BYTES IN A DIRECTORY USING LINQ.
            //-------------------------------------------------
            string[] dirfiles = Directory.GetFiles("C:/Test");

            // there are three files in the directory abcd are :
            // abcd.txt, simple_file.txt and xyz.txt

            Console.Write("\nLINQ : Calculate the Size of File : ");
            Console.Write("\n------------------------------------\n");

            var files = from x in dirfiles
                        select x;

            int i = 1;

            foreach (var fi in files)
            {
                var fil = new FileInfo(fi); 
                Console.WriteLine($"File Name: {fil.Name}, Size: {fil.Length} bytes");
                i++;
            }

            Console.WriteLine();
            Console.Write("Press any key");
            Console.ReadKey();
            Console.WriteLine();
        }

        public static void fnExercise3()
        {
            //-------------------------------------------------
            //Excersie 3 - WRITE A PROGRAM IN C SHARP TO SHOW HOW THE THREE PARTHS OF A QUERY OPERATION EXECUTE.
            //-------------------------------------------------
            //  The first part is Data source.
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("\nBasic structure of LINQ : ");
            Console.Write("\n---------------------------\n");

            var num = from x in n1
                      select x;

            foreach (var number in num)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            Console.Write("Press any key");
            Console.ReadKey();
            Console.WriteLine();
        }

        public static void fnExercise4()
        {
            //-------------------------------------------------
            //Excersie 4 - WRITE A PROGRAM IN C SHARP TO DISPLAY THE NAME OF THE DAYS OF THE WEEK.
            //-------------------------------------------------
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.Write("\nLINQ : Display the name of the days of a week : ");
            Console.Write("\n------------------------------------------------\n");

            var day = from x in dayWeek
                      select x;

            Console.WriteLine("Days of the Week");
            foreach (var d in day)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine();
            Console.Write("Press any key");
            Console.ReadKey();
            Console.WriteLine();
        }

        public static void fnExercise5()
        {
            //-------------------------------------------------
            //Excersie 5 - WRITE A PROGRAM IN C SHARP TO PRINT THE NUMBER AND ITS SQUARE FROM AN ARRAY.
            //-------------------------------------------------
            var arr3 = new[] { 3, 9, 2, 8, 6, 5 };

            Console.Write("\nLINQ : Print the number and its square from an array: ");
            Console.Write("\n------------------------------------------------------------------------\n");

            //Write Your code

            var ar = from x in arr3
                     select x;

            foreach (var num in ar)
            {
                Console.WriteLine($"Number: {num}, Square: {Math.Pow(num, 2)}");
            }

            Console.WriteLine();
            Console.Write("Press any key");
            Console.ReadKey();
        }

    }
}

