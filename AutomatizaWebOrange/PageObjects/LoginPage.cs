using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatizaWebOrange.Feature;
using OpenQA.Selenium;

namespace AutomatizaWebOrange.PageObjects
{
    public class LoginPage
    {
        
        public static By username = By.XPath("//*[@name='username']");
        
        public static By password = By.XPath("//*[@name='password']");
        
        public static By login = By.XPath("//*[(text()= ' Login ' )]");

        public static By userNamePasswordInvalido = By.XPath("//*[(text()= 'Invalid credentials')]");

        public static By userNamePasswordVazio = By.XPath("//*[(text()='Required')]"); // Required dos campos Username e Password

        public static By linkResetPassword = By.XPath("//*[(text()= 'Forgot your password? ')]"); // Link para redefinir password

        public static By pgResetPassword = By.XPath("//*[@class='oxd-text oxd-text--h6 orangehrm-forgot-password-title']"); // Título da página Reset Password

        public static By userNameResetPassword = By.XPath("//input[@class=\'oxd-input oxd-input--active\']");   // Campo Username para redefinir senha

        public static By botaoResetPassword = By.XPath("//*[@class='oxd-button oxd-button--large oxd-button--secondary orangehrm-forgot-password-button orangehrm-forgot-password-button--reset']");    // Botão para realizar o reset do password

        public static By pgResetPasswordSucesso = By.XPath("//*[@class='oxd-text oxd-text--h6 orangehrm-forgot-password-title']"); // Título da página com o envio do link realizado com sucesso

        public static By userNameResetVazio = By.XPath("//*[@class='oxd-text oxd-text--span oxd-input-field-error-message oxd-input-group__message']");    // Required do campo Username na tela de Reset Password

        public static By botaoCancelarResetPassword = By.XPath("//*[@class='oxd-button oxd-button--large oxd-button--ghost orangehrm-forgot-password-button orangehrm-forgot-password-button--cancel']");    // Botão para realizar o cancelamento do reset Password

        public static By tituloLoginTelaPrincipal = By.XPath("//*[@class='oxd-text oxd-text--h5 orangehrm-login-title']");
    }
}
