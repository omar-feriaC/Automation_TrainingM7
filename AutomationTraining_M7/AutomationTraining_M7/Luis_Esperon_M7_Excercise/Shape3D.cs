using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Luis_Esperon_M7_Excercise
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

        public new void fnDisplayInfo()
        {
            base.fnDisplayInfo();
            //Console.WriteLine("Name:  " + strName);
            //Console.WriteLine("Area:  " + dblArea);
            //Console.WriteLine("Perimeter:  " + dblPerimeter);
            Console.WriteLine("Volume:  " + dblVolume);


        }


    }
}
