using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Luis_Esperon_M7_Excercise
{
    class Rhomboid : Shape2D
    {

        double dblSide { get; set; }
        double dblSide2 { get; set; }
        double dblBase { get; set; }

        double dblHeight { get; set; }

        public Rhomboid ()
            {

            strName = "Rhomboid";
            dblSide = 0;
            dblSide2 = 0;
            dblBase = 0;
            dblHeight = 0;
        }


        public Rhomboid (double pdblSide, double pdblSide2, double pdbBase, double pdbHeight)
        {

            strName = "Rhomboid";
            dblSide = pdblSide;
            dblSide2 = pdblSide2;
            dblBase = pdbBase;
            dblHeight = pdbHeight;
        }


        private double fnCalcPerimeter()
        {


            dblPerimeter = 2 * (dblSide + dblSide2);

            return dblPerimeter;

        }



        private double fnCalcArea()
        {


            dblArea = dblBase * dblHeight;

            return dblArea;

        }



        public new void fnDisplayInfo()
            {

            fnCalcPerimeter();
            fnCalcArea();
            Console.WriteLine("Name:  " + strName);
            Console.WriteLine("Area:  " + dblArea);
            Console.WriteLine("Perimeter:  " + dblPerimeter);

        }



    }
}
