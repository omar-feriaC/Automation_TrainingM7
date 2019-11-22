using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomationTraining_M7.MauricioGuillermo_M7_Final
{
    class SalaryEmployee : IPayrollCalculator
    {
        public int intId { get; set; }
        public string strName { get; set; }
        public int intWeeklySalary { get; set; }

        public SalaryEmployee()
        {
            intId = 0;
            strName = "";
            intWeeklySalary = 0;
        }

        public SalaryEmployee(int sId, string sName, int sWeeklySalary)
        {
            intId = sId;
            strName = sName;
            intWeeklySalary = sWeeklySalary;
        }

        public int FnCalculatePayroll()
        {
            return intWeeklySalary;
        }

        public void fnDisplayInfo()
        {
            

        }
    }
}
