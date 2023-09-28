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
    }
}
