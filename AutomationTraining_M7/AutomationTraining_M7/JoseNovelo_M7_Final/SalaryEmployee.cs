using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.JoseNovelo_M7_Final
{
    class SalaryEmployee : IPayrollCalculator
    {
        //Attributes
        public int intID { get; set; }
        public string strName { get; set; }
        public int intWeeklySalary { get; set; }

        public SalaryEmployee()
        {
            //intID = 0;
            //strName = "";
            //intWeeklySalary = 0;
        }

        public SalaryEmployee(int pintID, string pstrName, int pintWeeklySalary)
        {
            intID = pintID;
            strName = pstrName;
            intWeeklySalary = pintWeeklySalary;
        }

        public int fnCalculatePayroll()
        {
            return 0;
        }

        public void FnDisplayInfo()
        {
            Console.WriteLine("ID: " + intID);
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Weekly Salary: " + fnCalculatePayroll());
        }
    }
}
