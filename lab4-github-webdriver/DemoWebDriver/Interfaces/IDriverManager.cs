using OpenQA.Selenium;

namespace DemoWebDriver.Interfaces
{
    interface IDriverManager
    {
        IWebDriver GetDriver();
        void CloseBrowser();
    }
}
