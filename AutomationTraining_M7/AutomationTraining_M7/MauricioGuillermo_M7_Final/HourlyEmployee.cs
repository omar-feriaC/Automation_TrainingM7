using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.MauricioGuillermo_M7_Final
{
    class HourlyEmployee : IPayrollCalculator
    {
        public int HoursWorked;
        public int HourRate;
        public int intId { get; set; }
        public string strName { get; set; }

        public void fnDisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}
