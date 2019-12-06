using AutomationTraining_M7.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
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
        LinkedIn_SearchPage pgSearch;
      
        [Test]
        public void Search_LinkedIn()
        {
            try
            {
                //VARIABLES
                string[] arrTechnologies = { "Java", "C#", "C++", "Pega", "Cobol" };
                string[] arrLanguages = { "Spanish", "English" };

                //Step# 1 .- Log In 
                Login_LinkedIn();

                //Step# 2 .- Verify if captcha exist
                if (driver.Title.Contains("Verification") | driver.Title.Contains("Verificación"))
                {
                    //Switch to Iframe(0)
                    driver.SwitchTo().DefaultContent();
                    driver.SwitchTo().Frame(driver.FindElement(By.Id("captcha-internal")));
                    //Switch to Iframe that contains captcha.
                    IWebElement objCheckbox;
                    List<IWebElement> frames = new List<IWebElement>(driver.FindElements(By.TagName("iframe")));
                    for (int i = 0; i < frames.Count - 1; i++)
                    {
                        if (frames[i].GetAttribute("role").ToString() == "presentation" | frames[i].GetAttribute("role").ToString() != "")
                        {
                            driver.SwitchTo().Frame(i);
                            _driverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
                            objCheckbox = _driverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@role='checkbox']")));
                            if (objCheckbox.Enabled) { objCheckbox.Click(); }

                        }
                    }
                }

                //Step# 3 .- Select the filter for People or Gente
                pgSearch = new LinkedIn_SearchPage(driver);
                _driverWait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));

                pgSearch.fnEnterSearchText("Python");
                pgSearch.fnClickSearchButton();
                _driverWait.Until(ElementExists => pgSearch.GetPeopleButton()); //Wait for the 'People' or 'Gente' button to appear.
                pgSearch.fnClickPeopleButton(); //Click the 'People' or 'Gente' button.

                //Step#4 .- Select the option for 'All Filter' or 'Todos los filtros'
                _driverWait.Until(PageChanges => driver.Url.Contains("people"));
                _driverWait.Until(ElementExists => pgSearch.GetAllFiltersButton());
                pgSearch.fnClickAllFiltersButton();

                //Step#5 .- Select options for: 'Mexico' or 'México', and 'Italy'; in the location box.
                pgSearch.fnEnterLocationText("Mexico");
                _driverWait.Until(OptionAppears => pgSearch.GetMexicoOption());
                pgSearch.fnClickMexicoOption();

                pgSearch.fnEnterLocationText("Italy");
                _driverWait.Until(OptionAppears => pgSearch.GetItalyOption());
                pgSearch.fnClickItayOption();

                //Step#6 .- Select the profile language
                foreach(string language in arrLanguages)
                {
                    pgSearch.fnSelectProfileLanguate(language); //This will fail when the language is set to spanish because there is no item in the list for the languages in spanish
                }

                //Step#7 .- Apply the filters
                pgSearch.fnClickApplyButton();

                //Step#8 .- Perform search for each techonlogy provided in the arrTechnologies array.

                foreach (string technology in arrTechnologies)
                {
                    _driverWait.Until(SearchBoxToAppear => pgSearch.GetSearchBoxField());
                    pgSearch.fnEnterSearchText(technology);
                    _driverWait.Until(SearchWindowAppears => driver.FindElement(By.XPath("//*[@class='basic-typeahead__triggered-content search-global-typeahead__content search-box_focus']")).Displayed);
                    pgSearch.fnClickSearchButton();

                    IList<IWebElement> objSearchResultsName = driver.FindElements(By.XPath("//*[@class='search-results__list list-style-none ']/li//*[@class='actor-name']"));
                    IList<IWebElement> objSearchResultsRole = driver.FindElements(By.XPath("//*[@class='search-results__list list-style-none ']//*[contains(@class,'level-1')]//*[@dir='ltr']"));
                    IList<IWebElement> objSearchResultsUrl = driver.FindElements(By.XPath("//*[@class='search-results__list list-style-none ']//*[contains(@class,'search-result__info')]//a"));

                    //*[@class='search-results__list list-style-none ']//*[contains(@class,'search-result__info')]//a
                    foreach (var element in objSearchResultsName)
                    {
                        Console.WriteLine(element.Text);
                    }

                    foreach (var element in objSearchResultsRole)
                    {
                        Console.WriteLine(element.Text);
                    }

                    foreach (var element in objSearchResultsUrl)
                    {
                        Console.WriteLine(element.GetAttribute("href"));
                    }
                }


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
