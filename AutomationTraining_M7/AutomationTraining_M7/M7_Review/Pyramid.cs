using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.M7_Review
{
    class Pyramid : Shape3D
    {
        public double dblLenght { get; set; }
        public double dblWidth { get; set; }
        public double dblHeight { get; set; }

        //Constructor default 
        public Pyramid()
        {
            strName = "Pyramid";
            dblLenght = 0;
            dblWidth = 0;
            dblHeight = 0;
        }
        //Constructor with parameters
        public Pyramid(double pdbllenght, double pdblwidth, double pdblheight)
        {
            strName = "Pyramid";
            dblLenght = pdbllenght;
            dblWidth = pdblwidth;
            dblHeight = pdblheight;
            fnCalculateArea();
            fnCalculatePerimeter();
            fnCalculateVolume();
        }
        //Method to calculate area 
        public void fnCalculateArea()
        {
            dblArea = dblLenght * dblWidth;
        }
        //Method to calculate perimeter 
        public void fnCalculatePerimeter()
        {
            dblPerimeter = (dblLenght * 2) + (dblWidth * 2);
        }
        //Method to calculate volume 
        public void fnCalculateVolume()
        {
            fnCalculateArea();
            dblVolume = (dblArea * dblHeight) / 3;
        }
        //Method to diaplay information
        public new void fnDisplayInfo()
        {
            //fnCalculatePerimeter();
            //fnCalculateArea();
            //fnCalculateVolume();
            base.fnDisplayInfo();
        }

    }
}
