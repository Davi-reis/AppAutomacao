using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            driver = new ChromeDriver();
        }

        public void web()
        {
            driver.Navigate().GoToUrl("https://login.esocial.gov.br/login.aspx");

            driver.FindElement(By.XPath("//*[@id=\"login-acoes\"]/div[2]/p/button")).Click();

            driver.FindElement(By.XPath("//*[@id=\"accountId\"]")).SendKeys("-- colocar o CPF --");

            driver.FindElement(By.XPath("//*[@id=\"enter-account-id\"]")).Click();
        }
    }

}
