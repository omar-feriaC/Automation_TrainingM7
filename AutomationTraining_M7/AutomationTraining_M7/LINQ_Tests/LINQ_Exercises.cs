using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            IEnumerable<string> objNew = from m in arr1
                                         select m;

            foreach (string z in objNew)
                Console.WriteLine("Item: {0}, characters {1}", z, z.Length);

            Console.ReadLine();
        }

        public void Exercise2()
        {
            string[] dirfiles = Directory.GetFiles("C:/Test");
            // there are three files in the directory abcd are :
            // abcd.txt, simple_file.txt and xyz.txt

            Console.Write("\nLINQ : Calculate the Size of File : ");
            Console.Write("\n------------------------------------\n");

            var avgFsize = dirfiles.Select(file => new FileInfo(file));

            foreach (var file in avgFsize)
            {
                Console.WriteLine("The file size is {0} bytes", file.Length);
            }

            Console.ReadLine();

        }

        public void Exercise3()
        {
            //  The first part is Data source.
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("\nBasic structure of LINQ : ");
            Console.Write("\n---------------------------");

            // The second part is Query creation.
            // nQuery is an IEnumerable<int>
            var nQuery =
                from VrNum in n1
                where (VrNum % 2) == 0
                select VrNum;

            // The third part is Query execution.

            Console.Write("\nThe numbers which produce the remainder 0 after divided by 2 are : \n");
            foreach (int VrNum in nQuery)
            {
                Console.Write("{0} ", VrNum);
            }
            Console.Write("\n\n");
        }

        public void Exercise4()
        {
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.Write("\nLINQ : Display the name of the days of a week : ");
            Console.Write("\n------------------------------------------------\n");


            var days = from WeekDay in dayWeek
                       select WeekDay;
            foreach (var WeekDay in days)
            {
                Console.WriteLine(WeekDay);
            }
            Console.WriteLine();
        }

        public void Exercise5()
        {
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            Console.Write("\nLINQ : Print the number and its square from an array: ");
            Console.Write("\n------------------------------------------------------------------------\n");

            var sqNo = from int Number in arr1
                       let SqrNo = Number * Number
                       select new { Number, SqrNo };

            foreach (var a in sqNo)
                Console.WriteLine(a);

            Console.ReadLine();

        }


    }
}
