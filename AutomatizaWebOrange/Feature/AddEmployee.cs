using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomatizaWebOrange.Feature
{
    [TestClass]
    public class AddEmployee : Login
    {
        [TestMethod]
        public void ValidarAddEmployee()
        {
            Driver.FindElement(By.Name("username")).SendKeys("Admin");
            Driver.FindElement(By.Name("password")).SendKeys("admin123");
            Driver.FindElement(By.XPath("//*[@id=\'app\']/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button")).Submit();
            Driver.FindElement(By.XPath("//*[@id=\'app\']/div[1]/div[1]/aside/nav/div[2]/ul/li[2]/a/span")).Click();
            Driver.FindElement(By.XPath("//*[@id=\'app\']/div[1]/div[1]/header/div[2]/nav/ul/li[3]")).Click(); // add employee
            Driver.FindElement(By.XPath("//*[@id=\'app\']/div[1]/div[2]/div[2]/div/div/form/div[1]/div[2]/div[1]/div[1]/div/div/div[2]/div[1]/div[2]/input")).SendKeys("Joana");
            Driver.FindElement(By.XPath("//*[@id=\'app\']/div[1]/div[2]/div[2]/div/div/form/div[1]/div[2]/div[1]/div[1]/div/div/div[2]/div[2]/div[2]/input")).SendKeys("Aparecida");
            Driver.FindElement(By.XPath("//*[@id=\'app\']/div[1]/div[2]/div[2]/div/div/form/div[1]/div[2]/div[1]/div[1]/div/div/div[2]/div[3]/div[2]/input")).SendKeys("Ferreira");
            Driver.FindElement(By.XPath("//*[@id=\'app\']/div[1]/div[2]/div[2]/div/div/form/div[1]/div[1]/div/div[2]/div/button/i")).Click(); // botao + para inserir imagem
            //Driver.FindElement(By.XPath("//*[@id=\'app\']/div[1]/div[2]/div[2]/div/div/form/div[1]/div[1]/div/div[2]/div/div/img")).

        }
    }
}
