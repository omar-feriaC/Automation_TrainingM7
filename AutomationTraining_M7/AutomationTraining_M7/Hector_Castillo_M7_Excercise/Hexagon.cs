using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Hector_Castillo_M7_Excercise
{
    class Hexagon : Shape2D
    {
        // Atributes
        double dblSide { get; set; }
        double dblApotema { get; set; }

        //Constructors
        public Hexagon()
        {
            this.strName = "Hexagono";
            dblSide = 0;
            dblApotema = 0;
        }

        public Hexagon(double pdblSide, double pdblApotema)
        {
            this.strName = "Hexagono";
            dblSide = pdblSide;
            dblApotema = pdblApotema;
        }

        //Method
        private  double fnCalcPerimeter()
        {
            dblPerimeter = dblSide * 6;
            return dblPerimeter;
        }

        private double fnCalcArea()
        {
            dblArea = (fnCalcPerimeter() * dblApotema) / 2;
            return dblArea;
        }
        
        public void fnDisplayInfo2()
        {
            Console.WriteLine("Name: " + this.strName);
            Console.WriteLine("Perimeter: " + fnCalcPerimeter());
            Console.WriteLine("Area: " + fnCalcArea());
            
        }
    }
}
