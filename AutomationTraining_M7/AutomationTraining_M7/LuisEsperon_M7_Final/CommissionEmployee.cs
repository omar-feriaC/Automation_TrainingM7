using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.LuisEsperon_M7_Final
{
    class CommissionEmployee : SalaryEmployee
    {
        public int intCommission { get; set; }
        public double dbSalaryCommissionPayroll { get; set; }



        public CommissionEmployee (int pinteCommission, double pdbSalaryPayroll)
        {
            intCommission = pinteCommission;
            dbSalaryPayroll = pdbSalaryPayroll;


        }


        public new double fnCalculatePayroll()
        {

            dbSalaryCommissionPayroll = dbSalaryPayroll + intCommission;

            return dbSalaryCommissionPayroll;
        }


        public new void  fnDisplayInfo()
        {
            fnCalculatePayroll();
            Console.WriteLine("Comission:  " + intCommission);
            Console.WriteLine("Payroll+Comission:  " + dbSalaryCommissionPayroll);
        }



    }
}
