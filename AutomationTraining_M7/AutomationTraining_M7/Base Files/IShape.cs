using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Base_Files
{
    public interface IShape{
        public double GetArea();
        public void SetArea(double area);
        public double GetPerimeter();
        public void SetPerimeter(double perimeter);
        public double GetVolume();
        public void SetVolume(double volume);
        public string GetName();
        public void SetName(string name);               

    };

}
