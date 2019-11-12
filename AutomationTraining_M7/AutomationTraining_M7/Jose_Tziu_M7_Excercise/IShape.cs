using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Jose_Tziu_M7_Excercise
{
    public interface IShape
    {
        string Name { get; set; }
        double Area { get; set; }
        double Perimeter { get; set; }
        void DisplayInfo(IShape shape);
    }
}
