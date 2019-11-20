using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Luis_Esperon_M7_Excercise
{
    class Shape2D : IShape
    {
        //Atributes
        public double dblArea { get; set; }
        public double dblPerimeter { get; set; }
        public string strName { get; set; }

        //Constructor
        public Shape2D()
        {
            strName = "Undefined";
            dblArea = 0;
            dblPerimeter = 0;


        }

        //Methods
        public void fnDisplayInfo()
        {

            Console.WriteLine("Name:  " + strName);
            Console.WriteLine("Area:  " + dblArea);
            Console.WriteLine("Perimeter:  " + dblPerimeter);
        }

       
    }
}
