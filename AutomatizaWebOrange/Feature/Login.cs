using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using AutomatizaWebOrange.PageObjects;
using AutomatizaWebOrange.Steps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using static System.Console;

namespace AutomatizaWebOrange.Feature
{

    [TestClass] // Visual irá entender que é uma classe de teste
    public class Login : Inicializacao
    {
        [TestMethod] // Identificador que é um metodo de teste
        [TestCategory("CT01")]
        public void ValidarLoginComSucesso()
        {
            LoginSteps.ValidarLoginComSucesso("Admin", "admin123");
        }

        [TestMethod]
        [TestCategory("CT02")]
        public void ValidarLoginUsuarioInvalido()
        {
            LoginSteps.ValidarLoginUsuarioInvalido("Administrador", "admin123");
        }

        [TestMethod]
        [TestCategory("CT03")]
        public void ValidarLoginSemUsuario()
        {
           LoginSteps.ValidarLoginSemUsuario("", "admin123");
        }

        [TestMethod]
        [TestCategory("CT04")]
        public void ValidarLoginSenhaInvalida()
        {
            LoginSteps.ValidarLoginSenhaInvalida("Admin", "1234");
        }
    }
}
