using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Daniel_Luna_M7_Exercise
{
    class Shape3D : Shape2D
    {
        //Attributes
        public double dblVolume { get; set; }
        public new string strName { get; set; }
        public new double dblArea { get; set; }

        //Constructor
        public Shape3D() 
        {
            strName = "Undefined";
            dblVolume = 0;
            dblArea = 0;
        }

        //Methods
        public new void fnDisplayInfo() 
        {
            base.fnDisplayInfo();
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Area: " + dblArea);
            Console.WriteLine("Volume: " + dblVolume);
        }
    }
}
