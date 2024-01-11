using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V118.Runtime;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AppAutomacao
{
    public class AutomacaoWeb
    {
        public IWebDriver driver;

        public AutomacaoWeb()
        {
            // codigo para não mostrar o CMD durante a execução do programa
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            driver = new ChromeDriver(service, new ChromeOptions());
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

            //============================== Solicitação das Datas ==========================================

            driver.FindElement(By.XPath("//*[@id=\"DataInicial\"]")).Click();

            var queryDataInicial = driver.FindElement(By.XPath("//*[@id=\"DataInicial\"]"));
            DateTime dataInicial = DateTime.Now.AddDays(-180);
            queryDataInicial.SendKeys(dataInicial.ToString());

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[@id=\"DataFinal\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"DataFinal\"]")).Clear();

            var queryDataFinal = driver.FindElement(By.XPath("//*[@id=\"DataFinal\"]"));
            DateTime dataFinal = DateTime.Now.AddDays(-3);
            queryDataFinal.SendKeys(dataFinal.ToString());

            //==============================================================================================

            driver.FindElement(By.XPath("//*[@id=\"btnSalvar\"]")).Click();

            driver.FindElement(By.XPath("//*[@id=\"conteudo-pagina\"]/form/section/div/div[4]/input")).Click();

            //========================= Aqui começa o download dos Arquivos ==================================
        }
    }
}
           

            