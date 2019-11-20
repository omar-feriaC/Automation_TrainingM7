using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Luis_Esperon_M7_Excercise
{
    interface IShape
    {

        double dblArea { get; set; }
        double dblPerimeter { get; set; }
        string strName { get; set; }
        void fnDisplayInfo();

    }
}
