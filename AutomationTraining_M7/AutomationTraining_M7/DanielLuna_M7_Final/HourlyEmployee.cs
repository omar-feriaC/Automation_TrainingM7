using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.DanielLuna_M7_Final
{
    class HourlyEmployee : SalaryEmployee
    {
        int intHoursWorked { get; set; }
        int intHoursRate { get; set; }

        public HourlyEmployee() 
        {
            intHoursWorked = 0;
            intHoursRate = 0;
            
        }

        public HourlyEmployee(int pintHoursWorked, int pintHoursRate) 
        {
            intHoursWorked = pintHoursWorked;
            intHoursRate = pintHoursRate;
        }

        public new void fnCalculatePayroll() 
        {
            dblPayroll = intHoursWorked * intHoursRate;
        }

        public new void fnDisplayInfo()
        {
            Console.WriteLine("Payroll Amount: " + dblPayroll);
            
        }




    }
}
