using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class LinkedIn_LoginPage : BaseTest
    {
        /*DRIVER REFERENCE FOR POM*/
        private static IWebDriver _objDriver;

        /*LOCATORS FOR EACH ELEMENT*/
        readonly static string STR_USERNAME_TEXT = "username";
        readonly static string STR_PASSWORD_TEXT = "password";
        readonly static string STR_SIGNIN_BTN = "//button[text()='Sign in']";
        
        /*CONSTRUCTOR*/
        public LinkedIn_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }

        /*IWEBELEMEMT OBJECTS*/
        private static IWebElement objUserNameTxt => _objDriver.FindElement(By.Id("STR_USERNAME_TEXT"));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.Id("STR_PASSWORD_TEXT"));
        private static IWebElement objSignInBtn => _objDriver.FindElement(By.XPath("STR_SIGNIN_BTN"));



        /*METHODS*/
        //User Name Txt
        private static IWebElement GetUserNameField ()
        {



            return objUserNameTxt;

        }

        public static void fnEnterUserName(string pstrUserName)
        {


            objUserNameTxt.Clear();
            objUserNameTxt.SendKeys(pstrUserName);

        }


        //Password Txt
        private static IWebElement GetPassword()
        {
            return objPasswordTxt;
        }


        public static void fnEnterPassword(string pstrPassWord)
        {


            objPasswordTxt.Clear();
            objPasswordTxt.SendKeys(pstrPassWord);

        }




        //SignIn Button

        private static IWebElement GetSignInButton()
        {


            return objSignInBtn;

        }


        public static void fnClickSignInButton()
        {


            objSignInBtn.Click();
          

        }




    }



}
