using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.ErickVillalpando_M7_Final
{
    //5
interface IPayrollCalculator
        {
            int intID { get; set; }
            string strName { get; set; }
            void fnDisplayInfo();

        }
    //6
class SalaryEmployee : IPayrollCalculator
    {
        public int intID { get; set; }
        public string strName { get; set; }
        public int intWeeklySalary { get; set; }

        public SalaryEmployee()
        {
            intID = 0;
            strName = "";
            intWeeklySalary = 0;
        }

        public SalaryEmployee(int id, string name, int weeklySalary)
        {
            intID = id;
            strName = name;
            intWeeklySalary = weeklySalary;
        }

        public int fnCalculatePayroll()
        {
            return intWeeklySalary;
        }

        public void fnDisplayInfo()
        {
            Console.WriteLine("ID: " + intID);
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Weekly Salary: " + fnCalculatePayroll());

        }

    }
class HourlyEmployee : IPayrollCalculator {

    public int intID { get; set; }
    public string strName { get; set; }
    public int intHoursWorked { get; set; }
    public int intHourRate { get; set; }

    public HourlyEmployee()
    {
        intID = 0;
        strName = "";
        intHoursWorked = 0;
        intHourRate = 0;
    }

    public HourlyEmployee(int id, string name, int hoursWorked, int hoursRate)
    {
        intID = id;
        strName = name;
        intHoursWorked = hoursWorked;
        intHourRate = hoursRate;
    }

    public int fnCalculatePayroll()
    {
        return intHoursWorked * intHourRate;
    }

    public void fnDisplayInfo()
    {
        Console.WriteLine("ID: " + intID);
        Console.WriteLine("Name: " + strName);
        Console.WriteLine("Hours Worked: " + intHoursWorked);
        Console.WriteLine("Hour Rate: " + intHourRate);
        Console.WriteLine("Payroll: " + fnCalculatePayroll());
    }
}

class CommissionEmployee : SalaryEmployee
{
    public int intCommission { get; set; }

    public CommissionEmployee(int id, string name, int weeklySalary, int commission)
    {
        base.intID = id;
        base.strName = name;
        base.intWeeklySalary = weeklySalary;
        intCommission = commission;
    }

    public new int fnCalculatePayroll()
    {
        return base.intWeeklySalary + intCommission;
    }

    public void fnDisplayInfo()
    {
        Console.WriteLine("ID: " + base.intID);
        Console.WriteLine("Name: " + base.strName);
        Console.WriteLine("Weekly Salary: " + base.intWeeklySalary);
        Console.WriteLine("Comission: " + intCommission);
        Console.WriteLine("Payroll: " + fnCalculatePayroll());
    }
}
}
