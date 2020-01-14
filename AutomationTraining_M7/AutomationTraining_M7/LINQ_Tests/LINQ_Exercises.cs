using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AutomationTraining_M7.Base_Files;

namespace AutomationTraining_M7.LINQ_Tests
{
    class LINQ_Exercises
    {
        public LINQ_Exercises()
        {

        }

        public void Exercise1()
        {
            string[] arr1;
            int n, i;

            Console.Write("\nLINQ : Print the lenght of the strings in the array : ");
            Console.Write("\n------------------------------------------------------\n");

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
                Console.WriteLine("Word: {0}, length: {1}",word,word.Length);
            }

            Console.ReadLine();
        }

        public void Exercise2()
        {
            string[] dirfiles = Directory.GetFiles("C:/Test");
            // there are three files in the directory abcd are :
            // abcd.txt, simple_file.txt and xyz.txt

            Console.Write("\nLINQ : Calculate the Size of File : ");
            Console.Write("\n------------------------------------\n");


            Console.ReadLine();

        }

        public void Exercise3()
        {
            //  The first part is Data source.
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("\nBasic structure of LINQ : ");
            Console.Write("\n---------------------------");



            // The third part is Query execution.

            Console.Write("\n\n");
        }

        public void Exercise4()
        {
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.Write("\nLINQ : Display the name of the days of a week : ");
            Console.Write("\n------------------------------------------------\n");

        }

        public class clsStudent
        {
            public string strName;
            public string strAge;

        }

        public void Exercise5()
        {
            //var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
            clsLibData libData = new clsLibData();
            DataTable dataTable = libData.fnExecuteQueryData2("select * from t_Students");
            List<clsStudent> students = new List<clsStudent>();
            //var names;
            

            students = dataTable.AsEnumerable().Select(x => new clsStudent { strName = x["Name"].ToString(), strAge = x["Age"].ToString() }).Where(p => Convert.ToInt32(p.strAge) > 25).ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student.strName);
                Console.WriteLine(student.strAge);
            }

            //if (dataTable.Rows.Count > 0 && dataTable != null)
            //{
            //    foreach (var row in dataTable.Rows)
            //    {
            //        students.Add(row.ToString());
            //    }
            //}


            Console.Write("\nLINQ : Print the number and its square from an array: ");
            Console.Write("\n------------------------------------------------------------------------\n");


            Console.ReadLine();

        }


    }
}
