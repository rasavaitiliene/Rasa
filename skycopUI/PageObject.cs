using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTemplate
{
    public class PageObject
    {
        [FindsBy(How = How.XPath, Using = "//input[@class='Select-input']")]
        public IWebElement DeparturePort;

        [FindsBy(How = How.XPath, Using = "(//input[@class='Select-input'])[1]")]
        public IWebElement departureAirportfield;

        [FindsBy(How = How.XPath, Using = "//div[@title='Kaunas International Airport']")]
        public IWebElement kaunasSelection;

        [FindsBy(How = How.XPath, Using = "(//input[@class='Select-input'])[2]")]
        public IWebElement arrivalAirportfield;

        [FindsBy(How = How.XPath, Using = "//div[@title='London Gatwick Airport']")]
        public IWebElement gatwickSelection;

        



    }
}
