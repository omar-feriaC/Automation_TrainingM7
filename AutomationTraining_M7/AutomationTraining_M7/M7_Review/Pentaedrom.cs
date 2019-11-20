using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.M7_Review
{
    class Pentaedrom : Shape3D
    {
        public double dblApotem { get; set; }
        public double dblHigh { get; set; }
        public double dblSide { get; set; }

        //Constructor default 
        public Pentaedrom()
        {
            strName = "Pentagon";
            dblApotem = 0;
            dblHigh = 0;
            dblSide = 0;
        }
        //Constructor with parameters
        public Pentaedrom(double pdblApotem, double pdblHigh, double pdblSide)
        {
            strName = "Pentaedrom";
            dblApotem = pdblApotem;
            dblHigh = pdblHigh;
            dblSide = pdblSide;
        }
    
        //Method to calculate volume 
        public double fnCalculateVolume()
        {
            dblVolume = ((5 * dblSide * dblApotem) / 2) * dblHigh;

            return dblVolume;
        }
        //Method to diaplay information
        public new void fnDisplayInfo()
        {
            Console.WriteLine("Name: " + this.strName);
            Console.WriteLine("Volume: " + fnCalculateVolume());
        }

    }
}
