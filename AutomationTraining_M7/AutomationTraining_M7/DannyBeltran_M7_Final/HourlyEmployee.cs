using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.DannyBeltran_M7_Final
{
    class HourlyEmployee : IPayrollCalculator
    {
        public int IntHoursWorked { get; set; }
        public int IntHoursRate { get; set; }
        public int IntID { get; set; }
        public string StrName { get; set; }
        public int IntPayroll { get; set; }

        public HourlyEmployee()
        {
            IntID = 0;
            StrName = "Unknown";
            IntHoursWorked = 0;
            IntHoursRate = 0;
        }

        public HourlyEmployee(int myId, string myName, int myHoursWorked, int myHoursRate)
        {
            IntID = myId;
            StrName = myName;
            IntHoursWorked = myHoursWorked;
            IntHoursRate = myHoursRate;
        }

        public int FnCalculatePayroll()
        {
            IntPayroll = IntHoursWorked * IntHoursRate;
            return IntPayroll;
        }

        public void FnDisplayInfo()
        {
            Console.WriteLine("==========HOURLY EMPLOYEE==========");
            Console.WriteLine("Employee ID: " + IntID);
            Console.WriteLine("Employee Name: " + StrName);
            Console.WriteLine("Salary: " + FnCalculatePayroll());
            Console.WriteLine("===================================");
        }
    }
}
