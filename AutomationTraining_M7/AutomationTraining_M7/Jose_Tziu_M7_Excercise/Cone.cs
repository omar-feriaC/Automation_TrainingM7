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
            BaseArea = 0;
            Volume = 0;
        }

        public Cone(double r, double h)
        {
            Radius = r;
            Height = h;
        }

        public void CalculateBaseArea()
        {
            BaseArea = 3.1416 * Radius * Radius;
        }

        public void CalculateVolume()
        {
            Volume = (Height / 3) * 3.1416 * Radius * Radius;
        }

        public void CalculatePerimeter()
        {
            Perimeter = (1 / 3) * 3.1416 * Radius * Radius * Height;
        }
    }
}
