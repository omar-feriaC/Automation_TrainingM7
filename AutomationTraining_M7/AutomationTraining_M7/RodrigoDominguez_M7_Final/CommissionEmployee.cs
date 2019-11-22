using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.RodrigoDominguez_M7_Final {
    class CommissionEmployee : SalaryEmployee {

        public int intCommission;

        public CommissionEmployee(int Commission)
        {
            this.intCommission = Commission;
        }

        public new int fnCalculatePayroll()
        {
            int intResult = this.intCommission + intWeeklySalary;
            return intResult;
        }

        public virtual new void fnDisplayInfo()
        {
            base.fnDisplayInfo();
            Console.WriteLine("Total Salary: " + this.fnCalculatePayroll());
        }
    }
}
