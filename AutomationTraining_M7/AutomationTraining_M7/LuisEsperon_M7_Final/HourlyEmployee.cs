using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.LuisEsperon_M7_Final
{
    class HourlyEmployee : IPayrollCalculator
    {
        //Attributes
        public double dbHoursWorked { get; set; }
        public double dbHourRate { get; set; }

        public double dbHourlyPayroll { get; set; }

        public int intId { get; set; }
        public string strName { get; set; }

        public HourlyEmployee()
        {
            dbHoursWorked = 0;

            dbHourRate = 0;


        }


        public HourlyEmployee(double pdbHoursWorked, double pdbHourRate)
        {
            dbHoursWorked = pdbHoursWorked;

            dbHourRate = pdbHourRate;
        }

        public double fnCalculatePayroll()
        {

            dbHourlyPayroll = dbHoursWorked * dbHourRate;

            return dbHourlyPayroll;
        }

        public void fnDisplayInfo()
        {
            fnCalculatePayroll();
            Console.WriteLine("Hours Worked:  " + dbHoursWorked);
            Console.WriteLine("Hour Rate:  " + dbHourRate);
            Console.WriteLine("Payroll:  " + dbHourlyPayroll);
        }
    }
}
