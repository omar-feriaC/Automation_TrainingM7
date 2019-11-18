using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Rodrigo_Dominguez_M7 {
    class Prism : _3D_Shape {

        public double BaseArea;
        public double Height;

        public void CalculateVolume()
        {
            this.Volume = this.BaseArea * this.Height;
        }

        public override void DisplayInfo()
        {
            CalculateVolume();
            base.DisplayInfo();
        }

        public Prism(double Height, double BaseArea, string Name)
        {
            this.Height = Height;
            this.BaseArea = BaseArea;
            this.Name = Name;
        }

        public Prism()
        {
            Name = "Prism";
            BaseArea = 0;
            Height = 0;
        }
    }
}
