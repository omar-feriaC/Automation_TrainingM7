using AutomationTraining_M7.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Prueba1 : BaseTest 
    {
        [Test, Order(0)]
        public void TestLogin1()
        {
            FnSendkeyAndClear(By.Name("userName"), ConfigurationManager.AppSettings.Get("username"));
            FnSendkeyAndClear(By.Name("password"), ConfigurationManager.AppSettings.Get("password"));
        }

        [Test, Order(1)]
        public void TestLogin2()
        {
            FnSendkeyAndClear(By.XPath("//*[@name='userName']"), ConfigurationManager.AppSettings.Get("username2"));
            FnSendkeyAndClear(By.XPath("//*[@name='password']"), ConfigurationManager.AppSettings.Get("password2"));
        }

        [Test, Order(2)]
        public void GetElemenHrefList()
        {
            IList<IWebElement> ElementList = driver.FindElements(By.XPath("//a"));
            foreach (IWebElement el in ElementList)
            {
                el.GetAttribute("href");
                Assert.Fail();
            }
        }



    }
}
