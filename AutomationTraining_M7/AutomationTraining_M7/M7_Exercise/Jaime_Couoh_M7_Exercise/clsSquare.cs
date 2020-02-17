using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.M7_Exercise.Jaime_Couoh_M7_Exercise
{
    class clsSquare : _2D_Shape
    {
        //Attributes
        public double dblSide { get; set; }

        //Constructor
        public clsSquare() { }
        public clsSquare(double pdblSide, string pName)
        {
            dblSide = pdblSide;
            strName = pName;
        }

        //Methods
        public double FnCalculateArea()
        {
            dblArea = (dblSide) * (dblSide);
            return dblArea;
        }

        public double FnCalculatePerimtr()
        {
            dblPerimtr = (dblSide) * (4);
            return dblPerimtr;
        }

        public new void DisplayInfo()
        {
            Console.WriteLine("Info for square");
            Console.WriteLine("Name is " + strName);
            Console.WriteLine("Side size is " + dblSide);
            Console.WriteLine("Area size is " + dblArea);
            Console.WriteLine("Perimeter is " + dblPerimtr);
        }
    }
}
