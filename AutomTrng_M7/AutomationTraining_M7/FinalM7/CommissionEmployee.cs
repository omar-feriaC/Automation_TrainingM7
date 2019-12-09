using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.FinalM7
{
    class CommissionEmployee : SalaryEmployee
    {
        public double dblCommission { get; set; }
        private double dblTotalSalary { get; set; }

        public CommissionEmployee()
        {
            intID = 0;
            strName = "undefined";
            dblWeeklySal = 0.0;
            dblCommission = 0.0;
            dblTotalSalary = 0.0;
            fnCalculatePayroll();
        }

        public CommissionEmployee(int pID, string pstrName, double pdblSalary, double pdblCommission)
        {
            intID = pID;
            strName = pstrName;
            dblWeeklySal = pdblSalary;
            dblCommission = pdblCommission;
            dblTotalSalary = 0.0;
            fnCalculatePayroll();
        }

        public new void fnCalculatePayroll()
        {
            dblTotalSalary = dblWeeklySal + dblCommission;
        }

        public new void fnDisplayInfo()
        {
            base.fnDisplayInfo();
            Console.WriteLine("Commission Class");
            Console.WriteLine("Commission: " + dblCommission);
            Console.WriteLine("Total Salary: " + dblTotalSalary);
            Console.WriteLine();

        }


    }
}
