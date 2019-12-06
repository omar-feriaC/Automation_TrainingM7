using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.FinalM7
{
    interface IPayrollCalculator
    {
        int intID { get; set; }
        string strName { get; set; }
        void fnDisplayInfo();
    }
}
