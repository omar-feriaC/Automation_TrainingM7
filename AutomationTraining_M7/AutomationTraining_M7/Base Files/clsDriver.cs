using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Base_Files
{
    class clsDriver : BaseTest
    {
        /*ATTRIBUTES*/
        private IWebDriver _objDriver;
        private WebDriverWait _driverWait;
        private IWebElement objElement;

        /*CONSTRUCTOR*/
        public clsDriver()
        {
            _objDriver = driver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 60));
        }

        /*METHODS*/
        public IWebElement WaitForElementThread(IWebDriver pobjDriver, By by, string pstrDesc)
        {
            Thread.Sleep(5000);
            objElement = pobjDriver.FindElement(by);
            return objElement;
        }

        public IWebElement WaitForElementDriver(IWebDriver pobjDriver, By by)
        {
            objElement = _driverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
            return objElement;
        }

        public IWebElement WaitForElementDriverFluent(IWebDriver pobjDriver, By by)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.Id("search_result")));
            return objElement;
        }

    }
}
