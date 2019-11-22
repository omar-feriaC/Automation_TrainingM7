using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.DannyBeltran_M7_Final
{
    class SalaryEmployee : IPayrollCalculator
    {

        public int IntWeeklySalary { get; set; }
        public int IntID { get; set; }
        public string StrName { get; set; }
        public int IntPayroll { get; set; }

        public SalaryEmployee()
        {
            IntID = 0;
            StrName = "Unknown";
            IntWeeklySalary = 0;
        }

        public SalaryEmployee(int myId, string myName, int myWeeklySalary)
        {
            IntID = myId;
            StrName = myName;
            IntWeeklySalary = myWeeklySalary;
        }

        public void FnDisplayInfo()
        {
            Console.WriteLine("==========SALARY EMPLOYEE==========");
            Console.WriteLine(IntID);
            Console.WriteLine(StrName);
            Console.WriteLine("Salary: " + FnCalculatePayroll());
            Console.WriteLine("===================================");
        }

        public int FnCalculatePayroll()
        {
            IntPayroll = IntWeeklySalary * 4;
            return IntPayroll;
        }
    }
}
