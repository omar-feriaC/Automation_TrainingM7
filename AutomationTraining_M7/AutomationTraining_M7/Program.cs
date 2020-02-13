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
        
        delegate void LambdasNoParams();


        static void Main(string[] args)
        {

            //-------------------------------------------------
            //Excersie 1
            //-------------------------------------------------
            string[] array1;
            int a, b;

            Console.Write("\nLINQ : Print the lenght of the strings in the array : ");
            Console.Write("\n------------------------------------------------------\n");

            //Write Your code Here
            try
            {
                
                Console.Write("How many elements needs to include in your array? :");
                a = Convert.ToInt16(Console.ReadLine());
                array1 = new string[a];
                Console.Write("\nWrite {0} strings for the array  :\n", a);
                for (b = 0; b < a; b++)
                {
                    Console.Write("Word[{0}] : ", b);
                    array1[b] = Console.ReadLine();
                }

                var strWords = from strElement in array1
                               select strElement;

                foreach (var strElement in strWords)
                {
                    Console.WriteLine("String {0} contains: {1} chars", strElement, strElement.Length);
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in : \n" + ex.GetBaseException());
            }

            
            //-------------------------------------------------
            //Excersie 2
            //-------------------------------------------------

            try
            {

               string[] directfiles = Directory.GetFiles("C:/GitHub");
            // there are three files in the directory abcd are :
            // abcd.txt, simple_file.txt and xyz.txt

            Console.Write("\nLINQ : Calculate the Size of file : ");
            Console.Write("\n------------------------------------\n");

            if (directfiles.Count() > 0)
            {
                Console.WriteLine("Number of files in folder : " + directfiles.Count());

                var files = from file in directfiles
                            select file;

                foreach (var File in files)
                {
                    long Size = new FileInfo(File).Length;

                    Console.WriteLine("The file Name is : {0}, Size in bytes is: {1}", File
                        , Size);

                }

            }
            Console.ReadLine();
        }
            catch (Exception ex)
            {
                Console.WriteLine("Error in : \n" + ex.GetBaseException());

            }




    //-------------------------------------------------
    //Excersie 3
    //-------------------------------------------------
    //  The first part is Data source.
        try
        {
            int[] x1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int a2 = x1.Count();
            Console.Write("\nBasic structure of LINQ : ");
            Console.Write("\n---------------------------");

            //Write Your code
            var _allNumbers = from number in x1
                                select number;
            Console.WriteLine("All numbers are: ");



            foreach (var Number in _allNumbers)
            {
                Console.WriteLine("number is: {0}", Number);

            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in: " + ex.Message);

        }
        Console.ReadLine();


                                   //-------------------------------------------------
            //Excersie 4
            //-------------------------------------------------

            
                string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

                Console.Write("\nLINQ : Display the name of the days of a week : ");
                Console.Write("\n------------------------------------------------\n");

                //Write Your code
                var alldays = from day in dayWeek
                              select day;
                Console.WriteLine("All days are: ");

                foreach (var Days in alldays)
                {
                    Console.WriteLine("{0}", Days);

                }
            
            
            Console.ReadLine();
                       
            
            //-------------------------------------------------
            //Excersie 5
            //-------------------------------------------------

            
                var array3 = new[] { 3, 9, 2, 8, 6, 5 };

                Console.Write("\nLINQ : Print the number and its square from an array: ");
                Console.Write("\n------------------------------------------------------------------------\n");

                //Write Your code
                var allNumbers = from number in array3
                                 select number;
                Console.WriteLine("All numbers are: ");

                foreach (var Number in allNumbers)
                {
                    Console.WriteLine("number is : {0}", Number);
                    Console.WriteLine("number square is: {0}", Math.Pow(Number, 2));

                }
            
            

        }
    }

}
