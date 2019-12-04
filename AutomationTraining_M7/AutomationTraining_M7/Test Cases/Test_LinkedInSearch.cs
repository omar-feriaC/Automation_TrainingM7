using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases
{
    class Test_LinkedInSearch : Test_LinkedIn
    {
        LinkedIn_SearchPage objSearch;

        [Test]
        public void Search_LinkedIn()
        {
            //VARIABLES
            string[] arrTechnologies = { "Java", "C#", "C++", "Pega", "Cobol" };
            string[] arrLanguages = { "Spanish", "English" };

            //*****Step 6*****//
            //Reusing the Login Page functionality
            Login_LinkedIn();


            objSearch = new LinkedIn_SearchPage(driver);

            //**********//
            LinkedIn_SearchPage.fnSendInfo("4th Source");

            //Giving some time for the results and People button to load
            Task.Delay(5000).Wait();

            //Verifying that Initial Search executed successfully by checking if the filter bar is present or not
            Boolean isPresent = driver.FindElements(By.XPath("//div[contains(@class,'search-filters-bar')]")).Count() > 0;
            Assert.AreEqual(true, isPresent);


            //*****Step 7*****//
            LinkedIn_SearchPage.fnClickPeopleButton();

            //Giving some time for the page to reload
            Task.Delay(10000).Wait();

            // Verifying that People Filter was selected by checking if the filter Jobs dissapeared
            Boolean isPresent2 = driver.FindElements(By.XPath("//button[contains(@aria-label,'View only Jobs results')]")).Count() > 0;
            Assert.AreEqual(false, isPresent2);


            //*****Step 8*****//
            LinkedIn_SearchPage.fnClickAllFiltersButton();

            //Giving some time for the page to reload
            Task.Delay(5000).Wait();

            // Verifying that All Filter was selected by checking if the "All People Filters" Header is displayed
            Boolean isPresent3 = driver.FindElements(By.XPath("//h2[@id='advanced-facets-modal-header' and text()='All people filters']")).Count() > 0;
            Assert.AreEqual(true, isPresent3);


            //*****Step 9*****//


            LinkedIn_SearchPage.fnClickMexicoCheckbox();

            //Giving some time for the page to reload
            Task.Delay(5000).Wait();

            // Verifying that Mexico Checkbox was selected by checking if the counter of checked options is enabled and equal to 1
            Boolean isPresent4 = driver.FindElements(By.XPath("//span[@class= 'search-advanced-facets__selected-counts mv0 ml1' and text() ='1']")).Count > 0;
            Assert.AreEqual(true, isPresent4);


            LinkedIn_SearchPage.fnClickItalyCheckbox();

            //Giving some time for the page to reload
            Task.Delay(5000).Wait();


            // Verifying that Italy Checkbox was selected by checking if the counter of checked options is enabled and equal to 2
            Boolean isPresent5 = driver.FindElements(By.XPath("//span[@class= 'search-advanced-facets__selected-counts mv0 ml1' and text() ='2']")).Count > 0;
            Assert.AreEqual(true, isPresent5);


            //*****Step 10*****//


            foreach (string strlanguage in arrLanguages)
            {
                LinkedIn_SearchPage.fnSelectandClickLanguage(strlanguage);
            }


           

            //Giving some time for the page to reload
            Task.Delay(5000).Wait();

            // Verifying that English Checkbox was selected by checking if the counter of checked options is enabled and equal to 4
            Boolean isPresent7 = driver.FindElements(By.XPath("//span[@class= 'search-advanced-facets__selected-counts mv0 ml1' and text() ='4']")).Count > 0;
            Assert.AreEqual(true, isPresent7);


            //*****Step 11*****//
            LinkedIn_SearchPage.fnApplyAllFiltersButton();

            //Giving some time for the page to reload
            Task.Delay(5000).Wait();

            // Verifying that All Filters were applied by checking if the Main Page Filter has Mexico Selected
            Boolean isPresent8 = driver.FindElements(By.XPath("//span[@class='artdeco-button__text' and text()='Mexico']")).Count > 0;
            Assert.AreEqual(true, isPresent8);




            //*****Step 12****//


            foreach (string strtech in arrTechnologies)
            {
                LinkedIn_SearchPage.fnSearchTechnologies(strtech);
            }



           

            
        }
    }
}
