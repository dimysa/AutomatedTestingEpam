using System;
using NUnit.Framework;
using BelaviaTest.Steps;
using System.Threading.Tasks;
using System.Threading;

namespace BelaviaTest
{
    [TestFixture]
    public class BelaviaTest
    {
        private Steps.Steps steps;

        private const string MinskAirport = "Minsk (MSQ), BY";
        private const string MoscowAirport = "Moscow (MOW), RU";
        private const string TestAirport = "test";

        [SetUp]
        public void Init()
        {
            steps = new Steps.Steps();
            steps.InitStep();
        }

        [Test]
        public void GetTicketOneWayWithNormalAirports()
        {            
            steps.GetTicketOneWay(MinskAirport, MoscowAirport);
            Assert.IsTrue(steps.IsShowPriceMatrix());
        }

        [Test]
        public void GetTicketOneWayWithFakeAirports()
        {
            steps.GetTicketOneWay(TestAirport, TestAirport);
            Assert.IsFalse(steps.IsShowPriceMatrix());
        }

        [Test]
        public void GetTicketTwoWayWithNormalAirports()
        {
            steps.GetTicketTwoWay(MinskAirport, MoscowAirport);
            Assert.IsTrue(steps.IsShowPriceMatrix());
        }

        [Test]
        public void GetTicketTwoWayWithFakeAirports()
        {
            steps.GetTicketTwoWay(TestAirport, TestAirport);
            Assert.IsFalse(steps.IsShowPriceMatrix());
        }

        [Test]
        public void ChangeLanguagePages()
        {
            steps.ChangeLanguagePage("RU");
            Assert.IsTrue(steps.ChecklanguagePage("Русский"));
        }

        [Test]
        public void GetTicketTwoWayWithRangePassenger()
        {
            steps.GetTicketTwoWayWithRangePassenger(MinskAirport, MoscowAirport, 2, 1, 1);
            Assert.IsTrue(steps.IsShowPriceMatrix());
        }

        [Test]
        public void Login()
        {
            steps.Login("123456", "111111");
            Assert.IsFalse(steps.IsLoggedIn());
        }

        [Test]
        public void OpenAllOffers()
        {
            steps.OpenAllOffers();
            Assert.IsTrue(steps.IsOffersPage());
        }

        [Test]
        public void OpenCarriageOfCargo()
        {
            steps.OpenCarriageOfCargo();
            Assert.IsTrue(steps.IsCarriagePage());
        }

        [Test]
        public void CheckInFlights()
        {
            steps.CheckInFlights("123456", "Ivanov");
            Assert.IsFalse(steps.IsCheckFlightsTrue());

        }
        

        [TearDown]
        public void Cleanup()
        {
            Thread.Sleep(2000);
            steps.EndStep();
        }
    }   
}
