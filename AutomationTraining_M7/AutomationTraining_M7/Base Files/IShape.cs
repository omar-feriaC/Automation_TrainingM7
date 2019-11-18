using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Base_Files {
    interface IShape {
        string Name { get; set; }
        double Perimeter { get; set; }
        double Area { get; set; }
        void DisplayInfo();
    }
}
