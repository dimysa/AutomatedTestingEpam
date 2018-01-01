using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace BelaviaTest.Pages
{
    public class MainPage
    {
        private const string BaseUrl = "https://en.belavia.by/";
        private const string DateXPath = "//td[@data-month='{0}'][@data-year='{1}']/a[text()='{2}']";
        private const string LangXPath = "//div[@id='lang-menu']/*/*/*/a[@data-iso='{0}']";

        private const string OffersPageClassName = "offers";
        private const string CarriagePageHeaderXPath = "//div[@class='article content']//h1";
        private const string CheckFlightsModalErrorXPath = "//div[@class='modal do-not-close-on-click-outside loading']";
        private const string CarriagePageHeader = "Carriage of cargo";

        private readonly IWebDriver driver;

        [FindsBy(How = How.Id, Using = "OriginLocation_Combobox")]
        private IWebElement inputOriginAirport;

        [FindsBy(How = How.Id, Using = "DestinationLocation_Combobox")]
        private IWebElement inputDestinationAirport;

        [FindsBy(How = How.XPath, Using = "//label[@for='JourneySpan_Ow']")]
        private IWebElement oneWayRadioButton;

        [FindsBy(How = How.XPath, Using = "//label[@for='JourneySpan_Rt']")]
        private IWebElement returnRadioButton;

        [FindsBy(How = How.XPath, Using = "//input[@id='DepartureDate_Datepicker']/../a")]
        private IWebElement inputDepartureDate;

        [FindsBy(How = How.XPath, Using = "//input[@id='ReturnDate_Datepicker']/../a")]
        private IWebElement inputReturnDate;

        [FindsBy(How = How.XPath, Using = "//button[@class='button btn-large btn btn-b2-green ui-corner-all']")]
        private IWebElement buttonSearchFlights;

        [FindsBy(How = How.Id, Using = "select-lang")]
        private IWebElement menuLanguage;

        [FindsBy(How = How.Id, Using = "ui-id-1")]
        private IWebElement passengersUI;

        [FindsBy(How = How.XPath, Using = "//input[@id='Adults']/../a[@class='spin-plus']")]
        private IWebElement passengersAdultsPlus;

        [FindsBy(How = How.XPath, Using = "//input[@id='Children']/../a[@class='spin-plus']")]
        private IWebElement passengersChildrenPlus;

        [FindsBy(How = How.XPath, Using = "//input[@id='Infants']/../a[@class='spin-plus']")]
        private IWebElement passengersInfantsPlus;

        [FindsBy(How = How.Id, Using = "select-member")]
        private IWebElement loginUI;

        [FindsBy(How = How.Id, Using = "MemberId")]
        private IWebElement inputMemberId;

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement inputPassword;

        [FindsBy(How = How.XPath, Using = "//button[@class='button btn btn-b2-login ui-corner-all']")]
        private IWebElement buttonLogin;

        [FindsBy(How = How.XPath, Using = "//div[@class='content']//div[@class='offers clear']/a")]
        private IWebElement offersLink;

        [FindsBy(How = How.Id, Using = "select-main-menu")]
        private IWebElement openMenuLink;

        [FindsBy(How = How.XPath, Using = "//li[@class='category info']//li[@class='category'][4]/a")]
        private IWebElement cargoCarriageLink;

        [FindsBy(How = How.XPath, Using = "//li[@class='category info']//li[@class='category'][4]/ul/li[1]/a")]
        private IWebElement carriageOfCargoLink;

        [FindsBy(How = How.XPath, Using = "//ul[@class='nav-tabs']//a[@href='#wci']")]
        private IWebElement checkInTab;

        [FindsBy(How = How.Id, Using = "wciPnr")]
        private IWebElement inputReservationCode;

        [FindsBy(How = How.Id, Using = "wciLastName")]
        private IWebElement inputLastName;

        [FindsBy(How = How.XPath, Using = "//label[@for='wciRules']")]
        private IWebElement checkBoxForRulesCheckIn;

        [FindsBy(How = How.Id, Using = "wciButton")]
        private IWebElement buttonSearchCheckIn;

        [FindsBy(How = How.Id, Using = "lang-title")]
        private IWebElement spanLanguagePage;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        public void OneWayFlight(string originAirport, string destinationAirport)
        {
            EnterAirportInfo(originAirport, destinationAirport);
            oneWayRadioButton.Click();

            var date = DateTime.Now;
            inputDepartureDate.Click();
            SelectDate(date.AddDays(7));

            buttonSearchFlights.Click();
        }

        public void TwoWayFlight(string originAirport, string destinationAirport)
        {
            EnterAirportInfo(originAirport, destinationAirport);
            returnRadioButton.Click();

            var date = DateTime.Now;
            inputDepartureDate.Click();
            SelectDate(date.AddDays(7));
            //inputReturnDate.Click();
            SelectDate(date.AddDays(14));
            buttonSearchFlights.Click();
        }

        public void ChangeLanguage(string lang)
        {
            menuLanguage.Click();
            var selectedLanguage = driver.FindElement(By.XPath(string.Format(LangXPath, lang)));
            selectedLanguage.Click();
        }

        public void TwoWayFlightWithRangePassenger(string originAirport, string destinationAirport, params int[] countPassenger)
        {
            EnterAirportInfo(originAirport, destinationAirport);
            returnRadioButton.Click();

            var date = DateTime.Now;
            inputDepartureDate.Click();
            SelectDate(date.AddDays(7));
            //inputReturnDate.Click();
            SelectDate(date.AddDays(14));
            passengersUI.Click();
            if (countPassenger.Length == 1)
                ChangeAdultsCount(countPassenger[0]);
            if (countPassenger.Length == 2)
                ChangeChildrenCount(countPassenger[1]);
            if (countPassenger.Length == 3)
                ChangeInfantsCount(countPassenger[2]);
            buttonSearchFlights.Click();
        }

        public void Login(string memberId, string password)
        {
            loginUI.Click();
            inputMemberId.SendKeys(memberId);
            inputPassword.SendKeys(password);
            buttonLogin.Click();
            loginUI.Click();
        }

        public void OpenAllOffers()
        {
            offersLink.Click();
        }

        public void OpenCarriageOfCargo()
        {
            openMenuLink.Click();
            cargoCarriageLink.Click();
            carriageOfCargoLink.Click();
        }

        public void CheckInFlights(string reservationCode, string lastName)
        {
            checkInTab.Click();
            inputReservationCode.SendKeys(reservationCode);
            inputLastName.SendKeys(lastName);
            Actions action = new Actions(driver);
            action.MoveToElement(checkBoxForRulesCheckIn, 1, 1).Build().Perform();
            action.Click().Perform();
            buttonSearchCheckIn.Click();
        }

        private void EnterAirportInfo(string originAirport, string destinationAirport)
        {
            inputOriginAirport.SendKeys(originAirport);
            inputOriginAirport.SendKeys(Keys.Tab);
            inputDestinationAirport.SendKeys(destinationAirport);
            inputDestinationAirport.SendKeys(Keys.Tab);
        }

        private void SelectDate(DateTime date)
        {
            var departuredate = driver.FindElement(By.XPath(
                string.Format(DateXPath, date.Month - 1, date.Year, date.Day)));
            departuredate.Click();
        }

        private void ChangeAdultsCount(int count)
        {
            for (int i = 0; i < count - 1; i++)
                passengersAdultsPlus.Click();
        }

        private void ChangeChildrenCount(int count)
        {
            for (int i = 0; i < count; i++)
                passengersChildrenPlus.Click();
        }

        private void ChangeInfantsCount(int count)
        {
            for (int i = 0; i < count; i++)
                passengersInfantsPlus.Click();
        }

        public bool IsShowPriceMatrix()
        {
            try
            {
                var priceMatrix = driver.FindElement(By.Id("priceMatrix"));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool CheckLanguagePage(string lang)
        {
            return string.Equals(spanLanguagePage.Text, lang);
        }

        public bool IsLoggedIn()
        {
            return !inputMemberId.GetAttribute("class").Contains("input-validation-error");
        }

        public bool IsOffersPage()
        {
            try
            {
                var offersContainer = driver.FindElement(By.ClassName(OffersPageClassName));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }        

        public bool IsCarriagePage()
        {
            try
            {
                var carriageHeader = driver.FindElement(By.XPath(CarriagePageHeaderXPath));
                return carriageHeader.Text.Contains(CarriagePageHeader);
            }
            catch (NoSuchElementException)
            {
                return false;
            }            
        }

        public bool IsCheckFlightsTrue(int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                wait.Until(ExpectedConditions.ElementExists(By.XPath(CheckFlightsModalErrorXPath)));
                return false;
            }
            catch (NoSuchElementException ex)
            {
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return true;
            }
        }
    }
}
