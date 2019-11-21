using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Carlos_Paz_M7_Final
{
    class SalaryEmployee : IPayrollCalculator
    {
        public int intID { get; set; }
        public string strName { get; set; }
        public int intWeeklySalary { get; set; }
        
        public SalaryEmployee()
        {
            intID = 0;
            strName = "";
            intWeeklySalary = 0;
        }

        public SalaryEmployee(int id, string name, int weeklySalary)
        {
            intID = id;
            strName = name;
            intWeeklySalary = weeklySalary;
        }

        public int fnCalculatePayroll()
        {
            return intWeeklySalary;
        }

        public void fnDisplayInfo()
        {
            Console.WriteLine("ID: " + intID);
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Weekly Salary: " + fnCalculatePayroll());

        }

    }
}
