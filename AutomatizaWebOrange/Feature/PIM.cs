using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatizaWebOrange.PageObjects;
using AutomatizaWebOrange.Steps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Console;

namespace AutomatizaWebOrange.Feature
{
    [TestClass]
    public class PIM : Inicializacao
    {
        [TestMethod]
        [TestCategory("CT01")]
        public void ValidarExibirTelaPIM()
        {
            WriteLine("VALIDAR EXIBIÇÃO DO MENU PIM NA TELA PIM");
            WriteLine("QUANDO: ACESSAR O LINK 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'"); 
            WriteLine("E: PREENCHER OS CAMPOS @USERNAME E @PASSWORD COM USUÁRIO CADASTRADO"); 
            WriteLine("QUANDO: CLICAR NO BOTÃO[LOGIN]"); 
            WriteLine("ENTÃO: O LOGIN DEVE SER REALIZADO COM SUCESSO"); 
            WriteLine("E: CLICAR NO MENU PIM"); 
            WriteLine("ENTÃO: EXIBIRÁ A TELA COM OS BOTÕES [Configuration] [Employee List] [Add Employee] [Reports]."); 

            PIMSteps.ValidarTelaPIM("Admin", "admin123");
        }

        [TestMethod]
        [TestCategory("CT02")]
        public void ValidarTituloEmployeeInformation()
        {
            WriteLine("QUANDO: ACESSAR O LINK 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'"); 
            WriteLine("E: PREENCHER OS CAMPOS @USERNAME E @PASSWORD COM USUÁRIO CADASTRADO"); 
            WriteLine(" QUANDO: CLICAR NO BOTÃO[LOGIN]");
            WriteLine("ENTÃO: O LOGIN DEVE SER REALIZADO COM SUCESSO"); 
            WriteLine("E: CLICAR NO MENU PIM"); 
            WriteLine("ENTÃO: EXIBIRÁ A TELA COM OS CAMPOS @EMPLOYEENAME, @EMPLOYEEID, @SUPERVISORNAME, [EMPLOYEE STATUS], [JOB TITLE], [SUB UNIT], [INCLUDE] E A GRID 'RECORDS FOUND' COM TODOS OS EMPREGADOS CADASTRADOS NO SISTEMA."); 

            PIMSteps.ValidarTituloEmployeeInformation("Admin", "admin123");
        }

        [TestMethod]
        [TestCategory("CT03")]
        public void ValidarAddEmployeeVazio()
        {
            PIMSteps.ValidarAddEmployeeVazio("Admin", "admin123");
        }

        [TestMethod]
        [TestCategory("CT04")]
        public void ValidarAddEmployeeFirstNameVazio()
        {
            PIMSteps.ValidarAddEmployeeFirstNameVazio("Admin", "admin123", "Silva");
        }

        [TestMethod]
        [TestCategory("CT05")]
        public void ValidarAddEmployeeLastNameVazio()
        {
            PIMSteps.ValidarAddEmployeeLastNameVazio("Admin", "admin123", "Cristiano");
        }

        //[TestMethod]
        //[TestCategory("CT06")]
        //public void ValidarBtHelp()
        //{
        //    PIMSteps.ValidarBtHelp("Admin", "admin123");
        //}
    }
}
