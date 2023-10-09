using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using AutomatizaWebOrange.Steps;
using static System.Console;

namespace AutomatizaWebOrange.Feature
{
    [TestClass]
    public class AddEmployee : Inicializacao
    {
        //[TestMethod]
        //public void ValidarTelaAddEmployee()
        //{
        //    AddEmployeeSteps.ValidarTelaAddEmployee("Admin", "admin123");
        //}

        [TestMethod]
        [TestCategory("CT03")]
        public void ValidarAddEmployeeVazio()
        {
            WriteLine("QUANDO: ACESSAR O LINK 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: PREENCHER OS CAMPOS @USERNAME E @PASSWORD COM USUÁRIO CADASTRADO"); 
            WriteLine("QUANDO: CLICAR NO BOTÃO[LOGIN]"); 
            WriteLine("ENTÃO: O LOGIN DEVE SER REALIZADO COM SUCESSO"); 
            WriteLine("E: CLICAR NO MENU PIM"); 
            WriteLine("E: CLICAR NO BOTÃO[ADD EMPLOYEE]"); 
            WriteLine("ENTÃO: SERÁ EXIBIDA A TELA 'ADD EMPLOYEE'"); 
            WriteLine("E: NÃO PREENCHER OS CAMPOS @FIRSTNAME, @MIDDLENAME E @LASTNAME");
            WriteLine("QUANDO: CLICAR NO BOTÃO[SAVE]");
            WriteLine("ENTÃO: OS CAMPOS 'FIRSTNAME' E 'LASTNAME' FICARÃO EM DESTAQUE NA COR VERMELHA E APRESENTARÃO O ALERTA 'REQUIRED'"); 

            AddEmployeeSteps.ValidarAddEmployeeVazio("Admin", "admin123");
        }

        [TestMethod]
        [TestCategory("CT04")]
        public void ValidarAddEmployeeFirstNameVazio()
        {
            WriteLine("QUANDO: ACESSAR O LINK 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'"); 
            WriteLine("E: PREENCHER OS CAMPOS @USERNAME E @PASSWORD COM USUÁRIO CADASTRADO"); 
            WriteLine("QUANDO: CLICAR NO BOTÃO[LOGIN]"); 
            WriteLine("ENTÃO: O LOGIN DEVE SER REALIZADO COM SUCESSO"); 
            WriteLine("E: CLICAR NO MENU PIM"); 
            WriteLine("E: CLICAR NO BOTÃO[ADD EMPLOYEE]"); 
            WriteLine("ENTÃO: SERÁ EXIBIDA A TELA 'ADD EMPLOYEE'"); 
            WriteLine("E: NÃO PREENCHER O CAMPO @FIRSTNAME"); 
            WriteLine("E: PREENCHER O CAMPO @LASTNAME COM NOME VÁLIDO"); 
            WriteLine("QUANDO: CLICAR NO BOTÃO[SAVE]"); 
            WriteLine("ENTÃO: O CAMPO 'FIRSTNAME' FICARÁ EM DESTAQUE NA COR VERMELHA E APRESENTARÁ O ALERTA 'REQUIRED'"); 

            AddEmployeeSteps.ValidarAddEmployeeFirstNameVazio("Admin", "admin123", "Silva");
        }

        [TestMethod]
        [TestCategory("CT05")]
        public void ValidarAddEmployeeLastNameVazio()
        {
            WriteLine("QUANDO: ACESSAR O LINK 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'"); 
            WriteLine("E: PREENCHER OS CAMPOS @USERNAME E @PASSWORD COM USUÁRIO CADASTRADO"); 
            WriteLine("QUANDO: CLICAR NO BOTÃO[LOGIN]"); 
            WriteLine("ENTÃO: O LOGIN DEVE SER REALIZADO COM SUCESSO"); 
            WriteLine("E: CLICAR NO MENU PIM"); 
            WriteLine("E: CLICAR NO BOTÃO[ADD EMPLOYEE]"); 
            WriteLine("ENTÃO: SERÁ EXIBIDA A TELA 'ADD EMPLOYEE'"); 
            WriteLine("E: PREENCHER O CAMPO @FIRSTNAME COM NOME VÁLIDO"); 
            WriteLine("E: NÃO PREENCHER O CAMPO @LASTNAME"); 
            WriteLine("QUANDO: CLICAR NO BOTÃO[SAVE]"); 
            WriteLine("ENTÃO: O CAMPO 'FIRSTNAME' FICARÁ EM DESTAQUE NA COR VERMELHA E APRESENTARÁ O ALERTA 'REQUIRED'"); 

            AddEmployeeSteps.ValidarAddEmployeeLastNameVazio("Admin", "admin123", "Cristiano");
        }

        //[TestMethod]
        //[TestCategory("CT06")]
        //public void ValidarBtHelp()
        //{
        //    PIMSteps.ValidarBtHelp("Admin", "admin123");
        //}
    }
}
