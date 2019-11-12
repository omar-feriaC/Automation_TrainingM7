using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.FirstName_LastName_M7_Excercise
{
    class _2D_Shape : IShape
    {
        public static String Name;
        public static _2D_Shape(Double area,
                                Double perimetro,
            String name)
        {
            Area = area;
            Perimetro = perimetro;
            Name = name;
        }
    }
}
