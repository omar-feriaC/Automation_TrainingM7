using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.KevinMaldonado_M7_Final
{
    class HourlyEmployee : SalaryEmployee
    {

        public int intHrsWorked { get; set; }
        public int intHrRate { get; set; }
        public int intWeeklySalary { get; set; }

        public HourlyEmployee()
        {
            strName = "Kevin";
            intHrsWorked = 0;
            intHrRate = 0;
        }

        public HourlyEmployee(int pIntHrsWorked, int pIntHrRate)
        {
            this.intWeeklySalary = 0;
           intHrsWorked = pIntHrsWorked;
            intHrRate = pIntHrRate;
              
        }

        public int fnCalculatePayroll()
        {
             intWeeklySalary = intHrRate * intHrsWorked;
            return intWeeklySalary;
        }

        public void fnDisplayInfo()
        {
            Console.WriteLine("ID: " + intWeeklySalary);
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Weekly salary: " + fnCalculatePayroll());
        }
    }
}
