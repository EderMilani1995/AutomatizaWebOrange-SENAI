using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatizaWebOrange.PageObjects;

namespace AutomatizaWebOrange.Steps
{
    public class LoginSteps : Inicializacao
    {
        public static void Login(string username, string password)  // Teste para realizar o login com sucesso
        {
            Driver.FindElement(LoginPage.username).SendKeys(username);
            Driver.FindElement(LoginPage.password).SendKeys(password);
            Driver.FindElement(LoginPage.login).Click();
        }

        public static void ResetPasswordCancelarResetPassword(string username)
        {
            
            Driver.FindElement(LoginPage.linkResetPassword).Click();
            Driver.FindElement(LoginPage.userNameResetPassword).SendKeys(username);
            Driver.FindElement(LoginPage.botaoResetPassword).Click();
        }

        public static void CancelarResetPasswordPreenchido(string username)
        {
            Driver.FindElement(LoginPage.linkResetPassword).Click();
            Thread.Sleep(3000);
            Driver.FindElement(LoginPage.userNameResetPassword).SendKeys(username);
            Driver.FindElement(LoginPage.botaoCancelarResetPassword).Click();
            Thread.Sleep(3000);
        }
        public static void CancelarResetPasswordVazio()
        {
            Driver.FindElement(LoginPage.linkResetPassword).Click();
            Thread.Sleep(3000);
            Driver.FindElement(LoginPage.botaoCancelarResetPassword).Click();
            Thread.Sleep(3000);
        }


        // Validações:

        public static void ValidarLoginComSucesso(string username, string password)
        {
            Login(username, password);

            string LoginSucesso = Convert.ToString(Driver.FindElement(DashboardPage.pgDashboard).Text);
            Assert.AreEqual("Dashboard", LoginSucesso, "Login foi realizado com sucesso");
        }

        public static void ValidarLoginUsuarioInvalido(string username, string password)
        {
            Login(username, password);

            string LoginUsuarioInvalido = Convert.ToString(Driver.FindElement(LoginPage.userNamePasswordInvalido).Text);
            Assert.AreEqual("Invalid credentials", LoginUsuarioInvalido, "Login não realizado, informe o usuário correto!");
        }

        public static void ValidarLoginSemUsuario(string username, string password)
        {
            Login(username, password);

            string LoginSemUsuario = Convert.ToString(Driver.FindElement(LoginPage.userNamePasswordVazio).Text);
            Assert.AreEqual("Required", LoginSemUsuario, "Login não realizado, informe o usuário!");
        }

        public static void ValidarLoginSenhaInvalida(string username, string password)
        {
            Login(username, password);

            string LoginSenhaInvalida = Convert.ToString(Driver.FindElement(LoginPage.userNamePasswordInvalido).Text);
            Assert.AreEqual("Invalid credentials", LoginSenhaInvalida, "Login não realizado, informe a senha correta!");
        }

        public static void ValidarLoginSemSenha(string username, string password)
        {
            Login(username, password);

            string LoginSemSenha = Convert.ToString(Driver.FindElement(LoginPage.userNamePasswordVazio).Text);
            Assert.AreEqual("Required", LoginSemSenha, "Login não realizado, informe a senha!");
        }

        public static void ValidarExibirTelaResetPassword(string username)
        {
            ResetPasswordCancelarResetPassword(username);
            string ValidarExibirTelaResetPassword = Convert.ToString(Driver.FindElement(LoginPage.pgResetPassword).Text);
            Assert.AreEqual("Reset Password", ValidarExibirTelaResetPassword, "A tela foi apresentada com sucesso!");
        }

        public static void ValidarResetPasswordComSucesso(string username)
        {
            CancelarResetPasswordPreenchido(username);
            string ValidarResetPasswordComSucesso = Convert.ToString(Driver.FindElement(LoginPage.pgResetPasswordSucesso).Text);
            Assert.AreEqual("Reset Password link sent successfully", ValidarResetPasswordComSucesso, "Link enviado com sucesso! Verificar o seu e-mail para realizar o reset!");

        }

        public static void ValidarResetPasswordSemUsuario(string username)
        {
            ResetPasswordCancelarResetPassword(username);
            string ValidarResetPasswordSemUsuario = Convert.ToString(Driver.FindElement(LoginPage.userNameResetVazio).Text);
            Assert.AreEqual("Required", ValidarResetPasswordSemUsuario, "Envio do link não realizado, informe o usuário!");
        }

        public static void ValidarCancelarResetPasswordPreenchido(string username)
        {
            CancelarResetPasswordPreenchido(username);
            string ValidarCancelarResetPassword = Convert.ToString(Driver.FindElement(LoginPage.tituloLoginTelaPrincipal).Text);
            Assert.AreEqual("Login", ValidarCancelarResetPassword, "Cancelamento de reset de password realizado com sucesso!");
        }
        public static void ValidarCancelarResetPasswordVazio()
        {
            CancelarResetPasswordVazio();
            string ValidarCancelarResetPassword = Convert.ToString(Driver.FindElement(LoginPage.tituloLoginTelaPrincipal).Text);
            Assert.AreEqual("Login", ValidarCancelarResetPassword, "Cancelamento de reset de password realizado com sucesso!");
        }

    }
}
