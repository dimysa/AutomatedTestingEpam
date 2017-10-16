using NUnit.Framework;
using DemoWebDriver.Steps;


namespace DemoWebDriver
{
    [TestFixture]
    public class DemoWebDriver
    {
        LoginStep loginStep;

        [SetUp]
        public void Init()
        {
            loginStep = new LoginStep();
            loginStep.InitStep();
        }

        [Test]
        public void RunWebDriver()
        {
            loginStep.GoToSignIn();
            loginStep.ExecuteLogin();
        }

        [TearDown]
        public void Cleanup()
        {
            loginStep.EndStep();
        }
    }   
}
