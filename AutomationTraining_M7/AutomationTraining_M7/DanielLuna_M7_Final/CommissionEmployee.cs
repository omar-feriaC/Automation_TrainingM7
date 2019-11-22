using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.DanielLuna_M7_Final
{
    class CommissionEmployee : HourlyEmployee
    {
        int intCommission { get; set; }

        public CommissionEmployee(int pintCommission, int pintWeeklySalary, int pintID, string pstrName, double pdblPayroll) 
        {
            intCommission = pintCommission;
            intWeeklySalary = pintWeeklySalary;
            intID = pintID;
            this.strName = pstrName;
            dblPayroll = pdblPayroll;
        }

        public new void fnCalculatePayroll() 
        {
            dblComPayroll = dblPayroll + intCommission;
        }

        public new void fnDisplayInfo()
        {
            Console.WriteLine("Payroll with Commissions: " + dblComPayroll);

        }



    }
}
