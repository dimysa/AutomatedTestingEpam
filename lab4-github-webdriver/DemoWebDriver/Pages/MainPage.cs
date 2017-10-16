using OpenQA.Selenium;

namespace DemoWebDriver.Pages
{
    public class MainPage
    {
        private IWebDriver driver;
        private IWebElement signInButton;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            signInButton = driver.FindElement(By.XPath("//a[@href='/login']"));
        }

        public void ClickSignIn()
        {
            signInButton.Click();
        }
    }
}
