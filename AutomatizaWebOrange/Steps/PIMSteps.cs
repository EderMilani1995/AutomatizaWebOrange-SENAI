using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatizaWebOrange.PageObjects;

namespace AutomatizaWebOrange.Steps
{
    public class PIMSteps : Inicializacao
    {
        public static void Login(string username, string password)  // Teste para realizar o login com sucesso
        {
            Driver.FindElement(LoginPage.username).SendKeys(username);
            Driver.FindElement(LoginPage.password).SendKeys(password);
            Driver.FindElement(LoginPage.login).Click();
            Thread.Sleep(3000);
            Driver.FindElement(PIMPage.btPIM).Click();
            Thread.Sleep(3000);
        }


        // Validações
        public static void ValidarTelaPIM(string username, string password)
        {
            Login(username, password);
            string ValidarTelaPIM = "https://opensource-demo.orangehrmlive.com/web/index.php/pim/viewEmployeeList";
            string ValidarTelaDashboard = Convert.ToString(Driver.Url);
            Assert.AreEqual(ValidarTelaPIM, ValidarTelaDashboard, "Tela PIM exibida com sucesso!");
        }

        public static void ValidarCamposEmployeeInformation(string username, string password)
        {
            Login(username,password);
            
        }
    }
}
