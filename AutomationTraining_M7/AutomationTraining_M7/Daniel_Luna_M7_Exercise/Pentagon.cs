using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Daniel_Luna_M7_Exercise
{
    class Pentagon : Shape2D
    {
        double dblSide { get; set; }
        double dblApotem { get; set; }

        public Pentagon() 
        {
            this.strName = "Pentagon";
            dblSide = 0;
            dblApotem = 0;
            
        }
        
        public Pentagon(double pdblSide, double pdblApotem) 
        {
            this.strName = "Pentagon";
            dblSide = pdblSide;
            dblApotem = pdblApotem;
        }

        private double fnCalcPerimeter() 
        {
            dblPerimeter = dblSide * 5;
            return dblPerimeter;
        }

        private double fnCalcArea() 
        {
            dblArea = (fnCalcPerimeter() * dblApotem) / 2;
            return dblArea;
        }

        public new void fnDisplayInfo() 
        {
            Console.WriteLine("Name: " + this.strName);
            Console.WriteLine("Perimeter: " + fnCalcPerimeter());
            Console.WriteLine("Area: " + fnCalcArea());            
        }
    }
}
