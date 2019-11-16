using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Edmundo_Sainz_M7_Excercise
{
    class Rectangle : Cls_2D_Shape
    {
        public double dblLenght { get; set; }
        public double dblWidth { get; set; }
        //Constructor default 
        public Rectangle()
        {
            strName = "Rectangle";
            dblLenght = 0;
            dblWidth = 0;
        }
        //Constructor with parameters
        public Rectangle(double pdbllenght, double pdblwidth)
        {
            strName = "Rectangle";
            dblLenght = pdbllenght;
            dblWidth = pdblwidth;
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
        //Method to diaplay information
        private new void fnDisplayInfo()
        {
            fnCalculatePerimeter();
            fnCalculateArea();
            base.fnDisplayInfo();
        }

    }
}
