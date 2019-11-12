using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Erick_Villalpando_M7_Exercise
{
    public class _3D_Shape
    {
        public double Volume;
        public string Name;
        public double BaseArea;
        public double BasePerimeter;

        public void DisplayInfo()
        {
            Console.WriteLine(this.Volume);
        }

        public _3D_Shape()
        {
            this.Name = "undefined";
            this.BaseArea = 0.0;
            this.BasePerimeter = 0.0;
            this.Volume = 0.0;
        }
    }

    //elipse
    //sphere
    //windows azure.storage
}
