using AutomationTraining_M7.Base_Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Rodrigo_Dominguez_M7 {
    class _3D_Shape : _2D_Shape {

        public double Volume { get; set; }

        public virtual new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Volume: " + this.Volume);
        }
        

        public _3D_Shape()
        {
            this.Volume = 0.0;
        }
    }
}
