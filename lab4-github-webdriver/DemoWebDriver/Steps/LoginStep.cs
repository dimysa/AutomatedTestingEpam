using OpenQA.Selenium;
using DemoWebDriver.Interfaces;

namespace DemoWebDriver.Steps
{
    public class LoginStep
    {
        private IWebDriver driver;
        private IDriverManager chromeDriver;

        public LoginStep()
        {
            chromeDriver = new Managers.ChromeDriverManager();
        }

        public void InitStep()
        {
            driver = chromeDriver.GetDriver();
            driver.Url = "http://www.github.com";
        }

        public void EndStep()
        {
            chromeDriver.CloseBrowser();
        }

        public void GoToSignIn()
        {
            var mainPage = new Pages.MainPage(driver);
            mainPage.ClickSignIn();
        }

        public void ExecuteLogin()
        {
            var loginPage = new Pages.LoginPage(driver);
            loginPage.ExecuteLogin();
        }

    }
}
