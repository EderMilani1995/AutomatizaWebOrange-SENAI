using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatizaWebOrange.Steps;

namespace AutomatizaWebOrange.Feature
{
    public class AddEmployee
    {
        [TestMethod]

        public void ValidarTelaAddEmployee()
        {
            AddEmployeeSteps.ValidarTelaAddEmployee("Admin", "admin123");
        }

        [TestMethod]
        [TestCategory("CT03")]
        public void ValidarAddEmployeeVazio()
        {
            AddEmployeeSteps.ValidarAddEmployeeVazio("Admin", "admin123");
        }

        [TestMethod]
        [TestCategory("CT04")]
        public void ValidarAddEmployeeFirstNameVazio()
        {
            AddEmployeeSteps.ValidarAddEmployeeFirstNameVazio("Admin", "admin123", "Silva");
        }

        [TestMethod]
        [TestCategory("CT05")]
        public void ValidarAddEmployeeLastNameVazio()
        {
            AddEmployeeSteps.ValidarAddEmployeeLastNameVazio("Admin", "admin123", "Cristiano");
        }

        //[TestMethod]
        //[TestCategory("CT06")]
        //public void ValidarBtHelp()
        //{
        //    PIMSteps.ValidarBtHelp("Admin", "admin123");
        //}
    }
}
