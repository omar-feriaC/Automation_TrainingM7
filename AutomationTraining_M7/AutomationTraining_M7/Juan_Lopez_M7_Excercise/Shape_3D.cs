using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomationTraining_M7.Juan_Lopez_M7_Excercise
{
    class Shape_3D : Shape_2D
    {
        public double Volumen
        {
            get { return (Anchura * Base1 * Altura * (3.1416 * 4 / 3)); }
        }
        public double Anchura;
        
        public new void DisplayInfo() 
        {
            Console.Out.WriteLine("Area:" + Area);
            Console.Out.WriteLine("Perimetro:" + Perimetro);
            Console.Out.WriteLine("Volumen:" + Volumen);
        }
        public void Shape_3D_Set()
        {
            Shape_2D_Set();
            Anchura = 0;
        }
        public double VolumenEllipsoid() 
        {
            return Area* Perimetro* Altura*(3.1416*4/3);
        }
    }
}
