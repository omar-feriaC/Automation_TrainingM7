using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.EdmundoSainz_M7_Final
{
    class HourlyEmployee : IPayrollCalculator
    {
        public double dblHrWroked { get; set; }
        public double dblHrRate { get; set; }
        public int intId { get; set; }
        public string strName { get; set; }
        public double dblPayroll { get; set; }

        public HourlyEmployee()
        {
            intId = 0;
            strName = "undifined";
            dblHrWroked = 0;
            dblHrRate = 0;
            dblPayroll = 0;
        }
        public HourlyEmployee(int ID, string Name, double HoursWorked , double HourRate)
        {
            intId = ID;
            strName = Name;
            dblHrWroked = HoursWorked;
            dblHrRate = HourRate;
        }

        public void fnCalculatePayroll()
        {
            dblPayroll = dblHrWroked * dblHrRate;
        }

        public void fnDisplayInfo()
        {
            fnCalculatePayroll();
            Console.WriteLine("Employee ID : " + intId);
            Console.WriteLine("Employee Name: " + strName);
            Console.WriteLine("Employee hours worked: " + dblHrWroked);
            Console.WriteLine("Employee hour rate: " + dblHrRate);
            Console.WriteLine("Employee Payroll: " + dblPayroll);
        }

    }
}
