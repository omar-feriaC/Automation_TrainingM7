using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Mauricio_Guillermo_M7_Excercise
{
    interface IShape
    {
        string strName { get; set; }
        double dblArea { get; set; }
        double dblPerimeter { get; set; }
        void fnDisplayInfo();
    }
}
