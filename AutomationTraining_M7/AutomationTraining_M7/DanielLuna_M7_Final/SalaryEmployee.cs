using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.DanielLuna_M7_Final
{
    class SalaryEmployee : IPayrollCalculator
    {
        public int intWeeklySalary { get; set; }
        public int intID { get ; set; }
        public string strName { get ; set ; }
        public double dblPayroll { get; set; }
        public double dblComPayroll { get; set; }

        public SalaryEmployee()
        {
            intWeeklySalary = 0;
            intID = 0;
            strName = "Undefined";
        }

        public SalaryEmployee(int pintWeeklySalary, int pintID, string pstrName) 
        {
            intWeeklySalary = pintWeeklySalary;
            intID = pintID;
            this.strName = pstrName;
        }

        public void fnCalculatePayroll() 
        {

        }

        public void fnDisplayInfo()
        {
            Console.WriteLine("Employee Name: " + this.strName);
            Console.WriteLine("Employee ID: " + intID);
            Console.WriteLine("Employee Weekly Salary: " + intWeeklySalary);
        }
    }

    
}
