using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Rodrigo_Dominguez_M7 {
    class Triangle : _2D_Shape{
        public double Base;
        public double Height;
        public double SideA;
        public double SideB;
        public double SideC;

        public Triangle()
        {
            
        }
        public Triangle(double Base, double Height, double Sidea, double Sideb, double Sidec, string Name)
        {
            this.Base = Base;
            this.Height = Height;
            this.SideA = Sidea;
            this.SideB = Sideb;
            this.SideC = Sidec;
            this.Name = Name;
        }

        public void CalculatePerimeter()
        {
            this.Perimeter = this.SideA + this.SideB + this.SideC;
        }

        public void CalculateArea()
        {
            this.Area = (this.Base * this.Height) / 2;
        }
    }
}
