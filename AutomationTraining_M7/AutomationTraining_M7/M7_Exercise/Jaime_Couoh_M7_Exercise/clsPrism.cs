using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.M7_Exercise.Jaime_Couoh_M7_Exercise
{
    class clsPrism : _3D_Shape
    {
        //Attributes for Prism
        public double dblSide { get; set; }
        public double dblHigh { get; set; }

        //Constructor
        public clsPrism() { }

        public clsPrism (double pSide, double pHigh, string pName)
        {
            dblSide = pSide;
            dblHigh = pHigh;
            strName = pName;
        }

        //Methods
        public double FnCalculateVolume()
        {
            dblVolume = (dblSide) * (dblSide)*(dblHigh);
            return dblVolume;
        }

        public new void DisplayInfo()
        {
            Console.WriteLine("Info for Prism");
            Console.WriteLine("Name is " + strName);
            Console.WriteLine("Side size is " + dblSide);
            Console.WriteLine("High size is " + dblHigh);
            Console.WriteLine("Volume is " + dblVolume);
        }

    }
}
