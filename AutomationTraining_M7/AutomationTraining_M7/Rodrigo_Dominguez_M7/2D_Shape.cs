using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Rodrigo_Dominguez_M7 {
    class _2D_Shape {
        public string Name;
        public double Area;
        public double Perimeter;

        public double Base;
        public double Height;
        public double SideA;
        public double SideB;
        public double SideC;

        public void DisplayInfo()
        {
            Console.WriteLine(this.Area);
            Console.WriteLine(this.Perimeter);
        }

        public void CalculatePerimeter()
        {
            this.Perimeter = this.SideA + this.SideB + this.SideC;
        }

        public void CalculateArea()
        {
            this.Area = (this.Base * this.Height)/2;
        }

        public void SetValues(double Base, double Height, double Sidea, double Sideb, double Sidec)
        {
            this.Base = Base;
            this.Height = Height;
            this.SideA = Sidea;
            this.SideB = Sideb;
            this.SideC = Sidec;
    }

        public _2D_Shape()
        {
            this.Name = "undefined";
            this.Area = 0.0;
            this.Perimeter = 0.0;
        }
    }
}
