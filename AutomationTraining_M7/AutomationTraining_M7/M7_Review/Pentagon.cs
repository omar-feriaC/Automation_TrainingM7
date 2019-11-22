using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.M7_Review
{
    class Pentagon : Shape2D
    {
        double dblSide { get; set; }
        double dblApotem { get; set; }

        public Pentagon()
        {
            strName = "Pentagon";
            dblSide = 0;
            dblApotem = 0;

        }

        public Pentagon(double pdblSide, double pdblApotem)
        {
            strName = "Pentagon";
            dblSide = pdblSide;
            dblApotem = pdblApotem;
            fnCalcPerimeter();
            fnCalcArea();
        }

        public double fnCalcPerimeter()
        {
            dblPerimeter = dblSide * 5;
            return dblPerimeter;
        }

        public double fnCalcArea()
        {
            dblArea = (fnCalcPerimeter() * dblApotem) / 2;
            return dblArea;
        }

        public new void fnDisplayInfo()
        {
            //fnCalcPerimeter();
            //fnCalcArea();
            Console.WriteLine("Name: " + this.strName);
            Console.WriteLine("Perimeter: " + fnCalcPerimeter());
            Console.WriteLine("Area: " + fnCalcArea());
        }
    }

}
