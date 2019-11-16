using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Edmundo_Sainz_M7_Excercise
{
    class Cls_2D_Shape : IShape
    {
        //Attributes
        public double dblArea { get; set; }
        public double dblPerimeter { get; set; }
        public string strName { get; set; }
        //Constructor
        public Cls_2D_Shape()
        {
            strName = "undefined";
            dblArea = 0;
            dblPerimeter = 0;
        }
        //Method
        public void fnDisplayInfo()
        {
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Area: " + dblArea);
            Console.WriteLine("Perimeter: " + dblPerimeter);
        }

    }
}
