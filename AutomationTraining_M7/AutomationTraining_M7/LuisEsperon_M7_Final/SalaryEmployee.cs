using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.LuisEsperon_M7_Final
{
    class SalaryEmployee : IPayrollCalculator
    {
        //Attributes
        public int intId { get; set; }
        public string strName { get; set; }

        public int intWeeklySalary { get; set; }
        public double dbSalaryPayroll { get; set; }

        public SalaryEmployee()
        {
            intId = 0;
            strName = "undefined";
            intWeeklySalary = 0;

        }


        public SalaryEmployee(int pintId, string pstrName, int pintWeeklySalary)
        {
            intId = pintId;
            strName = pstrName;
            intWeeklySalary = pintWeeklySalary;

        }


        public double fnCalculatePayroll()
        {
            dbSalaryPayroll = intWeeklySalary * 4;
            return dbSalaryPayroll;
        }



        public void fnDisplayInfo()
        {
            fnCalculatePayroll();
            Console.WriteLine("Name:  " + strName);
            Console.WriteLine("Id:  " + intId);
            Console.WriteLine("Weekly Salary:  " + intWeeklySalary);
            Console.WriteLine("Payroll:  " + dbSalaryPayroll);
        }



    }
}
