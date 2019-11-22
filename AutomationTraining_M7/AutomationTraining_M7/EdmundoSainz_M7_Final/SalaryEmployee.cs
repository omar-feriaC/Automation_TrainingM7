using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.EdmundoSainz_M7_Final
{
    class SalaryEmployee : IPayrollCalculator
    {
        public int intWeeklySalary { get; set; }
        public int intId { get; set; }
        public string strName { get; set; }
        public double dblPayroll { get; set; }

        public SalaryEmployee()
        {
            intId = 0;
            strName = "undifined";
            intWeeklySalary = 0;
            dblPayroll = 0;

        }
        public SalaryEmployee(int ID, string Name, int WeeklySalary)
        {
            intId = ID;
            strName = Name;
            intWeeklySalary = WeeklySalary;
        }

        public void fnCalculatePayroll()
        {
            dblPayroll = intWeeklySalary * 4;
        }

        public void fnDisplayInfo()
        {
            fnCalculatePayroll();
            Console.WriteLine("Employee ID : " + intId);
            Console.WriteLine("Employee Name: " + strName);
            Console.WriteLine("Employee weekly salary: " + intWeeklySalary);
            Console.WriteLine("Employee Payroll: " + dblPayroll);
        }

    }
}
