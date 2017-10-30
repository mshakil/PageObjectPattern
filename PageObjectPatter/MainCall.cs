using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using AutomationLibrary.Utilities;
using System.Configuration;

namespace PageObjectPattern
{
    [TestFixture]
    public class MainCall
    {
        private string ChromeDriverDirectory { get { return ConfigurationManager.AppSettings["DriverPath"]; } }
        protected IWebDriver Driver { get; private set; }

        [SetUp]
        public void InitializeDriverForEveryTest()
        {
            switch (CSettings.BrowserType)
            {
                case "CR":
                    {
                        Driver = new ChromeDriver(ChromeDriverDirectory);
                        Driver.Manage().Window.Maximize();
                    }
                    break;
                default:
                    {
                        Driver = new FirefoxDriver();
                        Driver.Manage().Window.Maximize();
                    }
                    break;
            }
        }

        [TearDown]
        public void TearDownForEveryTestCase()
        {
            if (Driver == null)
                return;
            Driver.Quit();
        }
    }
}
