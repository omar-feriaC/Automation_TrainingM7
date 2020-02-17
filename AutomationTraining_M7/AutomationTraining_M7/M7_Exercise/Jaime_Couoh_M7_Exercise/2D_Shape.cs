using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.M7_Exercise.Jaime_Couoh_M7_Exercise
{
    public class _2D_Shape : IShape
    {
        //Attributes from IShape
        public double dblArea { get; set; }
        public double dblPerimtr { get; set; }

        //Attribute for 2D_Shape
        public string strName { get; set; }

        //Constructor
        public _2D_Shape() { }

        //Constructor to initialized with 0
        public _2D_Shape (string pName)
        {
            dblArea = 0;
            dblPerimtr = 0;
            strName = pName;
         }

        //Constructor to provide values
        public _2D_Shape (double pArea, double pPerimtr, string pName)
        {
            dblArea = pArea;
            dblPerimtr = pPerimtr;
            strName = pName;
        }

        //IShape Methods
        public void DisplayInfo()
        {
            Console.WriteLine("Info for 2D_Shape");
            Console.WriteLine("Name is" + strName);
            Console.WriteLine("Area is" + dblArea);
            Console.WriteLine("Perimeter is" + dblPerimtr);
        }

    }
}
