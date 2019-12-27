using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Mauricio_Guillermo_M7_Excercise
{
    class Cube : Shape_3D
    {
        double dblSide { get; set; }

        public Cube()
        {
            this.strName = "Cube";
            dblSide = 0;

        }

        public Cube(double sdblSide)
        {
            this.strName = "Cube";
            dblSide = sdblSide;
        }

        public double fnCalculateArea()
        {
            dblArea = 6 * (dblSide * dblSide);
            return dblArea;
        }

        
        public double fnCalculateVolume()
        {
            dblVolume = dblSide * dblSide * dblSide;
            return dblVolume;
        }

        public new void fnDisplayInfo()
        {

            fnCalculateArea();
            fnCalculateVolume();
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Area: " + dblArea);
            Console.WriteLine("Volume: " + dblVolume);

        }
    }
}
