using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.DanielLuna_M7_Final
{
    class CommissionEmployee : SalaryEmployee
    {
        int intCommission { get; set; }

        public CommissionEmployee(int pintCommission, int pintWeeklySalary, int pintID, string pstrName) 
        {
            intCommission = pintCommission;
            intWeeklySalary = pintWeeklySalary;
            intID = pintID;
            this.strName = pstrName;

            
        }

        public new void fnCalculatePayroll() 
        {
            dblComPayroll = intWeeklySalary + intCommission;
        }

        public new void fnDisplayInfo()
        {

            Console.WriteLine("Employee Name: " + this.strName);
            Console.WriteLine("Employee ID: " + intID);
            Console.WriteLine("Commision: " + intCommission);
            Console.WriteLine("Payroll with Commissions: " + dblComPayroll);

        }



    }
}
