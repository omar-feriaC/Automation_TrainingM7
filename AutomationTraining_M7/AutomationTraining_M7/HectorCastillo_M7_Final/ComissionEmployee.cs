using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.HectorCastillo_M7_Final
{
    class ComissionEmployee : SalaryEmployee
    {
        //Atributes
        public int intId { get; set; }
        public string strName { get; set; }
        public double dblPayroll { get; set; }
        public int intCommission { get; set; }

        public ComissionEmployee()
        {
            intId = 0;
            strName = "undefined";
            intCommission = 0;
            dblPayroll = 0;
        }

        public ComissionEmployee(int pintId, string pstrName, double pdblPayroll, int pintCommission)
        {
            intId = pintId;
            this.strName = pstrName;
            dblPayroll = pdblPayroll;
            intCommission = pintCommission;
        }

        public void fnCalculatePayroll()
        {
            dblPayroll = dblPayroll + intCommission;
        }

        public void fnDisplayInfo()
        {
            Console.WriteLine("Id: " + intId);
            Console.WriteLine("Name: " + this.strName);
            Console.WriteLine("Payroll: " + dblPayroll);
            Console.WriteLine("Payroll and Commission: " + dblPayroll);
        }
    }
}
