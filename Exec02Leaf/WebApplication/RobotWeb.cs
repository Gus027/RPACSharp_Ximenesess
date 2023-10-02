using Exec02Leaf.DAO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exec02Leaf.WebApplication
{
    internal class RobotWeb
    {

        public IWebDriver driver;
        protected LoginDAO ld = new LoginDAO();
        public RobotWeb() 
        { 
             driver = new ChromeDriver();
        }

        public void InsertLogin() {

            driver.Navigate().GoToUrl("https://app.ximenesservice.com.br/login");
            

            // Preenchendo o usuario
            IWebElement inputUser = driver.FindElement(By.Name("login"));
            inputUser.Clear();
            inputUser.SendKeys(ld.GetUser());

            Thread.Sleep(2000);
            // Preenchendo a senha
            IWebElement inputPassword = driver.FindElement(By.Name("password"));
            inputPassword.Clear();
            inputPassword.SendKeys(ld.GetPassword());

            Thread.Sleep(2000);
            // Preenchendo o tipo = Notificação
            IWebElement selectElement = driver.FindElement(By.Name("unit_id"));
            SelectElement select = new SelectElement(selectElement);
            select.SelectByText("Notificação");

            Thread.Sleep(5000);
            driver.FindElement(By.Name("btn_entrar")).Click();

            Thread.Sleep(5000);
            SolicityDocument();
        }

        public void SolicityDocument() 
        {

            driver.Navigate().GoToUrl("https://app.ximenesservice.com.br/notificacao-pesquisa");

            Thread.Sleep(5000);
            IWebElement inputContrato = driver.FindElement(By.Name("contrato"));
            inputContrato.Clear();
            inputContrato.SendKeys(ld.GetContrat());

            Thread.Sleep(2000);
            driver.FindElement(By.Name("btn_buscar")).Click();

            Thread.Sleep(5000);
            driver.Navigate().GoToUrl("https://app.ximenesservice.com.br/download.php?file=aHR0cDovL3hpbWVuZXNmaWxlLmRuc2FsaWFzLmNvbS9wZGZzL25vdGlmaWNhY2FvLzA4OTgvMDg5ODI3MDEuUERG");

            IWebElement downloadButton = driver.FindElement(By.XPath("//*[@id=\"icon\"]/iron-icon"));
            downloadButton.Click();

            string pastaDestino = @"C:\Users\gusta\DocPDF";

            if (!Directory.Exists(pastaDestino))
            {
                Directory.CreateDirectory(pastaDestino);
            }

            Thread.Sleep(5000);

            string arquivoOrigem = @"C:\Users\gusta"; // Altere para o caminho real
            string arquivoDestino = Path.Combine(pastaDestino, "08982701.pdf"); // Altere o nome do arquivo conforme necessário

            File.Move(arquivoOrigem, arquivoDestino);
            // Feche o navegador
            driver.Quit();

        }
    }
}
