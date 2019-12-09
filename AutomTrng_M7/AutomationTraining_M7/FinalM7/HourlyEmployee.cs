using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.FinalM7
{
    class HourlyEmployee : IPayrollCalculator
    {
        public int intID { get; set; }
        public string strName { get; set; }
        public double dblHours { get; set; }
        public double dblRate { get; set; }
        private double dblPayroll { get; set; }

        public HourlyEmployee()
        {
            intID = 0;
            strName = "undefined";
            dblHours = 0.0;
            dblRate = 0.0;
            dblPayroll = 0.0;
        }

        public HourlyEmployee(int pID, string pstrName, double pdblHours, double pdblRate)
        {
            intID = pID;
            strName = pstrName;
            dblHours = pdblHours;
            dblRate = pdblRate;
            fnCalculatePayroll();
        }

        public double fnCalculatePayroll()
        {
            return dblPayroll = dblHours * dblRate;
        }

        public void fnDisplayInfo()
        {
            Console.WriteLine("Hourly Class");
            Console.WriteLine("ID: " + intID);
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Hours: " + dblHours);
            Console.WriteLine("Rate: " + dblRate);
            Console.WriteLine("Total Payroll: " + dblPayroll);
            Console.WriteLine();


        }
    }
}
