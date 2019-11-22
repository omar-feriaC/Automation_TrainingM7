using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.KevinMaldonado_M7_Final
{
    public class SalaryEmployee : IPayrollCalculator
    {
        public int intID { get; set; }
        public string strName { get; set; }
        public int intWeeklySalary { get; set; }

        public SalaryEmployee()
        {
            intID = 0;
            strName = "No name";
            intWeeklySalary = 0;
        }

        public SalaryEmployee (int pdblIntID, string pStrName, int pIntWeeklySalary)
        {
            intID = pdblIntID;
            strName = pStrName;
            intWeeklySalary = pIntWeeklySalary;
        }

        public void fnCalculatePayroll()
        {
            Console.WriteLine("ID: " + intID);
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Weekly salary: " + intWeeklySalary);
        }

        public void fnDisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}
