using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class LinkedIn_SearchPage
    {
        /*DRIVER REFERENCE FOR POM*/
        private static IWebDriver _objDriver2;

        /*LOCATORS FOR EACH ELEMENT*/
 
        readonly static string STR_SEARCH_FIELD = "//input[@class = 'search-global-typeahead__input']";

        /*CONSTRUCTOR*/
        public LinkedIn_SearchPage(IWebDriver pobjDriver)
        {
            _objDriver2 = pobjDriver;
        }



        /*IWEBELEMEMT OBJECTS*/
        private static IWebElement objSearchField => _objDriver2.FindElement(By.XPath(STR_SEARCH_FIELD));

        /*METHODS*/
        //Search Field
        private IWebElement GetSearchField()
        {
            return objSearchField;
        }

        public static void fnSendInfo(string pstrInfo)
        {
            objSearchField.Clear();
            objSearchField.SendKeys(pstrInfo);
            objSearchField.SendKeys(Keys.Enter);
        }

    }
}
 