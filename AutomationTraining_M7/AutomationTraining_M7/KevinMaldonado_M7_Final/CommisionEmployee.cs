using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.KevinMaldonado_M7_Final
{
    class CommisionEmployee : SalaryEmployee
    {
        public int intComission { get; set; }
        public int intSalary { get; set; }


        public int CommisionEmployee(int pIntComission)
        {
            intComission = pIntComission;
            return intComission;

        }

        public void fnCalculatePayroll()
        {
            intSalary = intWeeklySalary + intComission;
        }

        public int fnDisplayInfo()
        {
            Console.WriteLine("Comission : " + fnCalculatePayroll);
          
        }

    }
}