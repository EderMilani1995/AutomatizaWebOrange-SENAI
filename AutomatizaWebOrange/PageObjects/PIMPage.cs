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
        #region MenuConfiguration
        public static By menuConfiguration = By.XPath("//*[@id=\'app\']/div[1]/div[1]/header/div[2]/nav/ul/li[1]/span");

        public static By arrowConfiguration = By.XPath("//*[@class= 'oxd-icon bi-chevron-down']");
        public static By menuOptionalFields = By.XPath("//*[@id=\'app\']/div[1]/div[1]/header/div[2]/nav/ul/li[1]/ul/li[1]/a");
        public static By menuOptinalFields = By.XPath("//*[text() = 'Optional Fields']");

        public static By menuCustomFields = By.XPath("//*[text()= 'Custom Fields']");

        #endregion MenuConfiguration


        #region MenuEmployeeList
        public static By menuEmployeeList = By.XPath("//*[text() = 'Employee List']");

        public static By tituloEmployeeName = By.XPath("//*[text()= 'Employee Name']"); // titulo do campo do nome do funcionario
        public static By campoEmployeeName = By.XPath("//*[@id=\'app\']/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[2]/div/div[2]/input"); // campo para digitar o nome do funcionario.

        public static By tituloEmployeeId = By.XPath("//*[text()= 'Employee Id']");

        public static By tituloEmploymentStatus = By.XPath("//*[text() = 'Employment Status']");

        public static By tituloInclude = By.XPath("//*[text() = 'Include']");

        public static By tituloSupervisorName = By.XPath("//*[text() = 'Supervisor Name']");

        public static By tituloJobTitle = By.XPath("//*[text()= 'Job Title']");

        public static By tituloSubUnit = By.XPath("//*[text()= 'Sub Unit']");

        public static By tituloRecordsFound = By.XPath("//*[text()= '(79) Records Found']");

        public static By btSearch = By.XPath("//*[@class= 'oxd-button oxd-button--medium oxd-button--secondary orangehrm-left-space']");
        #endregion MenuEmployeeList


        #region MenuAddEmployee
        public static By menuAddEmployee = By.XPath("//*[text() = 'Add Employee']");

        #endregion MenuAddEmployee



        #region MenuReports
        public static By menuReports = By.XPath("//*[text() = 'Reports']");

        #endregion MenuReports










        

        

        
    }

}
