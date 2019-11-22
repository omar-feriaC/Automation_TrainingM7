using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.JoseNovelo_M7_Final
{
    class ComissionEmployee : SalaryEmployee
    {
        public int intComission { get; set; }

        
        public ComissionEmployee(int pintID, string pstrName, int pintWeeklySalary, int pintComission) : base(pintID, pstrName, pintWeeklySalary)
        {
            this.intID = pintID;
            this.strName = pstrName;
            this.intWeeklySalary = pintWeeklySalary;
            intComission = pintComission;
        }


        public new int fnCalculatePayroll()
        {
            return base.intWeeklySalary + intComission;
        }

        public void fnDisplayInfo()
        {
            Console.WriteLine("ID: " + base.intID);
            Console.WriteLine("Name: " + base.strName);
            Console.WriteLine("Weekly Salary: " + base.intWeeklySalary);
            Console.WriteLine("Comission: " + intComission);
            Console.WriteLine("Payroll: " + fnCalculatePayroll());
        }


    }
}
