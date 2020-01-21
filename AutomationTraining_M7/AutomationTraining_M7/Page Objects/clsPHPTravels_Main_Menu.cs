using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace AutomationTraining_M7.Page_Objects
{
    class clsPHPTravels_Main_Menu
    {
        /*ATTRIBUTES*/
        public static WebDriverWait _driverWait;
        private static IWebDriver _objDriver;
        public static Dictionary<string, string> lisValues = new Dictionary<string, string>();

        /*LOCATORS DESCRIPTION*/
        readonly static string strTotalAdmins = "//a[text()=' "+"Modules"+ "']";

        /*CONSTRUCTOR*/
        public clsPHPTravels_Main_Menu(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objTotalAdmins;// = _objDriver.FindElement(By.Name(strTotalAdmins)); 


        /*METHODS/FUNCTIONS*/

        public void clsPHPTravels_Main_Menu_click(string strMenuOpt, string strMenuSub)
        {
            if (strMenuSub=="Menu") { objTotalAdmins = _objDriver.FindElement(By.XPath("//a[text()=' " + strMenuOpt + "']")); }
            if (strMenuSub == "SubMenu") { objTotalAdmins = _objDriver.FindElement(By.XPath("//a[text()='" + strMenuOpt + "']")); }
            objTotalAdmins.Click();
        }

       
 


    }
}
