using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomatizaWebOrange.PageObjects
{
    public class DashboardPage
    {
        public static By pgDashboard = By.XPath("//*[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-module']");

        public static By pgPIM = By.XPath("//*[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-module']");

        public static By btPIM = By.XPath("//*[@id=\'app\']/div[1]/div[1]/aside/nav/div[2]/ul/li[2]/a");


    }
}
