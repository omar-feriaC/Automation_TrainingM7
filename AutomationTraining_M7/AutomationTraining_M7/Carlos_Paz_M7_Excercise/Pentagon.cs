using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Carlos_Paz_M7_Excercise
{
    class Pentagon : _2D_Shape
    {
        public void processData()
        {
            Initialize();

            Name = "Pentagon";
            Console.WriteLine("Calculating Pentagon");
            Console.Write("Enter Apotema: ");
            string a = Console.ReadLine();
            Apotema = Convert.ToDouble(a);

            Console.WriteLine();

            Console.Write("Enter Perimeter: ");
            string b = Console.ReadLine();
            Perimeter = Convert.ToDouble(b);

            Console.WriteLine();
            

        }

        public void calculateArea()
        {
            Area = (Perimeter * Apotema) / 2;

            DisplayInfo("Pentagon", Apotema, Perimeter);
        }


    }
}
