using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.RodrigoDominguez_M7_Final {
    class HourlyEmployee : IPayrollCalculator {
        public int intId { get; set; }
        public string strName { get; set; }
        public int dblHourRate;
        public int dblHoursWorked;

        public HourlyEmployee()
        {
            this.intId = 1;
            this.strName = "Employee A";
            this.dblHourRate = 0;
            this.dblHoursWorked = 0;
        }

        public HourlyEmployee(int Id, string Name, int HourRate, int HourWroked)
        {
            this.strName = Name;
            this.intId = Id;
            this.dblHourRate = HourRate;
            this.dblHoursWorked = HourWroked;
        }

        public int fnCalculatePayroll()
        {
            int dblPayroll = this.dblHourRate * this.dblHoursWorked;
            return dblPayroll;
        }

        public void fnDisplayInfo()
        {
            Console.WriteLine("Employee ID: " + intId);
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Payroll: " + fnCalculatePayroll());
        }
    }
}
