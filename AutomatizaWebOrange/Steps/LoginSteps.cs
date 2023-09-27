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

        public static void ResetPassword(string username)
        {
            Thread.Sleep(2000);
            Driver.FindElement(LoginPage.resetPassword).Click();
            Driver.FindElement(LoginPage.userNameResetPassword).SendKeys(username);
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

            string LoginSemUsuario = Convert.ToString(Driver.FindElement(LoginPage.userNameVazio).Text);
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

            string LoginSemSenha = Convert.ToString(Driver.FindElement(LoginPage.passwordVazio).Text);
            Assert.AreEqual("Required", LoginSemSenha, "Login não realizado, informe a senha!");
        }

        public static void ValidarResetPassword(string username)
        {
            ResetPassword(username);
            string ValidarResetPassword = Convert.ToString(Driver.FindElement(ResetPasswordSucessPage.pgResetPassword).Text);
            Assert.AreEqual("Reset Password link sent successfully", ValidarResetPassword, "Reset foi realizado com sucesso, acesse seu e-mail para redefinir sua senha!");
        }
    }
}
