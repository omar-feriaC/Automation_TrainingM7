using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Daniel_Luna_M7_Exercise
{
    class Cone : Shape3D
    {
        double dblRadius { get; set; }
        double dblHeight { get; set; }
        double dblPi = 3.1416;

        public Cone()
        {
            this.strName = "Cone";
            dblRadius = 0;
            dblHeight = 0;
            dblPi = 0;
        }

        public Cone(double pdblRadius, double pdblHeight)
        {
            this.strName = "Cone";
            dblRadius = pdblRadius;
            dblHeight = pdblHeight;
                        
        }

        public double fnCalcArea()
        {
            dblArea = (dblPi * (dblRadius * dblRadius));
            return dblArea;
        }

        public double fnCalcVolume()
        {
            dblVolume = (fnCalcArea()/3*dblHeight);
            return dblVolume;
        }

        public new void fnDisplayInfo()
        {
            Console.WriteLine("Name: " + this.strName);
            Console.WriteLine("Area: " + fnCalcArea());
            Console.WriteLine("Volume: " + fnCalcVolume());
        }

    }
}
