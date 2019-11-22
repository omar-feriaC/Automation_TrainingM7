using AutomationTraining_M7.DannyBeltran_M7_Final;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7
{
    class ComissionEmployee : SalaryEmployee
    {
        public int IntComission { get; set; }
        public ComissionEmployee(int myId, string myName, int myWeeklySalary, int myComission)
        {
            IntID = myId;
            StrName = myName;
            IntWeeklySalary = myWeeklySalary;
            IntComission = myComission;
        }

        public new int FnCalculatePayroll()
        {
            IntPayroll = base.FnCalculatePayroll() - IntComission;
            return IntPayroll;
        }

        public new void FnDisplayInfo()
        {
            Console.WriteLine("==========COMISSION EMPLOYEE==========");
            Console.WriteLine(IntID);
            Console.WriteLine(StrName);
            Console.WriteLine("Salary: " + FnCalculatePayroll());
            //FnDisplayInfo();
            Console.WriteLine("===================================");
        }
    }
}
