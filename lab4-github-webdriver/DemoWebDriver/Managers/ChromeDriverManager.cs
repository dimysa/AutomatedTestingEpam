using System;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Diagnostics;

namespace DemoWebDriver.Managers
{
    public class ChromeDriverManager: Interfaces.IDriverManager
    {
        private static IWebDriver driver;

        private static readonly string DriverPath = AppContext.BaseDirectory.Replace(@"bin\Debug", "Resource");
        private const string ChromeDriver = "chromedriver";

        public IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver(DriverPath);
            }
            return driver;
        }

        public void CloseBrowser()
        {
            driver.Quit();
            driver = null;

            foreach (var process in Process.GetProcessesByName(ChromeDriver))
            {
                process.Kill();
            }
        }
    }
}
