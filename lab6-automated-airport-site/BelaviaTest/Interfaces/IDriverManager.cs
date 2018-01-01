using OpenQA.Selenium;

namespace BelaviaTest.Interfaces
{
    interface IDriverManager
    {
        IWebDriver GetDriver();
        void CloseBrowser();
    }
}
