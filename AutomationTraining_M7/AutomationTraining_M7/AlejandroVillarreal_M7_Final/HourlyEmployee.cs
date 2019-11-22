using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.AlejandroVillarreal_M7_Final
{
    class HourlyEmployee : IPayRollCalculator
    {
        
        public int intId { get; set; }
        public string strName { get; set; }
        public int intHoursWorked { get; set; }
        public int intHourRate { get; set; }
        public int FinalPayroll;

        public HourlyEmployee()
        {
            this.intId = intId;
            this.strName = strName;
            this.intHoursWorked = intHoursWorked;
            this.intHourRate = intHourRate;
           // this.FinalPayroll = FinalPayroll;
    }

        public HourlyEmployee(int intId, string strName,int intHoursWorked,int intHourRate)
        {
            intId = 0;
            strName = "No Name Defined";
            intHoursWorked = 10;
            intHourRate = 5;
        }

        public void fnCalculatePayroll()
        {
            FinalPayroll = intHoursWorked* intHourRate;
        }

        public void fnDisplayInfo()
        {
            Console.WriteLine("ID =" + intId);
            Console.WriteLine("Name= "+ strName);
            Console.WriteLine("HoursWorked=" +intHoursWorked);
            Console.WriteLine("Hour Rate=" + intHourRate);
            Console.WriteLine("FinalPayRoll = " + FinalPayroll);
            
        }
        
    }
}
