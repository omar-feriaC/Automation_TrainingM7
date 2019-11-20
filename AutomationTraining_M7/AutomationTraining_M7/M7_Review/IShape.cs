using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.M7_Review
{
    interface IShape
    {
        string strName { get; set; }
        double dblArea { get; set; }
        double dblPerimeter { get; set; }
        void fnDisplayInfo();
    }
}
