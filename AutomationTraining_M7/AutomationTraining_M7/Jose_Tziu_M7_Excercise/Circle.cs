using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Jose_Tziu_M7_Excercise
{
    class Circle:_2D_Shape
    {
        public double Radius { get; set; }
        public Circle()
        {
            Name = "Circle";
            Perimeter = 0;
            Area = 0;
            Radius = 0;
        }

        public Circle(double r)
        {
            Radius = r;
        }

        public double CalculateArea()
        {
            return Area = 3.1416 * Radius * Radius;
        }

        public double  CalculatePerimeter()
        {
            return Perimeter = 2 * 3.1416 * Radius;
        }
    }
}
