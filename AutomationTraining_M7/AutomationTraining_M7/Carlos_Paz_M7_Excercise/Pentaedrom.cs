using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Carlos_Paz_M7_Excercise
{
    class Pentaedrom : _3D_Shape
    {
        public void processData()
        {
            Initialize();
            
            Name = "Pentagon";
            Console.WriteLine("Calculating Pentadrom");
            Console.Write("Enter Apotema: ");
            string a = Console.ReadLine();
            Apotema = Convert.ToDouble(a);

            Console.WriteLine();

            Console.Write("Enter High: ");
            string b = Console.ReadLine();
            High = Convert.ToDouble(b);

            Console.WriteLine();

            Console.Write("Enter Side: ");
            string c = Console.ReadLine();
            Side = Convert.ToDouble(c);

            Console.WriteLine();


        }

        public void calculateVolume()
        {
            Volume = ((5 * Side * Apotema) / 2) * High;

            DisplayInfo("Pentaedro", Apotema, Volume, Side, High);
        }

    }
}
