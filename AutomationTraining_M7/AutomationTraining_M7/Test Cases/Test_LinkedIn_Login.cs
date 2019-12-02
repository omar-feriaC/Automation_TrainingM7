using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using System.Configuration;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_LinkedIn_Login:BaseTest
    {
        LinkedIn_LoginPageTziu pgLogin;
        [Test]
        public void LinkedIn_Login()
        {
            try
            {
                Console.WriteLine("Test start");
                pgLogin = new LinkedIn_LoginPageTziu(driver);
                Assert.IsTrue(driver.Title.Contains("Login"), "Titles do not match"); //Validate login page loads successfully

                /*Perform page actions*/
                pgLogin.fnEnterUserName(ConfigurationManager.AppSettings.Get("username"));
                pgLogin.fnEnterPassword(ConfigurationManager.AppSettings.Get("password"));
                pgLogin.fnClickSignInButton();

                /*Validate*/
                Assert.AreEqual("LinkedIn", driver.Title);
                Console.WriteLine("Test success!");
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }
            finally
            {

            }
        }
    }
}
