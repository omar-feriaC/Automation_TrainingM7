using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AutomationTraining_M7.Reporting;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7
{
    class Program : BaseTest
    {
        //Delegates
        delegate void LambdasNoParams(); //(1)


        static void Main(string[] args)
        {
            DataTable myTable;



            /*F I L E   H A N D L I N G*/


            string strFileName = @"C:\TempAuto\TempAuto123.txt";
            FileInfo objFile = new FileInfo(strFileName);

            using (StreamWriter sw = objFile.CreateText())
            {
                sw.WriteLine("Test1");
                sw.WriteLine("Test2");
                sw.WriteLine("Test3");
                sw.WriteLine("Test4");
                sw.WriteLine("Test5");
                sw.WriteLine("Test6");
            }

            using (StreamReader sr = new StreamReader(strFileName))
            {
                string strValue = "";
                while ((strValue = sr.ReadLine()) != null)
                {
                    Console.WriteLine(strValue);
                }
            }


            Console.ReadKey();








            /* D A T A B A S E*/
            clsData objData = new clsData();
            clsLibData objLibData = new clsLibData();
            objLibData.fnInitConnection();


            myTable =  objLibData.fnExecuteQueryData2("select * from UserCredentials");
            if (myTable != null && myTable.Rows.Count > 0)
            {
                //Iterate each row in Table
                foreach (DataRow row in myTable.Rows)
                {
                    if (row["SetValue"].ToString().Trim() == "3")
                    {
                        string username = row["UserName"].ToString().Trim();
                        string password = row["Password"].ToString().Trim();
                    }

                  
                }
            }


            objLibData.fnExecuteQueryData("select * from Tbl_Users");
            objLibData.fnExecuteQueryData("select * from Tbl_Users");
            objData.fnExecuteQueryData("select * from Tbl_Users");






            //-------------------------------------------------
            //Excersie 1
            //-------------------------------------------------
            string[] arr1;
            int n, i;

            Console.Write("\nLINQ : Print the lenght of the strings in the array : ");
            Console.Write("\n------------------------------------------------------\n");

            //Write Your code Here
            Console.ReadLine();





            //-------------------------------------------------
            //Excersie 2
            //-------------------------------------------------
            string[] dirfiles = Directory.GetFiles("C:/Test");
            // there are three files in the directory abcd are :
            // abcd.txt, simple_file.txt and xyz.txt

            Console.Write("\nLINQ : Calculate the Size of File : ");
            Console.Write("\n------------------------------------\n");

            //Write Your code
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
