using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_LinkedInSearch : Test_LinkedIn
    {
        //LinkedIn_LoginPage objLogin; -- DELETE
        public WebDriverWait _driverWait;
        LinkedIn_SearchPage objSearch;
      
        [Test]
        public void Search_LinkedIn()
        {
            //VARIABLES
            string[] arrTechnologies = { "Java", "C#", "C++", "Pega", "Cobol" };
            string[] arrLanguages = { "Spanish", "English" };

            //Step# 1 .- Log In 
            Login_LinkedIn();

            objSearch = new LinkedIn_SearchPage(driver);
            LinkedIn_SearchPage.fnEnterSearchText("Testing");
            LinkedIn_SearchPage.fnClickSearchBtn();
            _driverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            LinkedIn_SearchPage.fnSelectPeople();
            _driverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            LinkedIn_SearchPage.fnSelectAllFilters();
            _driverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            LinkedIn_SearchPage.fnGetRegionMx();
            _driverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            LinkedIn_SearchPage.fnAddCountry("Italy");
            LinkedIn_SearchPage.fnSelectItaly();






        }
    }
}
