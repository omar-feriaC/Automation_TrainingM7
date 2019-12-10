using AutomationTraining_M7.Base_Files;
using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
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

        //Wait driver
         WebDriverWait wait;

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

            
            //wait declaration
            wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
         

            //Wait until People button is visible
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(LinkedIn_SearchPage.STR_PEOPLE_BTN)));

            //Verifying that Initial Search executed successfully by checking if the filter bar is present or not
            Boolean isPresent = driver.FindElements(By.XPath("//div[contains(@class,'search-filters-bar')]")).Count() > 0;
            Assert.AreEqual(true, isPresent);


            //*****Step 7*****//
            LinkedIn_SearchPage.fnClickPeopleButton();

            // Wait until the filter Jobs dissapeared (Means Click to to People button was sucessful)
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//button[contains(@aria-label,'View only Jobs results')]")));

            //Wait until All filters button is visible
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(LinkedIn_SearchPage.STR_ALLFILTERS_BTN)));


            //*****Step 8*****//
            LinkedIn_SearchPage.fnClickAllFiltersButton();


            //Wait until Mexico Checkbox is visible
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(LinkedIn_SearchPage.STR_MEXICO_CHCBX)));


            
            // Verifying that All Filter was selected by checking if the "All People Filters" Header is displayed
            Boolean isPresent3 = driver.FindElements(By.XPath("//h2[@id='advanced-facets-modal-header' and text()='All people filters']")).Count() > 0;
            Assert.AreEqual(true, isPresent3);


            //*****Step 9*****//


            LinkedIn_SearchPage.fnClickMexicoCheckbox();

            

            // Verifying that Mexico Checkbox was selected by checking if the counter of checked options is enabled and equal to 1
            Boolean isPresent4 = driver.FindElements(By.XPath("//span[@class= 'search-advanced-facets__selected-counts mv0 ml1' and text() ='1']")).Count > 0;
            Assert.AreEqual(true, isPresent4);



            LinkedIn_SearchPage.fnAddCountryField("Italy");

            


            // Verifying that Italy Checkbox was selected by checking if the counter of checked options is enabled and equal to 2
            Boolean isPresent5 = driver.FindElements(By.XPath("//span[@class= 'search-advanced-facets__selected-counts mv0 ml1' and text() ='2']")).Count > 0;
            Assert.AreEqual(true, isPresent5);


            //*****Step 10*****//


            foreach (string strlanguage in arrLanguages)
            {
                LinkedIn_SearchPage.fnSelectandClickLanguage(strlanguage);
            }


           

          

            // Verifying that English Checkbox was selected by checking if the counter of checked options is enabled and equal to 4
            Boolean isPresent7 = driver.FindElements(By.XPath("//span[@class= 'search-advanced-facets__selected-counts mv0 ml1' and text() ='4']")).Count > 0;
            Assert.AreEqual(true, isPresent7);


            //*****Step 11*****//
            LinkedIn_SearchPage.fnApplyAllFiltersButton();


            //Wait until All Filters were applied by checking if the Main Page Filters has Mexico and Italy Selected
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[@class='artdeco-button__text' and text()='Locations (2)']")));




            try
            {
                //*****Step 12****//


                foreach (string strtech in arrTechnologies)
                {
                    LinkedIn_SearchPage.fnSearchTechnologies(strtech);

                    //Wait until results are displayed for each of the technologies
                    Task.Delay(3000).Wait();



                    Console.WriteLine("************************************************* ");

                    String strName = driver.FindElement(By.XPath("//span[@class = 'actor-name']")).Text;
                    Console.WriteLine("Name: " + strName);

                    String strTitle = driver.FindElement(By.XPath("//p[@class = 'subline-level-1 t-14 t-black t-normal search-result__truncate']")).Text;
                    Console.WriteLine("Role: " + strTitle);

                    String strLocation = driver.FindElement(By.XPath("//p[@class = 'subline-level-2 t-12 t-black--light t-normal search-result__truncate']")).Text;
                    Console.WriteLine("Location: " + strLocation);

                }

               


            }

           
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
            }






}
    }
}
