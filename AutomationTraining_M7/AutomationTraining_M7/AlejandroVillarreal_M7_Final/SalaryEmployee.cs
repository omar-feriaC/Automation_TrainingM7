using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.AlejandroVillarreal_M7_Final
{
    class SalaryEmployee : IPayRollCalculator
    {
        public int intId { get; set; }
        public string strName { get; set; }
        public int intSalaryPayroll;
        public int intWeeklySalary { get; set; }
        public int intMonthlyPayroll;

        //public SalaryEmployee() { }

        public SalaryEmployee(int intId, string strName, int intWeeklySalary, int intMonthlyPayroll)
        {
            this.intId = 0;
            this.strName = "No name defined";
            this.intMonthlyPayroll = intMonthlyPayroll;
            this.intWeeklySalary = intWeeklySalary;
        }

        public void fnCalculatePayroll()
        {
           intSalaryPayroll= intWeeklySalary *4;
        }

        public void fnDisplayInfo()
        {
            Console.WriteLine("ID =" + intId);
            Console.WriteLine("Name= " + strName);
            Console.WriteLine("Monthly Payroll=" + intMonthlyPayroll);
            Console.WriteLine("Weekly Salary=" + intWeeklySalary);

        }
        

    }
}
