
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Mauricio_Guillermo_M7_Excercise
{
    class Shape_2D : IShape
    {
        public string strName { get; set; }
        public double dblArea { get; set; }
        public double dblPerimeter { get; set; }
        
       

        public Shape_2D()
        {
            strName = "Undefined";
            dblArea = 0;
            dblPerimeter = 0;

        }

        
        public void fnDisplayInfo()
        {

            Console.WriteLine("Name:  " + strName);
            Console.WriteLine("Area:  " + dblArea);
            Console.WriteLine("Perimeter:  " + dblPerimeter);
        }

    }
}
