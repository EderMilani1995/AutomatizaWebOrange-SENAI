using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;

namespace AutomatizaWebOrange
{
    public class Inicializacao
    {

        #region Globals
        
        private static ChromeDriver ChromeDriver;
        public static EventFiringWebDriver Driver;
        #endregion Globals

        #region Atributos
        #region M�todo que ser� executado no �ncio de cada teste
        [TestInitialize]

        public void Inicializar()
        {
            ChromeDriver = new ChromeDriver("Deploy");
            ChromeDriver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
            ChromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);  // Se a pagina ultrapassar 60 segundos de resposta o teste ir� quebrar.
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            ChromeDriver.Manage().Window.Maximize();
            Driver = new EventFiringWebDriver(ChromeDriver);
            
        }
        #endregion M�todo que ser� executado no �ncio de cada teste



        #region M�todo que ser� executado no final de cada teste
        [TestCleanup]
        public void Fechar()
        {
            ChromeDriver.Quit();
            Driver.Quit();
        }
        #endregion #region M�todo que ser� executado no final de cada teste
        #endregion Atributos
    }
}