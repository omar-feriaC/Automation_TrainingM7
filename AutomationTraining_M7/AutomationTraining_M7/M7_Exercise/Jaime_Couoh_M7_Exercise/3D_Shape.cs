using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.M7_Exercise.Jaime_Couoh_M7_Exercise
{
    class _3D_Shape : IShape
    {
        //Attributes from IShape
        public double dblArea { get; set; }
        public double dblPerimtr { get; set; }

        //Attribute for 3D_Shape
        public string strName { get; set; }
        public double dblVolume { get; set; }

        //Constructor
        public _3D_Shape() { }

        //Constructor to initialized
        public _3D_Shape(string pName)
        {
            dblArea = 0;
            dblPerimtr = 0;
            dblVolume = 0;
            strName = pName;
        }

        //Constructor for values
        public _3D_Shape(double pArea, double pPerimtr, double pVolume, string pName)
        {
            dblArea = pArea;
            dblPerimtr = pPerimtr;
            dblVolume = pVolume;
            strName = pName;

        }

        //IShape Methods
        public void DisplayInfo()
        {
            Console.WriteLine("Info for 3D_Shape");
            Console.WriteLine("Name is" + strName);
            Console.WriteLine("Area is" + dblArea);
            Console.WriteLine("Perimeter is" + dblPerimtr);
            Console.WriteLine("Volume is" + dblPerimtr);
        }

        public double fnCalculateVolume ()
        {
            return dblVolume;
        }
    }
}
