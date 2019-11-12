using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Carlos_Paz_M7_Excercise
{
    class _2D_Shape
    {
        public string Name;
        public double Area;
        public double Perimeter;
        public double Apotema;

        public void Initialize()
        {
            Name = "";
            Area = 0;
            Perimeter = 0;
            Apotema = 0;
        }

        public void DisplayInfo(string name, double apotema, double perimeter)
        {
            Name = name;
            Perimeter = perimeter;
            Apotema = apotema;

            Console.WriteLine("Figure Name: " + Name);
            Console.WriteLine("Area: " + Area);
            Console.WriteLine("Perimeter: " + Perimeter);
            Console.WriteLine("Apotema: " + Apotema);
        }
    }
}
