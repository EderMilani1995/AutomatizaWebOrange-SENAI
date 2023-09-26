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


        public static By userNameVazio = By.XPath("//*[@id=\'app\']/div[1]/div/div[1]/div/div[2]/div[2]/form/div[1]/div/span");

        public static By passwordVazio = By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[2]/div/span");
    }
}
