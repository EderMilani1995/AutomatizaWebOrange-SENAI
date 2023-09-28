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
            WriteLine("QUANDO: ACESSAR O LINK 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: PREENCHER OS CAMPOS @USERNAME E @PASSWORD COM USUÁRIO CADASTRADO");
            WriteLine("QUANDO: CLICAR NO BOTÃO [LOGIN]");
            WriteLine("ENTÃO: O LOGIN DEVE SER REALIZADO COM SUCESSO");

            LoginSteps.ValidarLoginComSucesso("Admin", "admin123");
        }

        [TestMethod]
        [TestCategory("CT02")]
        public void ValidarLoginUsuarioInvalido()
        {
            WriteLine("QUANDO: ACESSAR O LINK 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: PREENCHER O CAMPO @USERNAME COM USUÁRIO NÃO CADASTRADO PREVIAMENTE E PREENCHER O CAMPO @PASSWORD COM SENHA VÁLIDA");
            WriteLine("QUANDO: CLICAR NO BOTÃO [LOGIN]");
            WriteLine("ENTÃO: O SISTEMA APRESENTARÁ A MENSAGEM 'INVÁLID CREDENTIALS' E O ACESSO NÃO SERÁ PERMITIDO");

            LoginSteps.ValidarLoginUsuarioInvalido("Administrador", "admin123");
        }

        [TestMethod]
        [TestCategory("CT03")]
        public void ValidarLoginSemUsuario()
        {
            WriteLine("QUANDO: ACESSAR O LINK 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: NÃO PREENCHER O CAMPO @USERNAME E PREENCHER O CAMPO @PASSWORD COM VALOR VÁLIDO");
            WriteLine("QUANDO: CLICAR NO BOTÃO [LOGIN]");
            WriteLine("ENTÃO: O CAMPO 'USERNAME' FICARÁ EM DESTAQUE NA COR VERMELHA E APRESENTARÁ O ALERTA 'REQUIRED'");

            LoginSteps.ValidarLoginSemUsuario("", "admin123");
        }

        [TestMethod]
        [TestCategory("CT4")]
        public void ValidarLoginSenhaInvalida()
        {
            WriteLine("QUANDO: ACESSAR O LINK 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: PREENCHER O CAMPO @USERNAME COM VALOR VÁLIDO E PREENCHER O CAMPO @PASSWORD COM SENHA NÃO CADASTRADA");
            WriteLine("QUANDO: CLICAR NO BOTÃO [LOGIN]");
            WriteLine("ENTÃO: O CAMPO 'PASSWORD' FICARÁ EM DESTAQUE NA COR VERMELHA E APRESENTARÁ O ALERTA 'REQUIRED'");

            LoginSteps.ValidarLoginSenhaInvalida("Admin", "1234");
        }

        [TestMethod]
        [TestCategory("CT05")]
        public void ValidarLoginSemSenha()
        {
            WriteLine("QUANDO: ACESSAR O LINK 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: PREENCHER O CAMPO @USERNAME COM VALOR VÁLIDO E NÃO PREENCHER O CAMPO @PASSWORD");
            WriteLine("QUANDO: CLICAR NO BOTÃO [LOGIN]");
            WriteLine("ENTÃO: O CAMPO 'PASSWORD' FICARÁ EM DESTAQUE NA COR VERMELHA E APRESENTARÁ O ALERTA 'REQUIRED'");

            LoginSteps.ValidarLoginSemSenha("Admin", "");
        }

        [TestMethod]
        [TestCategory("CT06")]
        public void ValidarExibirResetPassword()
        {
            WriteLine("DADO QUE: AO ACESSAR O LINK 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: PREENCHER O CAMPO @USERNAME COM USUÁRIO CADSATRADO PREVIAMENTE");
            WriteLine("E: NÃO SABER O CAMPO @PASSWORD PREEVIAMENTE CADASTRADO");
            WriteLine("QUANDO: CLICAR NO BOTÃO [FORGOT YOUR PASSWORD?]"); 
            WriteLine("ENTÃO: EXIBIRÁ A TELA 'RESET PASSWORD'");

            LoginSteps.ValidarExibirTelaResetPassword("");
        }

        [TestMethod]
        [TestCategory("CT07")]
        public void ValidarResetPasswordComSucesso()
        {
            WriteLine("DADO QUE: AO ACESSAR O LINK 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("QUANDO: CLICAR NA OPÇÃO 'FORGOT YOUR PASSWORD?'");
            WriteLine("ENTÃO: EXIBIRÁ A TELA 'RESET PASSWORD'");
            WriteLine("E: PREENCHER O CAMPO @USERNAME COM USUÁRIO CADASTRADO PARA IDENTIFICAR A CONTA");
            WriteLine("QUANDO: CLICAR NO BOTÃO [RESET PASSWORD]");
            WriteLine("ENTÃO: EXIBIRÁ A TELA COM A MENSAGEM 'Reset Password link sent successfully'");

            LoginSteps.ValidarResetPasswordComSucesso("Admin");
        }

        [TestMethod]
        [TestCategory("CT08")]
        public void ValidarResetPasswordSemUsuario()
        {
            WriteLine("DADO QUE: AO ACESSAR O LINK 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("QUANDO: CLICAR NA OPÇÃO 'FORGOT YOUR PASSWORD?'");
            WriteLine("ENTÃO: EXIBIRÁ A TELA 'RESET PASSWORD'");
            WriteLine("E: NÃO PREENCHER O CAMPO @USERNAME");
            WriteLine("QUANDO: CLICAR NO BOTÃO [RESET PASSWORD]");
            WriteLine("ENTÃO: O CAMPO 'USERNAME' FICARÁ EM DESTAQUE NA COR VERMELHA E APRESENTARÁ O ALERTA 'REQUIRED'");

            LoginSteps.ValidarResetPasswordSemUsuario("");
        }

        [TestMethod]
        [TestCategory("CT09")]
        public void ValidarCancelarResetPasswordPreenchido()
        {
            WriteLine("DADO QUE: AO ACESSAR O LINK 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("QUANDO: CLICAR NA OPÇÃO 'FORGOT YOUR PASSWORD?'");
            WriteLine("ENTÃO: EXIBIRÁ A TELA 'RESET PASSWORD'");
            WriteLine("E: PREENCHER O CAMPO @USERNAME COM USUÁRIO CADASTRADO PARA IDENTIFICAR A CONTA");
            WriteLine("QUANDO: CLICAR NO BOTÃO [CANCEL]");
            WriteLine("");

            LoginSteps.ValidarCancelarResetPasswordPreenchido("Admin");
        }

        [TestMethod]
        [TestCategory("CT10")]
        public void ValidarCancelarResetPasswordVazio()
        {
            WriteLine("DADO QUE: AO ACESSAR O LINK 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("QUANDO: CLICAR NA OPÇÃO 'FORGOT YOUR PASSWORD?'");
            WriteLine("ENTÃO: EXIBIRÁ A TELA 'RESET PASSWORD'");
            WriteLine("E: NÃO PREENCHER O CAMPO @USERNAME");
            WriteLine("QUANDO: CLICAR NO BOTÃO [CANCEL]");
            WriteLine("ENTÃO: EXIBIRÁ A TELA PRINCIPAL 'LOGIN' DO SITE");

            LoginSteps.ValidarCancelarResetPasswordVazio();
        }

    }
}
