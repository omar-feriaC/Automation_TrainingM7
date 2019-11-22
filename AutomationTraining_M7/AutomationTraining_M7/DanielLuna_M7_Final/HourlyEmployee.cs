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
        double dblPayroll { get; set; }

        public HourlyEmployee() 
        {
            intHoursWorked = 0;
            intHoursRate = 0;
            dblPayroll = 0;
            
        }

        public HourlyEmployee(int pintHoursWorked, int pintHoursRate, int pintID, string pstrName) 
        {
            intHoursWorked = pintHoursWorked;
            intHoursRate = pintHoursRate;
            intID = pintID;
            strName = pstrName;
        }

        public new void fnCalculatePayroll() 
        {
            dblPayroll = intHoursWorked * intHoursRate;
            
        }

        public new void fnDisplayInfo()
        {

            Console.WriteLine("Employee Name: " + base.strName);
            Console.WriteLine("Employee ID: " + base.intID);
            Console.WriteLine("Hours Worked: " + intHoursWorked);
            Console.WriteLine("Hours Pay Rate: " + intHoursRate);
            Console.WriteLine("Payroll Amount: " + dblPayroll);
            
        }




    }
}
