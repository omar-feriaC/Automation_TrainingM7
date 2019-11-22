using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.JuanLopez_M7_Final
{
    class SalaryEmployee : IPayrollCalculator
    {
        public int intWeeklySalary;
        public int intBasePay;
        public int intId { set; get; }
        public string strName { set; get; }
        public void fnDisplayInfo()
        {
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("---------- Data ---------- ");
            Console.WriteLine("Weekly Salary: "+ intWeeklySalary);
            Console.WriteLine("ID: " + intId);
            Console.WriteLine("Base Pay: " + intBasePay);

        }
        public SalaryEmployee()
        {
            intId = 0;
            strName = "noOne";
        }
        public SalaryEmployee(int pintId, string pstrName,int pintWeeklySalary)
        {
            intId = pintId;
            strName = pstrName;
            intWeeklySalary = pintWeeklySalary;
        }
        public void fnCalculatePayroll()
        {
            intBasePay = intWeeklySalary*4;
        }
    }
}
