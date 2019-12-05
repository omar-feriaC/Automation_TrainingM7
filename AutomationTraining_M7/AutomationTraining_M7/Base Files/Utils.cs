using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Base_Files
{
        public class Utils
        {
            public static void AssertEqualString(string strExpectedResult, String strActualResult)
            {

                Assert.AreEqual(strExpectedResult, strActualResult);

            }

            public static void AssertIsPresent(IWebElement boolElement)
            {

                Assert.IsTrue(boolElement.Displayed);

            }

        }
    }

