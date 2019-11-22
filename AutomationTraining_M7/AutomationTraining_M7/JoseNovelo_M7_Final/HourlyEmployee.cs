using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.JoseNovelo_M7_Final
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

        public HourlyEmployee (int pintID, string pstrName, int pintHoursWorked, int pintHourRate)
        {
            intID = pintID;
            strName = pstrName;
            intHoursWorked = pintHoursWorked;
            intHourRate = pintHourRate;
        }


        public int fnCalculatePayroll()
        {
            return intHoursWorked * intHourRate;

        }



            public void FnDisplayInfo()
        {
            Console.WriteLine("ID: " + intID);
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Hours Worked: " + intHoursWorked);
            Console.WriteLine("Hour Rate: " + intHourRate);
            Console.WriteLine("Payroll: " + fnCalculatePayroll());
        }
    }
}
