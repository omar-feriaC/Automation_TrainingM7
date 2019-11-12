using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Carlos_Paz_M7_Excercise
{
    class _3D_Shape : _2D_Shape
    {
        public double Volume;
        public double Side;
        public double High;

        public void Initialize()
        {
           Volume = 0;
        }

        public void DisplayInfo(string name, double apotema, double volume, double side, double high)
        {
            Name = name;
            High = high;
            Apotema = apotema;
            Volume = volume;
            Side = side;

            Console.WriteLine("Figure Name: " + Name);
            Console.WriteLine("High: " + High);
            Console.WriteLine("Apotema: " + Apotema);
            Console.WriteLine("Volume: " + Volume);

            Console.WriteLine("Press any key");

            Console.ReadKey();
 
        }
    }
}
