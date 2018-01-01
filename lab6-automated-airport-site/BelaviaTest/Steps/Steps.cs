using OpenQA.Selenium;
using BelaviaTest.Interfaces;
using System.Threading.Tasks;

namespace BelaviaTest.Steps
{
    public class Steps
    {
        private IWebDriver driver;
        private IDriverManager chromeDriver;

        private Pages.MainPage mainPage;

        public Steps()
        {
            chromeDriver = new Managers.ChromeDriverManager();
        }

        public void InitStep()
        {
            driver = chromeDriver.GetDriver();
            mainPage = new Pages.MainPage(driver);
        }

        public void GetTicketOneWay(string originAirport, string destinationAirport)
        {            
            mainPage.OpenPage();
            mainPage.OneWayFlight(originAirport, destinationAirport);            
        }

        public void GetTicketTwoWay(string originAirport, string destinationAirport)
        {            
            mainPage.OpenPage();
            mainPage.TwoWayFlight(originAirport, destinationAirport);
        }
        
        public void ChangeLanguagePage(string lang)
        {            
            mainPage.OpenPage();
            mainPage.ChangeLanguage(lang);
        }

        public void GetTicketTwoWayWithRangePassenger(string originAirport, string destinationAirport,
            params int[] countPassenger)
        {            
            mainPage.OpenPage();
            mainPage.TwoWayFlightWithRangePassenger(originAirport, destinationAirport, countPassenger);
        }

        public void Login(string memberId, string password)
        {            
            mainPage.OpenPage();
            mainPage.Login(memberId, password);
        }

        public void OpenAllOffers()
        {            
            mainPage.OpenPage();
            mainPage.OpenAllOffers();
        }

        public void OpenCarriageOfCargo()
        {            
            mainPage.OpenPage();
            mainPage.OpenCarriageOfCargo();
        }

        public void CheckInFlights(string reservationCode, string lastName)
        {            
            mainPage.OpenPage();
            mainPage.CheckInFlights(reservationCode, lastName);
        }

        public void EndStep()
        {
            chromeDriver.CloseBrowser();
        }

        public bool IsShowPriceMatrix()
        {            
            return mainPage.IsShowPriceMatrix();
        }

        public bool ChecklanguagePage(string lang)
        {            
            return mainPage.CheckLanguagePage(lang);
        }

        public bool IsLoggedIn()
        {            
            return mainPage.IsLoggedIn();
        }

        public bool IsOffersPage()
        {
            return mainPage.IsOffersPage();
        }

        public bool IsCarriagePage()
        {
            return mainPage.IsCarriagePage();
        }

        public bool IsCheckFlightsTrue()
        {
            return mainPage.IsCheckFlightsTrue(20);
        }
    }
}
