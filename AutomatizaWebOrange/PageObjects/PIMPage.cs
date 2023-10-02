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
        public static By campoEmployeeName = By.XPath("//*[text()= 'Employee Name']");

        public static By campoEmployeeId = By.XPath("//*[text()= 'Employee Id']");

        public static By campoEmploymentStatus = By.XPath("//*[text() = 'Employment Status']");

        public static By campoInclude = By.XPath("//*[text() = 'Include']");

        public static By campoSupervisorName = By.XPath("//*[text() = 'Supervisor Name']");

        public static By campoJobTitle = By.XPath("//*[text()= 'Job Title']");

        public static By campoSubUnit = By.XPath("//*[text()= 'Sub Unit']");

        public static By btEmployeeName = By.XPath("//*[@id=\'app\']/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[1]/div/div[2]/div/div/input");

    }

}
