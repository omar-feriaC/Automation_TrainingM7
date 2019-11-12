using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Carlos_Paz_M7_Excercise;
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

            /*FnSendkeyAndClear(By.Name("userName"), ConfigurationManager.AppSettings.Get("username"));
            FnSendkeyAndClear(By.Name("password"), ConfigurationManager.AppSettings.Get("password"));

            FnSendkeyAndClear(By.XPath("//*[@name='userName']"), ConfigurationManager.AppSettings.Get("username2"));
            FnSendkeyAndClear(By.XPath("//*[@name='password']"), ConfigurationManager.AppSettings.Get("password2"));

            driver.FindElement(By.Name("login")).Click();
            driver.FindElement(By.Name("login"));


            IList<IWebElement> ElementList = driver.FindElements(By.XPath("//a"));
            foreach (IWebElement el in ElementList)
            {
                //el.Click();
                el.GetAttribute("href");
            }

            

            //Console.ReadKey();*/
            Pentagon pentagon = new Pentagon();

            pentagon.processData();
            pentagon.calculateArea();

            Console.WriteLine();

            Pentaedrom pentaedrom = new Pentaedrom();

            pentaedrom.processData();
            pentaedrom.calculateVolume();


        }
    }
}
