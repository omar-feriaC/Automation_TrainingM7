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
        public string SEARCH_TEXTFIELD = "//input[@placeholder='Buscar']";
        public string GENTE_BUTTON = "//span[text()='Gente']";
        public string TOODSFILTROS_BUTTON = "//span[text()='Todos los filtros']";
        public string UBICACION_CHECKBOX = "//label[text()='México']";
        public string IDIOMAen_CHECKBOX = "/html[1]/body[1]/div[4]/div[1]/div[1]/div[2]/div[1]/div[1]/ul[1]/li[7]/form[1]/div[1]/fieldset[1]/ol[1]/li[2]/label[1]";
        public string IDIOMAes_CHECKBOX = "//label[text()='Español']";
        public string APLICAR_BUTTON = "//button[@id='ember1980']//span[text()='Aplicar']";

        private IWebDriver _driver;

        public LinkedIn_SearchPage(IWebDriver driver)
        {

            this._driver = driver;
        }

        //Define Properties
       public IWebElement searchTxt => _driver.FindElement(By.XPath(SEARCH_TEXTFIELD));
        public IWebElement genteBtn => _driver.FindElement(By.XPath(GENTE_BUTTON));
        public IWebElement filtrosBtn => _driver.FindElement(By.XPath(TOODSFILTROS_BUTTON));
        public IWebElement ubicacionChBtn => _driver.FindElement(By.XPath(UBICACION_CHECKBOX));
        public IWebElement idiomaEnChBtn => _driver.FindElement(By.XPath(IDIOMAen_CHECKBOX));
        public IWebElement aplicarBtn => _driver.FindElement(By.XPath(APLICAR_BUTTON));


    }
}
