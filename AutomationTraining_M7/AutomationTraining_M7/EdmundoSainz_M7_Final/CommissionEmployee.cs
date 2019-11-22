using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.EdmundoSainz_M7_Final
{
    class CommissionEmployee : SalaryEmployee
    {
        public int intCommission { get; set; }

        public CommissionEmployee(int ID, string Name, int WeeklySalary, int Commission)
        {
            intId = ID;
            strName = Name;
            intWeeklySalary = WeeklySalary;
            intCommission = Commission;
        }

        public new void fnCalculatePayroll()
        {
            dblPayroll = (intWeeklySalary * 4) + intCommission;
        }

        public new void fnDisplayInfo()
        {
            
            base.fnDisplayInfo();
            fnCalculatePayroll();
            Console.WriteLine("Employee Commission: " + intCommission);
            Console.WriteLine("Employee final Payroll: " + dblPayroll);
        }
    }
}
