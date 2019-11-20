using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Luis_Esperon_M7_Excercise
{
    class Pentagon : Shape2D
    {

        double dblSide { get; set; }
        double dblApotem { get; set; }


        public Pentagon ()
        {
            this.strName = "Pentagon";
            dblSide = 0;
            dblApotem = 0;

        }

        public Pentagon(double pdblSide, double pdblApotem)
        {

            this.strName = "Pentagon";
            dblSide = pdblSide;
            dblApotem = pdblApotem;


        }


        private double fnCalclPerimeter()
        {

            dblPerimeter = dblSide * 5;


            return dblPerimeter;

        }


        private double fnCalclArea()
        {

            dblArea = (fnCalclPerimeter() * dblApotem) / 2;


            return dblArea;

        }



        public new void fnDisplayInfo()
        {
            fnCalclArea();
            fnCalclPerimeter();
            Console.WriteLine("Name:  " + strName);
            Console.WriteLine("Area:  " + dblArea);
            Console.WriteLine("Perimeter:  " + dblPerimeter);


        }






    }
}
