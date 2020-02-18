using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
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
            FnSendkeyAndClear(By.Id("username"), ConfigurationManager.AppSettings.Get("username"));
            FnSendkeyAndClear(By.Id("password"), ConfigurationManager.AppSettings.Get("password"));
        }

        //[Test, Order(1)]
        //public void TestLogin2()
        //{
        //    //FnSendkeyAndClear(By.Name("username"), ConfigurationManager.AppSettings.Get("username"));
        //    //FnSendkeyAndClear(By.Name("password"), ConfigurationManager.AppSettings.Get("password"));
        //    FnSendkeyAndClear(By.XPath("//*[@id='username']"), ConfigurationManager.AppSettings.Get("username2"));
        //    FnSendkeyAndClear(By.XPath("//*[@id='password']"), ConfigurationManager.AppSettings.Get("password2"));
        //}

        [Test, Order(1)]
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
