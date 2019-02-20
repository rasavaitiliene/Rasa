using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;


namespace SeleniumTemplate
{
    [Binding]
    public class StepDefinition
    {
        private PageObject _pageObject;
        public PageObject PageObject => _pageObject ?? (_pageObject = new PageObject());
        public static IWebDriver Driver;
        public class Browser

        {
            public IWebDriver Chrome;

            public Browser()
            {
                var options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                Chrome = new ChromeDriver(options);
            }
        }

        public StepDefinition(Browser browser)
        {
            Driver = browser.Chrome;
            PageFactory.InitElements(Driver, PageObject);
        }
        //I open google homepage
        [Given(@"I Open Google homepage")]
        public void GivenIOpenSkycopClaimPage()
        {
            Driver.Url = "https://www.google.com/";
        }
        //I navigate to claim
        [Given(@"I navigate to claim")]
        public void GivenINavigateToClaims()
        {
            Driver.Url = "https://claim.skycop.com/";
        }
        [Then(@"I set Kaunas as Departure airport")]
        public void ThenISetKaunasAsDepartureAirport()
        {
            Thread.Sleep(5000);
           // var departureAirportfield = Driver.FindElement(By.XPath("(//input[@class='Select-input'])[1]"));
            Thread.Sleep(2000);
            PageObject.departureAirportfield.SendKeys(Constants.City);
            Thread.Sleep(1000);
            //var kaunasSelection = Driver.FindElement(By.XPath("//div[@title='Kaunas International Airport']"));
            PageObject.kaunasSelection.Click();
        }
        [Then(@"I set London Gatwick as arrival airport")]
        public void ThenISetLondonGatwickAsArrivalAirport()
        {
            Thread.Sleep(5000);
            //var arrivalAirportfield = Driver.FindElement(By.XPath("(//input[@class='Select-input'])[2]"));
            Thread.Sleep(2000);
            PageObject.arrivalAirportfield.SendKeys(Constants.City2);
            Thread.Sleep(2000);
           // var gatwickSelection = Driver.FindElement(By.XPath("//div[@title='London Gatwick Airport']"));
            PageObject.gatwickSelection.Click();

        }
        [Then(@"I choose airlines")]
        public void ThenIChooseAirlines()
        {
            Thread.Sleep(5000);
            var airlinesfield = Driver.FindElement(By.XPath("(//input[@class='Select-input'])[3]"));
            airlinesfield.SendKeys("Ryanair");
            Thread.Sleep(4000);
            var airlinesSelection = Driver.FindElement(By.XPath("//div[@title='Ryanair']"));
            airlinesSelection.Click();
        }
        [Then(@"I set (.*) as Flight number")]
        public void ThenISetAsFlightNumber(int p0)
        {
            var flightnumberfield = Driver.FindElement(By.XPath("//input[@class='form-control js-flightDigits js-checkable data-hj-whitelist sc-kkGfuU eUxbsH']"));
            flightnumberfield.SendKeys("1238");
            var flightnumberSelection = Driver.FindElement(By.XPath("//input[@name='failedFlightNumberDigits']"));
            flightnumberSelection.Click();
           
        }
        //I chhose the data from calendar
        [Then(@"I set flight data")]
        public void ThenISetFlightData()
        {
            Thread.Sleep(4000);
            var flightdatafield = Driver.FindElement(By.XPath("//input[@name='failedFlightDate']"));
            flightdatafield.Click();
            var dataValuefield = Driver.FindElement(By.XPath("(//td[@data-value='28'])[2]"));
            dataValuefield.Click();
        }
        //I choose button Flight delayed
        [Then(@"I choose Flight delayed as the problem of the flight you encountered")]
        public void ThenIChooseFlightDelayedAsTheProblemOfTheFlightYouEncountered()
        {
            var flightDelayaed = Driver.FindElement(By.XPath("(//span[@class='form-check-label form-check-label--bold'])[1]"));
            flightDelayaed.Click();
        }
        // I choose button More than 3 hours
        [Then(@"I choose More than (.*) hours as How long were you delayed to reach the final airport\?")]
        public void ThenIChooseMoreThanHoursAsHowLongWereYouDelayedToReachTheFinalAirport(int p0)
        {
            Thread.Sleep(4000);
            var MoreThan3hours = Driver.FindElement(By.XPath("(//span[@class='form-check-label form-check-label--bold'])[5]"));
            MoreThan3hours.Click();
        }
        [Then(@"I choose what was the reason provided by airlines")]
        public void ThenIChooseWhatWasTheReasonProvidedByAirlines()
        {
            Thread.Sleep(2000);
            var reasonProvidedField = Driver.FindElement(By.XPath("//span[@id='react-select-6--value']"));
            reasonProvidedField.Click();
            Thread.Sleep(2000);
            var Aircrafttechnicalproblem = Driver.FindElement(By.XPath("//div[text()='Aircraft technical problem']"));
            Aircrafttechnicalproblem.Click();
        }
        [Then(@"I choose Where did you hear about us\?")]
        public void ThenIChooseWhereDidYouHearAboutUs()
        {
            Thread.Sleep(2000);
            var WhereDidYouHearAboutUsField = Driver.FindElement(By.XPath("//span[@id='react-select-7--value']"));
            WhereDidYouHearAboutUsField.Click();
            Thread.Sleep(2000);
            var Facebook = Driver.FindElement(By.XPath("//div[text()='Facebook']"));
            Facebook.Click();
        }
        [Then(@"I push the button Next step")]
        public void ThenIPushTheButtonNextStep()
        {
            Thread.Sleep(2000);
            var NextStepButton = Driver.FindElement(By.XPath("//button[@class='sc-jzgbtB fuZkWY sc-lhVmIH hgYwDF']"));
            NextStepButton.Click();
        }
        [Then(@"I Briefly describe situation")]
        public void ThenIBrieflyDescribeSituation()
        {
            Thread.Sleep(2000);
            var BrieflyDescribeSituationField = Driver.FindElement(By.XPath("//textarea[@class='form-control sc-dUjcNx eiJlti']"));
            BrieflyDescribeSituationField.SendKeys("We waited 6 hours");
        }
        [Then(@"I Enter flight reservation number")]
        public void ThenIEnterFlightReservationNumber()
        {
            Thread.Sleep(2000);
            var EnterFlightReservationNumberField = Driver.FindElement(By.XPath("(//input[@type='text'])[3]"));
            EnterFlightReservationNumberField.SendKeys("12FR34");
        }
        [Then(@"I push the button Enter travellers details")]
        public void ThenIPushTheButtonEnterTravellersDetails()
        {
            Thread.Sleep(2000);
            var EnterTravellersDetailsButton = Driver.FindElement(By.XPath("//button[@class='sc-lkqHmb gWdxsM sc-lhVmIH hgYwDF']"));
            EnterTravellersDetailsButton.Click();
        }
        [Then(@"I write my Name")]
        public void ThenIWriteMyName()
        {
            Thread.Sleep(2000);
            var NameField = Driver.FindElement(By.XPath("(//input[@type='text'])[1]"));
            NameField.SendKeys("Rasa");
        }
        [Then(@"I write my Surname")]
        public void ThenIWriteMySurname()
        {
            Thread.Sleep(2000);
            var SurnameField = Driver.FindElement(By.XPath("(//input[@type='text'])[2]"));
            SurnameField.SendKeys("Pavarde");
        }
        [Then(@"I set my Birthdate")]
        public void ThenISetMyBirthdate()
        {
            Thread.Sleep(2000);
            var BirtgdayField = Driver.FindElement(By.XPath("(//input[@type='text'])[3]"));
            BirtgdayField.Click();
            Thread.Sleep(2000);
            var DataValueField = Driver.FindElement(By.XPath("(//td[@data-value='1980'])[1]"));
            DataValueField.Click();
            Thread.Sleep(2000);
            var DataValueMonthField = Driver.FindElement(By.XPath("//td[@data-value='4']"));
            DataValueMonthField.Click();
            Thread.Sleep(2000);
            var DataValueDayField = Driver.FindElement(By.XPath("//td[@data-value='15']"));
            DataValueDayField.Click();
        }
        [Then(@"I write my Email")]
        public void ThenIWriteMyEmail()
        {
            Thread.Sleep(2000);
            var EmailField = Driver.FindElement(By.XPath("(//input[@type='text'])[4]"));
            EmailField.SendKeys("rasa.pavarde@gmail.com");
        }
        [Then(@"I repeat my Email")]
        public void ThenIRepeatMyEmail()
        {
            Thread.Sleep(2000);
            var EmailField = Driver.FindElement(By.XPath("(//input[@type='text'])[5]"));
            EmailField.SendKeys("rasa.pavarde@gmail.com");
        }
        [Then(@"I set user phone")]
        public void ThenISetUserPhone()
        {
            Thread.Sleep(2000);
            var phoneField = Driver.FindElement(By.XPath("//input[@name='userPhoneCode']"));
            phoneField.Click();
            var phone = Driver.FindElement(By.XPath("//span[@id='react-select-9--value']//input"));
            phone.SendKeys("Lithuania");
            var lithuania = Driver.FindElement(By.XPath("//div[@title='Lithuania']"));
            lithuania.Click();
            var FillTextField = Driver.FindElement(By.XPath("(//input[@class='sc-kkGfuU eUxbsH'])[6]"));
            FillTextField.SendKeys("64621287");
            //(//input[@class='sc-kkGfuU eUxbsH'])[7]
        }
        [Then(@"I set Address")]
        public void ThenISetAddress()
        {
            Thread.Sleep(2000);
            var AddressField = Driver.FindElement(By.XPath("(//input[@class='sc-kkGfuU eUxbsH'])[7]"));
            AddressField.SendKeys("Vakaro 6");
        }
        [Then(@"I set City")]
        public void ThenISetCity()
        {
            Thread.Sleep(2000);
            var CityField = Driver.FindElement(By.XPath("(//input[@class='sc-kkGfuU eUxbsH'])[8]"));
            CityField.SendKeys("Kaunas");
        }
        [Then(@"I set Postcode")]
        public void ThenISetPostcode()
        {
            Thread.Sleep(2000);
            var PostcodeField = Driver.FindElement(By.XPath("(//input[@class='sc-kkGfuU eUxbsH'])[9]"));
            PostcodeField.SendKeys("49348");
        }
        [Then(@"I choose Country")]
        public void ThenIChooseCountry()
        {
            Thread.Sleep(2000);
            var CountryField = Driver.FindElement(By.XPath("(//div[@class='Select-placeholder'])[2]"));
            CountryField.Click();

            var Lithuania = Driver.FindElement(By.XPath("//span[@id='react-select-10--value']//input[@class='Select-input']"));
            Lithuania.SendKeys("Lithuania");

            var SelectLithuania = Driver.FindElement(By.XPath("//div[text()='Lithuania']"));
            SelectLithuania.Click();


        }
        [Then(@"I choose Language")]
        public void ThenIChooseLanguage()
        {
            Thread.Sleep(2000);
            var LanguageField = Driver.FindElement(By.XPath("(//div[@class='Select-placeholder'])[2]"));
            LanguageField.Click();
            var Lietuvių = Driver.FindElement(By.XPath("//div[@id='react-select-11--option-5']"));
            Lietuvių.Click();
        }
        [Then(@"I push the button No, I was travelling alone")]
        public void ThenIPushTheButtonNoIWasTravellingAlone()
        {
            Thread.Sleep(2000);
            var TravellingAloneButton = Driver.FindElement(By.XPath("//span[text()='No, I was travelling alone']"));
            TravellingAloneButton.Click();
        }
        [Then(@"I click the button I have read and agree to the Terms of sevice and Privacy policy")]
        public void ThenIClickTheButtonIHaveReadAndAgreeToTheTermsOfSeviceAndPrivacyPolicy()
        {
            Thread.Sleep(2000);
            var AgryButton = Driver.FindElement(By.XPath("(//span[@class='sc-jhAzac cQDAxd'])[4]"));
            AgryButton.Click();
        }
        [Then(@"I puch the button Final Step")]
        public void ThenIPuchTheButtonFinalStep()
        {
            Thread.Sleep(2000);
            var FinalStepButton = Driver.FindElement(By.XPath("//button[@class='sc-cqCuEk faxLYi sc-lhVmIH hgYwDF']"));
            FinalStepButton.Click();
        }
        [Then(@"I sign The assignment form")]
        public void ThenISignTheAssignmentForm()
        {
            Actions builder = new Actions(Driver);
            IAction drawAction = builder.MoveToElement(PageObject.SignatureCanvas, 10, 10)
            .ClickAndHold()
            .MoveByOffset(50, 50)
            .Release()
            .Build();
            drawAction.Perform();

        }

    }
}



  