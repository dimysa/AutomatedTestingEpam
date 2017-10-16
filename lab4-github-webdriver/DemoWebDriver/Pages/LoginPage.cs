using OpenQA.Selenium;

namespace DemoWebDriver.Pages
{
    public class LoginPage
    {
        private const string Username = "testautomationuser";
        private const string Password = "Time4Death!";

        private IWebElement inputLogin;
        private IWebElement inputPassword;
        private IWebElement buttonSubmit;

        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            inputLogin = driver.FindElement(By.Id("login_field"));
            inputPassword = driver.FindElement(By.Id("password"));
            buttonSubmit = driver.FindElement(By.XPath("//input[@value='Sign in']"));
        }

        public void ExecuteLogin()
        {
            inputLogin.SendKeys(Username);
            inputPassword.SendKeys(Password);
            buttonSubmit.Click();
        }
    }
}
