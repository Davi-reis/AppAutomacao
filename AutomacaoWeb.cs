using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAutomacao
{
    public class AutomacaoWeb
    {
        public IWebDriver driver;

        public AutomacaoWeb()
        {
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            driver = new ChromeDriver(service , new ChromeOptions());
        }

        public void web()
        {
            driver.Navigate().GoToUrl("https://login.esocial.gov.br/login.aspx");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//*[@id=\"login-acoes\"]/div[2]/p/button")).Click();

            driver.FindElement(By.XPath("//*[@id=\"login-certificate\"]")).Click();

            

            //driver.FindElement(By.XPath("//*[@id=\"enter-account-id\"]")).Click();
        }
    }

}
