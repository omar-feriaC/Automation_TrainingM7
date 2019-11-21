using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Carlos_Paz_M7_Final
{
    class HourlyEmployee : IPayrollCalculator
    {
        public int intID { get; set; }
        public string strName { get; set; }
        public int intHoursWorked { get; set; }
        public int intHourRate { get; set; }

        public HourlyEmployee()
        {
            intID = 0;
            strName = "";
            intHoursWorked = 0;
            intHourRate = 0;
        }

        public HourlyEmployee(int id, string name, int hoursWorked, int hoursRate)
        {
            intID = id;
            strName = name;
            intHoursWorked = hoursWorked;
            intHourRate = hoursRate;
        }

        public int fnCalculatePayroll()
        {
            return intHoursWorked * intHourRate;
        }

        public void fnDisplayInfo()
        {
            Console.WriteLine("ID: " + intID);
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Hours Worked: " + intHoursWorked);
            Console.WriteLine("Hour Rate: " + intHourRate);
            Console.WriteLine("Payroll: " + fnCalculatePayroll());
        }
    }
}
