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

            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//*[@id=\"login-acoes\"]/div[2]/p/button")).Click();

            driver.FindElement(By.XPath("//*[@id=\"login-certificate\"]")).Click();

            driver.FindElement(By.XPath("//*[@id=\"menuDownload\"]")).Click();

            driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div/ul/li[4]/ul/li[2]/a")).Click();

            driver.FindElement(By.XPath("//*[@id=\"TipoPedido\"]")).Click();

            driver.FindElement(By.XPath("//*[@id=\"TipoPedido\"]/option[2]")).Click();

            driver.FindElement(By.XPath("//*[@id=\"DataInicial\"]")).SendKeys(DateTime.Now.AddDays(-180).ToString());           

            driver.FindElement(By.XPath("//*[@id=\"DataFinal\"]")).SendKeys(DateTime.Now.AddDays(-2).ToString());

            driver.FindElement(By.XPath("//*[@id=\"btnSalvar\"]")).Click();

            driver.FindElement(By.XPath("//*[@id=\"conteudo - pagina\"]/form/section/div/div[4]/input")).Click();




        }
    }

}
