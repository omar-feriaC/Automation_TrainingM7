using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.HectorCastillo_M7_Final
{
    class SalaryEmployee : IPayRollCalculator
    {
        //Atributes
        public int intId { get; set; }
        public string strName { get; set; }
        public int intWeeklySalary { get; set; }
        public double dblPayroll { get; set; }


        //Cosntructors
        public SalaryEmployee()
        {
            intId = 0;
            strName = "undefined";
            intWeeklySalary = 0;
            dblPayroll = 0;
        }

        public SalaryEmployee(int pintId, string pstrName, int pintWeeklySalary)
        {
            intId = pintId;
            this.strName = pstrName;
            intWeeklySalary = pintWeeklySalary;
        }

        public void fnCalculatePayroll()
        {
            dblPayroll = intWeeklySalary * 4;
        }

        public void fnDisplayInfo()
        {
            Console.WriteLine("Id: " + intId);
            Console.WriteLine("Name: " + this.strName);
            Console.WriteLine("Weekly Salary: " + intWeeklySalary);
            Console.WriteLine("Payroll: " + dblPayroll);
        }

        
    }
}
