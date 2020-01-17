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

namespace AutomationTraining_M7 {
    class Program {
        //Delegates
        delegate void LambdasNoParams(); //(1)


        static void Main(string[] args) {

            //-------------------------------------------------
            //Excersie 1: print the length of a string from an array of strings
            //-------------------------------------------------

            Console.Write("\nLINQ : Print the lenght of the strings in the array: ");
            Console.Write("\n---------------------------------------------------\n");

            string[] arr1 = { "asdqwe", "cdvfbgnhjuh", "tttttttttttttt" };
            var word = from wlength in arr1 select wlength + " = " + wlength.Length;
            foreach (var wlength in word)
            {
                Console.WriteLine(wlength);
            }

            Console.ReadLine();

            //-------------------------------------------------
            //Excersie 2: print the size of a file in bytes in a directory using LINQ
            //-------------------------------------------------
            Console.Write("\nLINQ : Calculate the Size of File: ");
            Console.Write("\n---------------------------------\n");

            long FileSize = 0;
            string[] dirfiles = Directory.GetFiles("C:/Test");
            var z = from size in dirfiles select size;
            foreach (var size in z)
            {
                FileSize = new FileInfo(size).Length;
                Console.WriteLine("File size: " + FileSize + " Bytes");
            }

            Console.ReadLine();

            //-------------------------------------------------
            //Excersie 3: shows how the three parts of a query operation execute
            //-------------------------------------------------
            //  The first part is Data source.

            Console.Write("\nBasic structure of LINQ: ");
            Console.Write("\n-----------------------\n");

            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var query = from num in n1
                        where (num * num) > 10
                        select num;
            Console.WriteLine("Numbers from 0 to 9 times itself greater than 10 are:");
            foreach (int num in query)
                Console.Write(num + ", ");

            Console.ReadLine();

            //-------------------------------------------------
            //Excersie 4: display the name of the days of a week
            //-------------------------------------------------

            Console.Write("\nLINQ : Display the name of the days of a week: ");
            Console.Write("\n---------------------------------------------\n");

            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            var day = from weekDay in dayWeek select weekDay;
            foreach (var weekDay in day)
                Console.WriteLine(weekDay);

            Console.ReadLine();

            //-------------------------------------------------
            //Excersie 5: print the number and its square form an array
            //-------------------------------------------------

            Console.Write("\nLINQ : Print the number and its square from an array: ");
            Console.Write("\n----------------------------------------------------\n");
            var arr3 = new[] { 3, 9, 2, 8, 6, 5 };
            var sqrtQ = from int Number in arr3
                        let sqrtNum = Number * Number
                        select new { Number, sqrtNum };
            foreach (var x in sqrtQ)
                Console.WriteLine(x);

            Console.ReadLine();

        }
    }

}
