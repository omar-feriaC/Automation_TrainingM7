using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using AutomationTraining_M7.Reporting;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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






            /*L A M B D A */

            //********************************************************
            // Case 1
            //********************************************************
            LambdasWithNoParameter();
            Console.WriteLine("//********************************************************");


            //********************************************************
            // Case 2
            //********************************************************
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);

            foreach (var num in evenNumbers)
            {
                Console.WriteLine("{0} ", num);
            }
            Console.WriteLine("//********************************************************");


            //********************************************************
            // Case 3
            //********************************************************
            List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10 };
            List<int> oddNumbers = numbers.FindAll(x => x % 2 != 0).ToList();
            List<int> evenNumbers2 = numbers.FindAll(x => x % 2 == 0).ToList();
            Console.WriteLine("List of Odd Numbers is");
            foreach (int ab in oddNumbers)
            {
                Console.WriteLine(ab);
            }
            Console.WriteLine("List of Even Numbers is");
            foreach (int ab in evenNumbers2)
            {
                Console.WriteLine(ab);
            }
            Console.WriteLine("//********************************************************");


            //********************************************************
            // Case 4
            //********************************************************
            List<int> numbers2 = new List<int>() { 1,2,3,4,5,6,7,8,9,10 };
            foreach (int ab in numbers2.Where(x =>
            {
                Console.WriteLine("Number is {0}", x);
                Console.WriteLine("Sqrt of Value is: {0}", Math.Sqrt(x));
                return x % 3 == 0 || x % 5 == 0;
            }))
            {
                Console.WriteLine("Returned Number is {0}", ab);
            }
            Console.WriteLine("//********************************************************");


            Console.ReadKey();

        }

        //(1) No parameters
        public static void LambdasWithNoParameter()
        {
            LambdasNoParams noparams = () => Console.WriteLine(" Hello!!!");
            noparams();
        }
    }

}
