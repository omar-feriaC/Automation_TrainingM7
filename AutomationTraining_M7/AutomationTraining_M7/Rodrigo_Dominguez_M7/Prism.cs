using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Rodrigo_Dominguez_M7 {
    class Prism : _3D_Shape {

        public double BaseArea;
        public double Height;
        public double Base;
        public double HeightFigure;

        public void CalculateVolume()
        {
            this.BaseArea = this.Base * this.Height;
            this.Volume = this.BaseArea * this.HeightFigure;
        }

        public Prism(double Height, double HeightFigure, double Base, string Name)
        {
            this.Height = Height;
            this.HeightFigure = HeightFigure;
            this.Base = Base;
            this.Name = Name;
        }

        public Prism()
        {

        }
    }
}
