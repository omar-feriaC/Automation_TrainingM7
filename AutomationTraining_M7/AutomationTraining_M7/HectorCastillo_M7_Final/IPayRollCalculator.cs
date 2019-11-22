using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.HectorCastillo_M7_Final
{
    interface IPayRollCalculator
    {
        int intId { get; set; }
        string strName { get; set; }
        double dblPayroll { get; set; }
        void fnDisplayInfo();
    }


}
