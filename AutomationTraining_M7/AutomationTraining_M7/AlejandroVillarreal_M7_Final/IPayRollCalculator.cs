using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.AlejandroVillarreal_M7_Final
{
    interface IPayRollCalculator
    {
        int intId { get; set; }
        string strName { get; set; }
        void fnDisplayInfo();

    }
}
