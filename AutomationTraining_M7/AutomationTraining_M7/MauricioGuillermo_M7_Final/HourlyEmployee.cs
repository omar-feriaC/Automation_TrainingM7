using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.MauricioGuillermo_M7_Final
{
    class HourlyEmployee : IPayrollCalculator
    {
        public int intId { get; set; }
        public string strName { get; set; }
        public int intHoursWorked { get; set; }
        public int intHourRate { get; set; }
        
        public HourlyEmployee(int hId, string hName, int hHoursWorked, int hHoursRate)
        {
            intId = hId;
            strName = hName;
            intHoursWorked = hHoursWorked;
            intHourRate = hHoursRate;
        }

        public int fnCalculatePayroll()
        {
            return intHoursWorked * intHourRate;
        }

        public void fnDisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}
