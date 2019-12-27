using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Mauricio_Guillermo_M7_Excercise
{
    class Shape_3D : Shape_2D
    {
        public double dblVolume { get; set; }


        
        public Shape_3D()
        {

            dblVolume = 0;


        }

        

        public new void fnDisplayInfo()
        {
            base.fnDisplayInfo();
            Console.WriteLine("Name:  " + strName);
            Console.WriteLine("Area:  " + dblArea);
            Console.WriteLine("Perimeter:  " + dblPerimeter);
            Console.WriteLine("Volume:  " + dblVolume);


        }

    }
}
