using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Carlos_Paz_M7_Final
{
    interface IPayrollCalculator
    {
        int intID { get; set; }
        string strName { get; set; }
        void fnDisplayInfo();

    }
}
