using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Page_Objects
{
    class LinkedIn_SearchPage : BaseTest
    {
        public static string SEARCH_TEXTFIELD = "search-global-typeahead__input";
        public static string GENTE_BUTTON = "//span[text()='People']";
        public static string TOODSFILTROS_BUTTON = "//span[text()='Todos los filtros']";
        public static string UBICACION_CHECKBOX = "//label[text()='México']";
        public static string IDIOMAen_CHECKBOX = "/html[1]/body[1]/div[4]/div[1]/div[1]/div[2]/div[1]/div[1]/ul[1]/li[7]/form[1]/div[1]/fieldset[1]/ol[1]/li[2]/label[1]";
        public static string IDIOMAes_CHECKBOX = "//label[text()='Español']";
        public static string APLICAR_BUTTON = "//button[@id='ember1980']//span[text()='Aplicar']";

        private static IWebDriver _objDriver;

        //public  LinkedIn_SearchPage(IWebDriver driver)
        //{

        //    this._driver = driver;
        //}
        public LinkedIn_SearchPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }

        //Define Properties
        public static IWebElement searchTxt => _objDriver.FindElement(By.ClassName(SEARCH_TEXTFIELD));
        public static IWebElement genteBtn => _objDriver.FindElement(By.XPath(GENTE_BUTTON));
        public static  IWebElement filtrosBtn => _objDriver.FindElement(By.XPath(TOODSFILTROS_BUTTON));
        public static IWebElement ubicacionChBtn => _objDriver.FindElement(By.XPath(UBICACION_CHECKBOX));
        public static IWebElement idiomaEnChBtn => _objDriver.FindElement(By.XPath(IDIOMAen_CHECKBOX));
        public static IWebElement aplicarBtn => _objDriver.FindElement(By.XPath(APLICAR_BUTTON));

        //
        public static void fnSearchField(string strSearchString)
        {
            searchTxt.SendKeys(strSearchString);


        }
        
        public static void fnClickGente()
        {
            genteBtn.Click();
        }

    }
}
