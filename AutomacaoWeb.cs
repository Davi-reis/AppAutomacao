using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Firefox;

namespace AppAutomacao
{
    public class AutomacaoWeb
    {
        public IWebDriver driver;

        TimeSpan TimeSpan = new TimeSpan(10);

        public AutomacaoWeb()
        {
            // codigo para não mostrar o CMD durante a execução do programa
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            driver = new ChromeDriver(service, new ChromeOptions());
            
        }

        public void web(string solicitacao)
        {     
            
            driver.Navigate().GoToUrl("https://login.esocial.gov.br/login.aspx");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//*[@id=\"login-acoes\"]/div[2]/p/button")).Click();

            //driver.FindElement(By.XPath("//*[@id=\"cert-digital-cloud\"]/button")).Click();

            driver.FindElement(By.XPath("//*[@id=\"login-certificate\"]")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"menuDownload\"]")));

            driver.FindElement(By.XPath("//*[@id=\"menuDownload\"]")).Click();            

            driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div/div/ul/li[4]/ul/li[2]/a")).Click();

            driver.FindElement(By.XPath("//*[@id=\"TipoPedido\"]")).Click();

            switch (solicitacao)
            {
                case "Todos os eventos entegues em um determinado periodo":
                    driver.FindElement(By.XPath("//*[@id=\"TipoPedido\"]/option[2]")).Click();
                    break;

                case "Todos os eventos de um determinado trabalhador":
                    driver.FindElement(By.XPath("//*[@id=\"TipoPedido\"]/option[3]")).Click();
                    break;

                case "Todos os eventos enviados por aplicação web":
                    driver.FindElement(By.XPath("//*[@id=\"TipoPedido\"]/option[4]")).Click();
                    break;

                case "Tabela de estacionamentos, Obras ou Unidades de Órgãos Publicos":
                    driver.FindElement(By.XPath("//*[@id=\"TipoPedido\"]/option[5]")).Click();
                    break;

                case "Tabela de Rubricas":
                    driver.FindElement(By.XPath("//*[@id=\"TipoPedido\"]/option[6]")).Click();
                    break;

                case "Tabela de lotações tributarias":
                    driver.FindElement(By.XPath("//*[@id=\"TipoPedido\"]/option[7]")).Click();
                    break;

                case "Tabela de processos Administrativos/judicias":
                    driver.FindElement(By.XPath("//*[@id=\"TipoPedido\"]/option[8]")).Click();
                    break;

                case "Tabela de operadores portuarios":
                    driver.FindElement(By.XPath("//*[@id=\"TipoPedido\"]/option[9]")).Click();
                    break;
            }

            

            //============================== Solicitação das Datas ==========================================

            driver.FindElement(By.XPath("//*[@id=\"DataInicial\"]")).Click();

            var queryDataInicial = driver.FindElement(By.XPath("//*[@id=\"DataInicial\"]"));
            DateTime dataInicial = DateTime.Now.AddDays(-33);
            queryDataInicial.SendKeys(dataInicial.ToString());

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[@id=\"DataFinal\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"DataFinal\"]")).Clear();

            var queryDataFinal = driver.FindElement(By.XPath("//*[@id=\"DataFinal\"]"));
            DateTime dataFinal = DateTime.Parse("02/01/2024");//DateTime.Now.AddDays(-6);// 
            queryDataFinal.SendKeys(dataFinal.ToString());

            //==============================================================================================

            driver.FindElement(By.XPath("//*[@id=\"btnSalvar\"]")).Click();

            driver.FindElement(By.XPath("//*[@id=\"conteudo-pagina\"]/form/section/div/div[4]/input")).Click();

            //========================= Aqui começa o download dos Arquivos ==================================



            //var upload = driver.FindElement(By.ClassName("icone-baixar"));

            //var upload = driver.FindElement(By.CssSelector("#DataTables_Table_0"));


            //*[@id="DataTables_Table_0"]/tbody/tr[2]/td[1]/text()
            //*[@id="DataTables_Table_0"]/tbody/tr[3]/td[1]/text()




        }
    }
}
           

            