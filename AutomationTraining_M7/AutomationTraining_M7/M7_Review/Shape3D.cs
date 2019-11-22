using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.M7_Review
{
    class Shape3D : Shape2D
    {
        //Attributes
        public double dblVolume { get; set; }

        //Constructor
        public Shape3D()
        {
            dblVolume = 0;
        }

        //Methods
        //public virtual new void fnDisplayInfo()
        public new void fnDisplayInfo()
        {
            base.fnDisplayInfo();
            Console.WriteLine("SHAPE 3D");
            Console.WriteLine("Volume: " + dblVolume);
        }
    }
}
