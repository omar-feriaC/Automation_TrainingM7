using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Mauricio_Guillermo_M7_Excercise
{
    
    class Trapezium : Shape_2D
    {

        double dblSBase { get; set; }
        double dblBBase { get; set; }
        double dblHeight { get; set; }
        double dblSide { get; set; }

        public Trapezium()
        {
            this.strName = "Trapezium";
            dblSBase = 0;
            dblBBase = 0;
            dblHeight = 0;
            dblSide = 0;
            
        }

        public Trapezium (double sdblSBase, double sdblBBase, double sdblHeight, double sdblSide)
        {
            this.strName = "Trapezium";
            dblSBase = sdblSBase;
            dblBBase = sdblBBase;
            dblHeight = sdblHeight;
            dblSide = sdblSide;
        }

        public double fnCalculateArea()
        {
            dblArea = ((dblSBase + dblBBase) * dblHeight) / 2;
            return dblArea;
        }

        public double fnCalculatePerimeter()
        {
            dblPerimeter = (dblSBase + dblBBase + (dblSide * 2));
            return dblPerimeter;
        }
        public new void fnDisplayInfo()
        {

            fnCalculateArea();
            fnCalculatePerimeter();
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Area: " + dblArea);
            Console.WriteLine("Area: " + dblPerimeter);
            
        }
    }
}
