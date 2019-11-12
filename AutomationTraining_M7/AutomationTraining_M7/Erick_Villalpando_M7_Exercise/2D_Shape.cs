using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Erick_Villalpando_M7_Exercise
{

    public interface IShape {
        double Area();
        double Perimeter();
        double Volumen();
    }

public class _2D_Shape
{
    public string Name;
    public double Area;
    public double Perimeter;

    public void DisplayInfo()
    {
        Console.WriteLine(this.Area);
        Console.WriteLine(this.Perimeter);
    }

    public _2D_Shape()
    {
        this.Name = "undefined";
        this.Area = 0.0;
        this.Perimeter = 0.0;
    }
}
}
