using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.RodrigoDominguez_M7_Final {
    interface IPayrollCalculator {
        int intId { get; set; }
        string strName { get; set; }

        void fnDisplayInfo();
    }
}
