using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Danny_Beltran_M7_Exercise
{
    class Square : _2D_Shape
    {
        double myW;
        double myH;
        double myarea;
        double myperimeter;
        string name;

        _2D_Shape my2DShape = new _2D_Shape();

        public void SetVars()
        {
            my2DShape.SetVolume(30);
            my2DShape.SetArea(50);
            my2DShape.SetPerimeter(20);
            my2DShape.SetName("Square");
        }

        public void GetVars()
        {
            myarea = my2DShape.GetArea();
            myperimeter = my2DShape.GetPerimeter();
            name = my2DShape.GetName();
        }

        public void CalculateArea()
        {
            myarea = myW * myH;
        }

        public void SetWidth(double w)
        {
            myW = w;
        }
        public double GetWidth()
        {
            return myW;
        }
        public void SetHeight(double w)
        {
            myH = w;
        }
        public double GetHeight()
        {
            return myH;
        }
    }
}
