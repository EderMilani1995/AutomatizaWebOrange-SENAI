using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AutomatizaWebOrange.PageObjects;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace AutomatizaWebOrange.Steps
{
    public class PIMSteps : Inicializacao
    {
        public static void ValidarTelaPIM(string username, string password)
        {
            LoginSteps.Login(username, password);
            Driver.FindElement(DashboardPage.btPIM).Click();
            string ValidarTelaPIM = "https://opensource-demo.orangehrmlive.com/web/index.php/pim/viewEmployeeList";
            string ValidarTelaDashboard = Convert.ToString(Driver.Url);
            Assert.AreEqual(ValidarTelaPIM, ValidarTelaDashboard, "Tela PIM exibida com sucesso!");
            Thread.Sleep(3000);
        }

        public static void ValidarCamposEmployeeInformation(string username, string password)
        {
            ValidarTelaPIM(username, password);
            string ValidarCampoEmployeeName = Convert.ToString(Driver.FindElement(PIMPage.campoEmployeeName).Text);
            Assert.AreEqual("Employee Name", ValidarCampoEmployeeName, "Campo Employee Name exibido corretamente");

            string ValidarCampoEmployeeId = Convert.ToString(Driver.FindElement(PIMPage.campoEmployeeId).Text);
            Assert.AreEqual("Employee Id", ValidarCampoEmployeeId, "Campo Employee Id exibido corretamente");

            string ValidarCampoEmploymentStatus = Convert.ToString(Driver.FindElement(PIMPage.campoEmploymentStatus).Text);
            Assert.AreEqual("Employment Status", ValidarCampoEmploymentStatus, "Campo Employment Status exibido corretamente");

            string ValidarCampoInclude = Convert.ToString(Driver.FindElement(PIMPage.campoInclude).Text);
            Assert.AreEqual("Include", ValidarCampoInclude, "Campo Include exibido corretamente");

            string ValidarCampoSupervisorName = Convert.ToString(Driver.FindElement(PIMPage.campoSupervisorName).Text);
            Assert.AreEqual("Supervisor Name", ValidarCampoSupervisorName, "Campo Supervisor Name exibido corretamente");

            string ValidarCampoJobTitle = Convert.ToString(Driver.FindElement(PIMPage.campoJobTitle).Text);
            Assert.AreEqual("Job Title", ValidarCampoJobTitle, "Campo Job Title exibido corretamente");

            string ValidarCampoSubUnit = Convert.ToString(Driver.FindElement(PIMPage.campoSubUnit).Text);
            Assert.AreEqual("Sub Unit", ValidarCampoSubUnit, "Campo Sub Unit exibido corretamente");
        }

        public static void ValidarBtEmployeeInformation(string username, string password, string EmployeeName)
        {
            ValidarTelaPIM(username, password);
            Driver.FindElement(PIMPage.btEmployeeName).SendKeys(EmployeeName);
            string ValidarbtEmployeeName = Convert.ToString(Driver.FindElement(PIMPage.btEmployeeName).Text);
            Assert.AreEqual("Vinnie", ValidarbtEmployeeName, "Campo Employee Name foi preenchido com sucesso");
            Thread.Sleep(3000);
        }
    }
}
