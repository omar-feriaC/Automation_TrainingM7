using AutomationTraining_M7.Base_Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Danny_Beltran_M7_Exercise
{
    public class _3D_Shape : IShape
    {
        protected double myarea;
        protected double myperimeter;
        protected string myname;
        protected double myvolume;
        public double GetArea()
        {
            return myarea;
        }

        public string GetName()
        {
            return myname;
        }

        public double GetPerimeter()
        {
            return myperimeter;
        }

        public double GetVolume()
        {
            return myvolume;
        }

        public void SetArea(double area)
        {
            myarea = area;
        }

        public void SetName(string name)
        {
            myname = name;
        }

        public void SetPerimeter(double perimeter)
        {
            myperimeter = perimeter;
        }

        public void SetVolume(double volume)
        {
            myvolume = volume;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(myarea);
            Console.WriteLine(myname);
            Console.WriteLine(myperimeter);
            Console.WriteLine(myvolume);
            Console.ReadLine();
        }
        public void Main(string[] args)
        {
            myarea = 0;
            myperimeter = 0;
            myvolume = 0;
            myname = "Undefined";
        }
    }
}
