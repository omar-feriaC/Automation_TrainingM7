using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.HectorCastillo_M7_Final
{
    class HourlyEmployee : IPayRollCalculator
    {
        public int intId { get; set; }
        public string strName { get; set; }
        public double dblHoursWorked { get; set; }
        public double dblHourRate { get; set; }
        public double dblPayroll { get; set; }

        //Cosntructors
        public HourlyEmployee()
        {
            intId = 0;
            strName = "undefined";
            dblPayroll = 0;
            dblHoursWorked = 0;
            dblHourRate = 0;

        }

        public HourlyEmployee(int pintId, string pstrName, double pdblHoursWorked, double pdblHourRate)
        {
            intId = pintId;
            this.strName = pstrName;
            dblHoursWorked = pdblHoursWorked;
            dblHourRate = pdblHourRate;

        }

        public void fnCalculatePayroll()
        {
            dblPayroll = dblHoursWorked * dblHourRate;
        }

        public void fnDisplayInfo()
        {
            Console.WriteLine("Id: " + intId);
            Console.WriteLine("Name: " + this.strName);
            Console.WriteLine("Payroll: " + dblPayroll);
        }
    }

}

