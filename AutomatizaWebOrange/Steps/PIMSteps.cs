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

            string ValidarMenuConfiguration = Convert.ToString(Driver.FindElement(PIMPage.menuConfiguration).Text);
            Assert.AreEqual("Configuration", ValidarMenuConfiguration, "Menu Configuration foi exibido com sucesso");

            string ValidarMenuEmployeeList = Convert.ToString(Driver.FindElement(PIMPage.menuEmployeeList).Text);
            Assert.AreEqual("Employee List", ValidarMenuEmployeeList, "Menu Employee List foi exibido com sucesso");

            string ValidarMenuAddEmployee = Convert.ToString(Driver.FindElement(PIMPage.menuAddEmployee).Text);
            Assert.AreEqual("Add Employee", ValidarMenuAddEmployee, "Menu Add Employee foi exibido com sucesso");

            string ValidarMenuReports = Convert.ToString(Driver.FindElement(PIMPage.menuReports).Text);
            Assert.AreEqual("Reports", ValidarMenuReports, "Menu Reports foi exibido com sucesso");
            Thread.Sleep(3000);
        }

        public static void ValidarTituloEmployeeInformation(string username, string password)
        {
            ValidarTelaPIM(username, password);
            string ValidarCampoEmployeeName = Convert.ToString(Driver.FindElement(PIMPage.tituloEmployeeName).Text);
            Assert.AreEqual("Employee Name", ValidarCampoEmployeeName, "Campo Employee Name exibido corretamente");

            string ValidarCampoEmployeeId = Convert.ToString(Driver.FindElement(PIMPage.tituloEmployeeId).Text);
            Assert.AreEqual("Employee Id", ValidarCampoEmployeeId, "Campo Employee Id exibido corretamente");

            string ValidarCampoEmploymentStatus = Convert.ToString(Driver.FindElement(PIMPage.tituloEmploymentStatus).Text);
            Assert.AreEqual("Employment Status", ValidarCampoEmploymentStatus, "Campo Employment Status exibido corretamente");

            string ValidarCampoInclude = Convert.ToString(Driver.FindElement(PIMPage.tituloInclude).Text);
            Assert.AreEqual("Include", ValidarCampoInclude, "Campo Include exibido corretamente");

            string ValidarCampoSupervisorName = Convert.ToString(Driver.FindElement(PIMPage.tituloSupervisorName).Text);
            Assert.AreEqual("Supervisor Name", ValidarCampoSupervisorName, "Campo Supervisor Name exibido corretamente");

            string ValidarCampoJobTitle = Convert.ToString(Driver.FindElement(PIMPage.tituloJobTitle).Text);
            Assert.AreEqual("Job Title", ValidarCampoJobTitle, "Campo Job Title exibido corretamente");

            string ValidarCampoSubUnit = Convert.ToString(Driver.FindElement(PIMPage.tituloSubUnit).Text);
            Assert.AreEqual("Sub Unit", ValidarCampoSubUnit, "Campo Sub Unit exibido corretamente");

            string ValidarBtReset = Convert.ToString(Driver.FindElement(PIMPage.btReset).Text);
            Assert.AreEqual("Reset", ValidarBtReset, "Campo Reset exibido corretamente");

            string ValidarBtSearch = Convert.ToString(Driver.FindElement(PIMPage.btSearch).Text);
            Assert.AreEqual("Search", ValidarBtSearch, "Campo Search exibido corretamente");

            Thread.Sleep(3000);
        }
    }  
}
