using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using Assert = NUnit.Framework.Assert;

namespace AutomatizaWebOrange.PageObjects
{
    public class PIMPage : Inicializacao
    {
        public static By menuConfiguration = By.XPath("//*[@id=\'app\']/div[1]/div[1]/header/div[2]/nav/ul/li[1]/span");

        #region MenuEmployeeList
        public static By menuEmployeeList = By.XPath("//*[text() = 'Employee List']");

        public static By tituloEmployeeName = By.XPath("//*[text()= 'Employee Name']"); // titulo do campo do nome do funcionario.

        public static By tituloEmployeeId = By.XPath("//*[text()= 'Employee Id']");

        public static By tituloEmploymentStatus = By.XPath("//*[text() = 'Employment Status']");

        public static By tituloInclude = By.XPath("//*[text() = 'Include']");

        public static By tituloSupervisorName = By.XPath("//*[text() = 'Supervisor Name']");

        public static By tituloJobTitle = By.XPath("//*[text()= 'Job Title']");

        public static By tituloSubUnit = By.XPath("//*[text()= 'Sub Unit']");

        public static By btReset = By.XPath("//*[text()= ' Reset ']");

        public static By btSearch = By.XPath("//*[@class= 'oxd-button oxd-button--medium oxd-button--secondary orangehrm-left-space']");
        #endregion MenuEmployeeList

        public static By menuAddEmployee = By.XPath("//*[text()= 'Add Employee']");

        public static By menuReports = By.XPath("//*[text() = 'Reports']");

        public static By btHelp = By.XPath("/html/body/div[1]/div[1]/div[1]/header/div[2]/nav/ul/div/button");








        

        

        
    }

}
