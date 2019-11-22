using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.MauricioGuillermo_M7_Final
{
    class CommissionEmployee : SalaryEmployee
    {
        public int intCommission { get; set; }

        public CommissionEmployee(int pId, string pName, int pWeeklySalary, int pCommission)
        {
            base.intId = pId;
            base.strName = pName;
            base.intWeeklySalary = pWeeklySalary;
            intCommission = pCommission;
        }

        public new int FnCalculatePayroll()
        {
            return base.intWeeklySalary + intCommission;
        }

        public void fnDisplayInfo()
        {
           
        }
    }

}

