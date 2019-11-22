using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.DannyBeltran_M7_Final
{
    interface IPayrollCalculator
    {
        int IntID { get; set; }
        string StrName { get; set; }
        int IntPayroll { get; set; }
        void FnDisplayInfo();
    }
}
