using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class clsPHPTravels_LoginPage_2: BaseTest
    {

        /*METHODS/FUNCTIONS*/

        //Email
        private IWebElement GetEmailField()
        {
            return objEmailTxt;
        }



        //Password
        private IWebElement GetPasswordField()
        {
            return objPasswordTxt;
        }



        //Login Button


        private IWebElement GetLoginButton()
        {
            return objRememberMeChk;
        }


        /*Hamburger Button*/



    }
}
