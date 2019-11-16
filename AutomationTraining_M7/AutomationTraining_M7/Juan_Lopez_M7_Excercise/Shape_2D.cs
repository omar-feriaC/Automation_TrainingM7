using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Juan_Lopez_M7_Excercise
{
    interface IShape
    {
        double Area();
        double Perimetro();
        double Volumen();
        void DisplayInfo();
        void Shape_Set();
    }
    class Shape_2D : IShape
    {
        public double Base1;
        public double Base2;
        public double lado1;
        public double lado2;
        public double Altura;
        public double Area  
        {
            get { return (Base1+Base2) * Altura / 2; }
        }

        public double Perimetro
        {
            get { return (Base1 + Base2+ lado1+ lado2); }
        }
 
        public void DisplayInfo()
        {
            Console.Out.WriteLine("Area:"+Area);
            Console.Out.WriteLine("Perimetro:" + Perimetro);
        }
        public void Shape_2D_Set() 
        {
            Base1 = 0;
            Base2 = 0;
            lado1 = 0;
            lado2 = 0;
            Altura = 0;

        }

    }
}
