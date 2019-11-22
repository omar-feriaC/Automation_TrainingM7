using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.RodrigoDominguez_M7_Final {
    class SalaryEmployee : IPayrollCalculator {
        public int intId { get; set; }
        public string strName { get; set; }
        public int intWeeklySalary;

        public SalaryEmployee() {
            this.strName = "Employee A";
            this.intId = 1;
            this.intWeeklySalary = 0;
        }

        public SalaryEmployee(int Id, string Name, int WeeklySalary)
        {
            this.intId = Id;
            this.strName = Name;
            this.intWeeklySalary = WeeklySalary;
        }

        public int fnCalculatePayroll() {
            return this.intWeeklySalary;
        }

        public void fnDisplayInfo()
        {
            Console.WriteLine("Employee ID: "+intId);
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Weekly Salary: " + intWeeklySalary);
        }
    }
}
