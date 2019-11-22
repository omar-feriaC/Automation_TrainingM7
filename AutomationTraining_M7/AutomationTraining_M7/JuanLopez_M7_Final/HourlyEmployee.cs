using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.JuanLopez_M7_Final
{
    class HourlyEmployee : IPayrollCalculator
    {
        public int intId { get; set; }
        public string strName { get; set; }
        public void fnDisplayInfo() 
        {
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("---------- Data ---------- ");
            Console.WriteLine("Hours Worked: " + intHoursWorked);
            Console.WriteLine("ID: " + intId);
            Console.WriteLine("Base Pay: " + intBasePay);
            Console.WriteLine("Hour Rate: " + intHourRate);

        }
        public int intHoursWorked;
        public int intHourRate;
        public int intBasePay;
        public HourlyEmployee() 
        {
            strName = "noOne";
            intId = 0;
            intHoursWorked=0;
            intHourRate=0;
    }
        public HourlyEmployee(string pstrName, int pintId, int pintHoursWorked,int pintHourRate)
        {
            strName = pstrName;
            intId = pintId;
            intHoursWorked = pintHoursWorked;
            intHourRate= pintHourRate;
        }
        public void fnCalculatePayroll()
        {
            intBasePay = intHoursWorked * intHourRate;
        }
    }
}
