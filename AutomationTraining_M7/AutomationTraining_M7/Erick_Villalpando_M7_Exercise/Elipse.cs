using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Erick_Villalpando_M7_Exercise
{
    public class Elipse:_2D_Shape
    {
            int a;
            int b;
            //declaramos el constructor
            public Elipse(int x, int y)
            {
                a = x;
                b = y;
            }
            public int Area()
            {
                return a + b;
            }

            public int Perimeter()
            {
                return a - b;
            }

            class Principal
            {
                static void Main(string[] args)
                {
                //creamos objeto de la clase y le pasamos los parametros al constructor
                    Elipse obj = new Elipse(10, 20);
                    Console.WriteLine("Area of sphire is: " + obj.Area());
                    Console.WriteLine("Perimeter is: " + obj.Perimeter());
                    Console.ReadKey();
                }
            }
        }

    }
}
