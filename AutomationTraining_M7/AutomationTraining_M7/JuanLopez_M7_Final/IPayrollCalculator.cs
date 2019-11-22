using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.JuanLopez_M7_Final
{
    interface IPayrollCalculator
    {
        int intId{ set; get; }
        string strName{ set; get; }
        void fnDisplayInfo();
    }
}
