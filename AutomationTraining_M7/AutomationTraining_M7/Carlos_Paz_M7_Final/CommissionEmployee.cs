using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Carlos_Paz_M7_Final
{
    class CommissionEmployee : SalaryEmployee
    {
        public int intCommission { get; set; }

        public CommissionEmployee(int id, string name, int weeklySalary, int commission)
        {
            base.intID = id;
            base.strName = name;
            base.intWeeklySalary = weeklySalary;
            intCommission = commission;
        }

        public new int fnCalculatePayroll()
        {
            return base.intWeeklySalary + intCommission;
        }

        public void fnDisplayInfo()
        {
            Console.WriteLine("ID: " + base.intID);
            Console.WriteLine("Name: " + base.strName);
            Console.WriteLine("Weekly Salary: " + base.intWeeklySalary);
            Console.WriteLine("Comission: " + intCommission);
            Console.WriteLine("Payroll: " + fnCalculatePayroll());
        }
    }
}
