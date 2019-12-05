using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationTraining_M7.Test_Cases
{
    class M8_LinkedInSearch : Test_LinkedIn
    {
        
        LinkedIn_SearchT objSearch;

        [Test]
        public void Search_LinkedIn()
        {
            //VARIABLES
            string[] arrTechnologies = { "Java", "C#", "C++", "Pega", "Cobol" };
            string[] arrLanguages = { "Spanish", "English" };
            Login_LinkedIn();

            
            objSearch = new LinkedIn_SearchT(driver);
            LinkedIn_SearchT.fnEnterSearchValue("Test");
            Task.Delay(2500).Wait();
            LinkedIn_SearchT.fnClickPeopleButton();
            Task.Delay(2500).Wait();

            LinkedIn_SearchT.fnClickAllFiltersButton();
            Task.Delay(2500).Wait();
            LinkedIn_SearchT.fnClickLocationButton();
            Task.Delay(2500).Wait();
            LinkedIn_SearchT.fnClickLanguageButton1();
            Task.Delay(2500).Wait();
            LinkedIn_SearchT.fnEnterLocationValue("Italy");
            Task.Delay(2500).Wait();
            LinkedIn_SearchT.fnClickApplyButton();
            Task.Delay(2500).Wait();
            LinkedIn_SearchT.fnEnterSearchValue(arrTechnologies[0]);
            
                
            

        }
    }
}
