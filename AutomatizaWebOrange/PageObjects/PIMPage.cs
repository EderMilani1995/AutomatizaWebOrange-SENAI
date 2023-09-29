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
        public static By pgPIM = By.XPath("//*[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-module']");

        public static By btPIM = By.XPath("//*[@id=\'app\']/div[1]/div[1]/aside/nav/div[2]/ul/li[2]/a");

        public void ValidaCampos(string xpath, string value)
        {
            Assert.That(Driver.FindElement(By.XPath(xpath)).Text, Does.Contain(value));
        }

        public void camposEmployeeInformation()
        {
            string[] campos =
            {
                "Employee Name",
                "Employee Id",
                "Employment Status",
                "Include",
                "Supervisor Name",
                "Job Title",
                "Sub Unit"
            };
            for (int i = 0; i < campos.Length; i++)
                ValidaCampos("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[" + (i + 1) + "]/div/div[1]/label", campos[i]);
        }

    }

}
