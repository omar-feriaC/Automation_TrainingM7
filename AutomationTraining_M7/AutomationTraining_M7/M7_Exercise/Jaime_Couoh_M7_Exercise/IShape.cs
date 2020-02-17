using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.M7_Exercise.Jaime_Couoh_M7_Exercise
{
    interface IShape
    {
        //Attributes
        double dblArea { get; set; }
        double dblPerimtr { get; set; }

        //Methods
        void DisplayInfo();

    }
}
