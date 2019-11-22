using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTraining_M7.Base_Files;

namespace AutomationTraining_M7.Danny_Beltran_M7_Exercise
{
    public class _2D_Shape : IShape
    {
        protected double myarea;
        protected double myperimeter;
        protected string myname;

        public double GetArea()
        {
            return myarea;
        }
        public void SetArea(double area)
        {
            myarea = area;
        }

        public double GetPerimeter()
        {
            return myperimeter;
        }
        public void SetPerimeter(double perimeter)
        {
            myperimeter = perimeter;
        }
        public string GetName()
        {
            return myname;
        }
        public void SetName(string name)
        {
            myname = name;
        }

        
        public void DisplayInfo()
        {
            Console.WriteLine(myarea);
            Console.WriteLine(myname);
            Console.WriteLine(myperimeter);
            Console.ReadLine();
        }
        public void Main(string[] args)
        {
            myarea = 0;
            myperimeter = 0;
            myname = "Undefined";
        }

        public double GetVolume()
        {
            throw new NotImplementedException();
        }

        public void SetVolume(double volume)
        {
            throw new NotImplementedException();
        }
    }
}