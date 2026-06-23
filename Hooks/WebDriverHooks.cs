using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TMA.TestAnalyst.Stage2.Support;

namespace TMA.TestAnalyst.Stage2.Hooks
{
    [Binding]
    public class WebDriverHooks
    {
        private readonly IObjectContainer _container;
        private IWebDriver _driver;

        public WebDriverHooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario]
        public void StartBrowser()
        {
            var settings = TestSettings.Current;

            var options = new ChromeOptions();
            if (settings.Headless)
            {
                options.AddArgument("--headless=new");
            }
            options.AddArgument("--window-size=1280,900");

            // Selenium Manager (4.6+) resolves the matching chromedriver automatically.
            _driver = new ChromeDriver(options);

            // Make the live driver available to page objects / step classes via DI.
            _container.RegisterInstanceAs<IWebDriver>(_driver);
        }

        // ---------------------------------------------------------------------
        // NOTE: there is intentionally no scenario teardown here.
        // Each scenario opens a browser that is never closed.
        // ---------------------------------------------------------------------
    }
}
