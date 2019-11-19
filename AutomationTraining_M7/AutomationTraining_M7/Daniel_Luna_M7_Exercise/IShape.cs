using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Daniel_Luna_M7_Exercise
{
    interface IShape
    {
        string strName { get; set; }
        double dblArea { get; set; }
        double dblPerimeter { get; set; }
        void fnDisplayInfo();
        
    }
}
