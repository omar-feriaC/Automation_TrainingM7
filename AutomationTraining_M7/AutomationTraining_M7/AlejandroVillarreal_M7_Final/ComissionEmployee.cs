using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.AlejandroVillarreal_M7_Final
{
    class ComissionEmployee : SalaryEmployee
    {
        
        public int intComission { get; set; }
        public int intTotalSalary;
        public string strName { get; set; }

        private int intid;

        public int intId { get; set; }


        public ComissionEmployee(int intId, string strName, int intComission, int intTotalSalary)
        {
            this.intTotalSalary = intTotalSalary;
            this.strName = strName;
            this.intid = intId;
            this.intComission = intComission;
        }

        public void fnCalculatePayroll()
        {
            //salario + comision

            intTotalSalary=base.intSalaryPayroll + intComission;
        }

        public void fnDisplayInfo()
        {
            Console.WriteLine("ID =" + intId);
            Console.WriteLine("Name= " + StrName);
            Console.WriteLine("Monthly Payroll=" + intMonthlyPayroll);
            Console.WriteLine("Weekly Salary=" + intWeeklySalary);
        }
        
    }
}
