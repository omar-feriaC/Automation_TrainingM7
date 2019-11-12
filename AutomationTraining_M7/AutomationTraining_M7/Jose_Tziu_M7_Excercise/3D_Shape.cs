using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Jose_Tziu_M7_Excercise
{
    class _3D_Shape : IShape
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public double Volume { get; set; }

        public void DisplayInfo(IShape shape)
        {

        }

        public _3D_Shape()
        {
            Name = "undefined.";
            Area = 0;
            Perimeter = 0;
            Volume = 0;
        }
    }
}
