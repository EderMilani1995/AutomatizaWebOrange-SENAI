using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatizaWebOrange.PageObjects;
using AutomatizaWebOrange.Steps;

namespace AutomatizaWebOrange.Feature
{
    [TestClass]
    public class PIM : Inicializacao
    {
        [TestMethod]
        [TestCategory("CT01")]
        public void ValidarExibirTelaPIM()
        {
            PIMSteps.ValidarTelaPIM("Admin", "admin123");
        }

        [TestMethod]
        [TestCategory("CT02")]
        public void ValidarCamposEmployeeInformation()
        {
            PIMSteps.ValidarCamposEmployeeInformation("Admin", "admin123");
        }

        [TestMethod]
        [TestCategory("CT03")]
        public void ValidarbtEmployeeInformation()
        {

            PIMSteps.ValidarBtEmployeeInformation("Admin", "admin123", "Vinnie");
        }
    }
}
