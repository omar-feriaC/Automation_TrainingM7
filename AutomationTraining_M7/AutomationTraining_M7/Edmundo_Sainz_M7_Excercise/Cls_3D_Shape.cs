using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Edmundo_Sainz_M7_Excercise
{
    class Cls_3D_Shape : Cls_2D_Shape
    {
        //Attributes
        public double dblVolume { get; set; }
        
        //Contructor
        public Cls_3D_Shape()
        {
            dblVolume = 0;
        }
        //Method
        public new void fnDisplayInfo()
        {
            base.fnDisplayInfo();
            /*Console.WriteLine("Name: " + StrName);
            Console.WriteLine("Area: " + DblArea);
            Console.WriteLine("Perimeter: " + DblPerimeter);*/
            Console.WriteLine("Volume: " + dblVolume);
        }
    }
}
