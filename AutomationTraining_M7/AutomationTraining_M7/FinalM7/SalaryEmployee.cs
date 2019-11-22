using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.FinalM7
{
    class SalaryEmployee : IPayrollCalculator
    {
        public int intID { get; set; }
        public string strName { get; set; }
        public double dblWeeklySal { get; set; }

        public SalaryEmployee()
        {
            intID = 0;
            strName = "undefined";
            dblWeeklySal = 0.0;
        }

        public SalaryEmployee(int pID, string pstrName, double pdblSalary)
        {
            intID = pID;
            strName = pstrName;
            dblWeeklySal = pdblSalary;
        }

        public double fnCalculatePayroll()
        {
            return dblWeeklySal;
        }

        public void fnDisplayInfo()
        {
            Console.WriteLine("Salary Class");
            Console.WriteLine("ID: " + intID);
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Salary: " + dblWeeklySal);
            Console.WriteLine();
        }
    }
}
