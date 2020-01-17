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

            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();

        }

        static void Exercise1()
        {
            //-------------------------------------------------
            //Excersie 1
            //-------------------------------------------------
            string[] arr1;
            int n, i;

            Console.Write("\nLINQ : Print the lenght of the strings in the array : ");
            Console.Write("\n------------------------------------------------------\n");

            //Write Your code Here
            Console.Write("Input number of strings for the array :");
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
                Console.WriteLine("String: {0}, Lenght: {1}", word, word.Length);
            }

            Console.ReadLine();

        }

        static void Exercise2()
        {

            //-------------------------------------------------
            //Excersie 2
            //-------------------------------------------------
            string[] dirfiles = Directory.GetFiles("C:/Test");
            // there are three files in the directory abcd are :
            // abcd.txt, simple_file.txt and xyz.txt

            Console.Write("\nLINQ : Calculate the Size of File : ");
            Console.Write("\n------------------------------------\n");

            //Write Your code
            var fileQuery = from files in dirfiles
                            orderby new FileInfo(files).Length 
                            select files;

            foreach (string fileList in fileQuery)
            {
                Console.WriteLine("File Name: "+ fileList + " " + "Size in Bytes: " + fileList.Length);
            }

            Console.ReadLine();

        }

        static void Exercise3()
        {

            //-------------------------------------------------
            //Excersie 3
            //-------------------------------------------------
            //  The first part is Data source.
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //IList<int> intList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("\nBasic structure of LINQ : ");
            Console.WriteLine("\n---------------------------");

            //Write Your code
            var result = from s in n1
                         where s.Equals(1)
                         select s;

            foreach (var intLis in result)
            {
                Console.WriteLine("Query must display as a result a 1:" + " " + intLis);

            }
            Console.ReadLine();

        }

        static void Exercise4()
        {


            //-------------------------------------------------
            //Excersie 4
            //-------------------------------------------------
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.Write("\nLINQ : Display the name of the days of a week : ");
            Console.Write("\n------------------------------------------------\n");

            //Write Your code
            var daysName = from d in dayWeek
                           select d;

            foreach (var days in daysName)
            {
                Console.WriteLine(days);
            }

            Console.ReadLine();

        }

        static void Exercise5()
        {

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
