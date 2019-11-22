using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.JuanLopez_M7_Final
{
    class CommissionEmployee : SalaryEmployee
    {
        public int intCommission;
        public int intComPayroll;

        public CommissionEmployee(int pintCommission,int pintWeeklySalary,int pintId,string pstrName) 
        {
            intCommission = pintCommission;
            //intSalaryPayroll = pintSalaryPayroll;
            intWeeklySalary= pintWeeklySalary;
            intId = pintId;
            strName= pstrName;
    }
        public new void fnCalculatePayroll()
        {
            base.fnCalculatePayroll();
            intComPayroll = this.intBasePay * intCommission;
        }
        public new void fnDisplayInfo()
        {
            base.fnDisplayInfo();
            Console.WriteLine("Commission: " + intCommission);
            Console.WriteLine("Commission Payroll: " + intComPayroll);
        }
    }
}
