using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.JuanLopez_M7_Final;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7
{
    class Program : BaseTest
    {
        static void Main(string[] args)
        {
            //public SalaryEmployee(int pintId, string pstrName,int pintWeeklySalary)
            SalaryEmployee salaryEmployee = new SalaryEmployee(1,"Juan Salary",3);
            //public HourlyEmployee(string pstrName, int pintId, int pintHoursWorked,int pintHourRate)
            HourlyEmployee hourlyEmployee = new HourlyEmployee("Juan Hourlly",1,5,15);
            //public CommissionEmployee(int pintCommission, int pintWeeklySalary, int pintId, string pstrName)
            CommissionEmployee commissionEmployee = new CommissionEmployee(10,10,1,"Juan Commission");
            Console.WriteLine (" -------------------- Salary -------------------- ");
            salaryEmployee.fnCalculatePayroll();
            salaryEmployee.fnDisplayInfo();
            Console.WriteLine(" -------------------- Hourly -------------------- ");
            hourlyEmployee.fnCalculatePayroll();
            hourlyEmployee.fnDisplayInfo();
            Console.WriteLine(" -------------------- Commission -------------------- ");
            commissionEmployee.fnCalculatePayroll();
            commissionEmployee.fnDisplayInfo();


            Console.ReadKey();

        }
    }
}
