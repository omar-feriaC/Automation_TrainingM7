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
            string[] arr1 = { "uno", "mill","millones","algomas","quien sabe que transa" };
            int n, i;
            int intItemNum = 1;

            List<int> listStringsizes = arr1.Select(s => s.Length());
            Console.Write("\nLINQ : Print the lenght of the strings in the array : ");
            Console.Write("\n------------------------------------------------------\n");
            
            foreach (int intSize in listStringsizes) 
            {
                Console.Write("the size of the item {1} is {2} ", intItemNum.ToString(), intSize.ToString());
                intItemNum++;
            }
            //Write Your code Here
            Console.ReadLine();

            intItemNum = 1;



            //-------------------------------------------------
            //Excersie 2
            //-------------------------------------------------
            // there are three files in the directory abcd are :
            // abcd.txt, simple_file.txt and xyz.txt
            Console.Write("\nLINQ : Calculate the Size of File : ");
            Console.Write("\n------------------------------------\n");
            string[] dirfiles = Directory.GetFiles("C:/Test");
            FileInfo tempfile = new FileInfo(dirfiles[0]);
            List<FileInfo> tempfiles = new List<FileInfo>();
            foreach (string fileName in dirfiles)
            {
                FileInfo tempfile = new FileInfo(fileName);
                tempfiles.Add(tempfile);
                //Console.Write("the size of the item {1} is {2} ", intItemNum, intSize.ToString());
                //intItemNum++;
            }
            List<long> listFilesizes = tempfiles.Select(s => s.Length());

            foreach (long Filesize in listFilesizes)
            {
                Console.Write("the size of the file {1} is {2} ", intItemNum.ToString(), Filesize.ToString());
                intItemNum++;
            }


            intItemNum = 1;

            //Write Your code
            Console.ReadLine();





            //-------------------------------------------------
            //Excersie 3
            //-------------------------------------------------
            //  The first part is Data source.
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("\nBasic structure of LINQ : ");
            Console.Write("\n---------------------------");

            int[] temp = from s in n1
                       where s > 2 && s < 4
                       select s;
            foreach (int intTemp in temp)
            {
                Console.Write("the size of the item {1} is {2} ", intItemNum.ToString(), intTemp.ToString());
                intItemNum++;
            }
            intItemNum = 1;

            int[] temptoo = n1.Where(x => x > 2 && x < 6).Select(x);

            foreach (int intTemp in temptoo)
            {
                Console.Write("the size of the item {1} is {2} ", intItemNum.ToString(), intTemp.ToString());
                intItemNum++;
            }
            intItemNum = 1;

            //Write Your code
            Console.ReadLine();

            intItemNum = 1;



            //-------------------------------------------------
            //Excersie 4
            //-------------------------------------------------
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.Write("\nLINQ : Display the name of the days of a week : ");
            Console.Write("\n------------------------------------------------\n");

            List<string> listWeekNames = dayWeek.FindAll(x => x);
            foreach (string WeekName in listWeekNames)
            {
                Console.Write("the size of the item {1} is {2} ", intItemNum.ToString(), WeekName);
                intItemNum++;
            }
            //Write Your code
            Console.ReadLine();


            intItemNum = 1;


            //-------------------------------------------------
            //Excersie 5
            //-------------------------------------------------
            var arr3 = new[] { 3, 9, 2, 8, 6, 5 };

            Console.Write("\nLINQ : Print the number and its square from an array: ");
            Console.Write("\n------------------------------------------------------------------------\n");
            List<long> listSquare = arr3.Select(x => x^2);
            foreach (long SquareVal in listSquare)
            {
                Console.Write("the size of the item {1} is {2} ", intItemNum.ToString(), SquareVal.ToString());
                intItemNum++;
            }

            //Write Your code
            Console.ReadLine();

        }
    }

}
