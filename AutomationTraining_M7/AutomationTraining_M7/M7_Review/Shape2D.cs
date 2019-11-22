using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.M7_Review
{
    class Shape2D : IShape
    {
        //Attributes
        public string strName { get; set; }
        public double dblArea { get; set; }
        public double dblPerimeter { get ; set; }

        //Constructor
        public Shape2D()
        {
            strName = "undefined";
            dblArea = 0;
            dblPerimeter = 0;
        }
        
        //Methods
        public void fnDisplayInfo()
        {
            Console.WriteLine("SHAPE 2D");
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Area: " + dblArea);
            Console.WriteLine("Perimeter: " + dblPerimeter);
        }


    }
}
