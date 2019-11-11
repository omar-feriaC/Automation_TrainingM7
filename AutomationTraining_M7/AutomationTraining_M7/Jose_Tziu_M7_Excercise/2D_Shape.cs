using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Jose_Tziu_M7_Excercise
{
    class _2D_Shape:_3D_Shape
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public _2D_Shape()
        {
            Name = "undefined.";
            Area = 0;
            Perimeter = 0;
        }

        public void DisplayInfo()
        {
            Console.WriteLine();
        }
    }
}
