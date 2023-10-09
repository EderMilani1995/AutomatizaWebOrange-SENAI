using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatizaWebOrange.PageObjects;

namespace AutomatizaWebOrange.Steps
{
    public class AddEmployeeSteps : Inicializacao
    {
        public static void ValidarTelaAddEmployee(string username, string password)
        {
            LoginSteps.Login(username, password);
            Driver.FindElement(DashboardPage.btPIM).Click();
            string ValidarTelaAddEmployee = "https://opensource-demo.orangehrmlive.com/web/index.php/pim/addEmployee";
            string ValidarEmployeeList = Convert.ToString(Driver.Url);
            Assert.AreEqual(ValidarTelaAddEmployee, ValidarEmployeeList, "Tela Add Employee exibida com sucesso!");
        }
        public static void ValidarAddEmployeeVazio(string username, string password)
        {
            LoginSteps.Login(username, password);
            Driver.FindElement(DashboardPage.btPIM).Click();
            Driver.FindElement(PIMPage.menuAddEmployee).Click();
            Driver.FindElement(AddEmployeePage.btSave).Click();
            string ValidarAddEmployeeVazio = Convert.ToString(Driver.FindElement(AddEmployeePage.requiredMessage).Text);
            Assert.AreEqual("Required", ValidarAddEmployeeVazio, "Erro ao adicionar cadastro vazio");
            Thread.Sleep(3000);
        }

        public static void ValidarAddEmployeeFirstNameVazio(string username, string password, string lastname)
        {
            LoginSteps.Login(username, password);
            Driver.FindElement(DashboardPage.btPIM).Click();
            Driver.FindElement(PIMPage.menuAddEmployee).Click();
            Driver.FindElement(AddEmployeePage.lastName).SendKeys(lastname);
            Driver.FindElement(AddEmployeePage.btSave).Click();
            string ValidarAddEmployeeFirstNameVazio = Convert.ToString(Driver.FindElement(AddEmployeePage.requiredMessage).Text);
            Assert.AreEqual("Required", ValidarAddEmployeeFirstNameVazio, "Erro ao adicionar cadastro vazio");
            Thread.Sleep(3000);
        }

        public static void ValidarAddEmployeeLastNameVazio(string username, string password, string firstname)
        {
            LoginSteps.Login(username, password);
            Driver.FindElement(DashboardPage.btPIM).Click();
            Driver.FindElement(PIMPage.menuAddEmployee).Click();
            Driver.FindElement(AddEmployeePage.firstName).SendKeys(firstname);
            Driver.FindElement(AddEmployeePage.btSave).Click();
            string ValidarAddEmployeeLastNameVazio = Convert.ToString(Driver.FindElement(AddEmployeePage.requiredMessage).Text);
            Assert.AreEqual("Required", ValidarAddEmployeeLastNameVazio, "Erro ao adicionar cadastro vazio");
            Thread.Sleep(3000);
        }

        //public static void ValidarBtHelp(string username, string password)
        //{
        //    LoginSteps.Login(username, password);
        //    Driver.FindElement(DashboardPage.btPIM).Click();
        //    Driver.FindElement(PIMPage.btHelp).Click();
        //    string ValidarBtHelp = "https://starterhelp.orangehrm.com/hc/en-us/articles/360018657779-How-to-Filter-the-Employee-List";
        //    string ValidarTelaPIM = Convert.ToString(Driver.Url);
        //    Assert.AreEqual(ValidarBtHelp, ValidarTelaPIM, "Tela Help exibida com sucesso");
        //    Thread.Sleep(3000);

        //}
    }
}

