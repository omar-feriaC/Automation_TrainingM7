using AutomationTraining_M7.Base_Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Rodrigo_Dominguez_M7 {
    class _2D_Shape : IShape {
        public string Name { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public double Volume { get; set; }


        public void DisplayInfo()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Area);
            Console.WriteLine(this.Perimeter);
        }

        public _2D_Shape()
        {
            this.Name = "undefined";
            this.Area = 0.0;
            this.Perimeter = 0.0;
        }
    }
}
