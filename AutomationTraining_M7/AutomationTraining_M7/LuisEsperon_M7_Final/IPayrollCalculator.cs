using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.LuisEsperon_M7_Final
{
    interface IPayrollCalculator
    {
        //Attributes
        int intId { get; set; }
        string strName { get; set; }

        //Methods
        void fnDisplayInfo();

    }
}
