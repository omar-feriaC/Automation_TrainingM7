using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Luis_Esperon_M7_Excercise
{
    class Pentahedrom : Shape3D
    {
        double dblSide { get; set; }
        double dblSlant { get; set; }
        double dblHeight { get; set; }

        public Pentahedrom()
        {

            strName = "Pentahedrom";
            dblSlant = 0;
            dblSide = 0;
            dblHeight = 0;
        }

        public Pentahedrom(double pdblSlant, double pdblSide, double pdblHeight)
        {

            strName = "Pentahedrom";
            dblSlant = pdblSlant;
            dblSide = pdblSide;
            dblHeight = pdblHeight;
        }


        private double fnCalcArea()
        {


            dblArea = (dblSide * dblSide) + ((4 * dblSide) /2) * dblSlant;

            return dblArea;

        }


        private double fnCalcVolume()
        {


            dblVolume =  ((dblSide * dblSide) * dblHeight)/3;
           

            return dblVolume;

        }



        public new void fnDisplayInfo()
        {

           
            fnCalcArea();
            fnCalcVolume();
            Console.WriteLine("Name:  " + strName);
            Console.WriteLine("Area:  " + dblArea);
            Console.WriteLine("Volume:  " + dblVolume);

        }


    }
}
