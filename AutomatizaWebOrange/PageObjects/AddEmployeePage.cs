using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomatizaWebOrange.PageObjects
{
    public class AddEmployeePage : Inicializacao
    {
        public static By btCancel = By.XPath("//*[text()= ' Cancel ']");
        public static By btSave = By.XPath("//*[text()= ' Save ']");
        public static By requiredMessage = By.XPath("//*[text()= 'Required']");
        public static By firstName = By.XPath("//*[@class= 'oxd-input oxd-input--active orangehrm-firstname']");
        public static By lastName = By.XPath("//*[@class= 'oxd-input oxd-input--active orangehrm-lastname']");
    }
}
