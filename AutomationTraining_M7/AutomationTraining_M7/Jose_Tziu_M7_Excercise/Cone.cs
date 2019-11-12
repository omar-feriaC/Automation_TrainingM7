using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Jose_Tziu_M7_Excercise
{
    class Cone:_3D_Shape
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public Cone()
        {
            Name = "Cone";
            Radius = 0;
            Height = 0;
            Area = 0;
            Volume = 0;
        }

        public Cone(double r, double h)
        {
            Radius = r;
            Height = h;
        }

        public double CalculateBaseArea()
        {
            return 3.1416 * Radius * Radius;
        }

        public double CalculateVolume()
        {
            return Volume = (Height / 3) * 3.1416 * Radius * Radius;
        }

        public double CalculatePerimeter()
        {
            return Perimeter = 0.333 * 3.1416 * Radius * Radius * Height;
        }
    }
}
