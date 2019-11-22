
using AutomationTraining_M7.LuisEsperon_M7_Final;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomationTraining_M7
{
    class Program 
    {
        static void Main(string[] args)
        {


            Console.WriteLine("**********Salary********");

            SalaryEmployee obj1 = new SalaryEmployee(777, "JohnDoe", 1000);
            obj1.fnDisplayInfo();


            Console.WriteLine("*********Salary+Commission**********");

            CommissionEmployee obj3 = new CommissionEmployee(500, obj1.dbSalaryPayroll);
            obj3.fnDisplayInfo();


            Console.WriteLine("*********Hourly Payroll**********");

            HourlyEmployee obj2 = new HourlyEmployee(40,5);
            obj2.fnDisplayInfo();


           
           

            Console.ReadKey();
            
        }
    }
}
