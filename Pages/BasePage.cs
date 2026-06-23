using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TMA.TestAnalyst.Stage2.Support;

namespace TMA.TestAnalyst.Stage2.Pages
{
    public abstract class BasePage
    {
        protected readonly IWebDriver Driver;
        protected readonly WebDriverWait Wait;

        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(TestSettings.Current.DefaultTimeoutSeconds));
            Wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
        }

        protected IWebElement WaitUntilVisible(By locator)
        {
            return Wait.Until(d =>
            {
                var element = d.FindElement(locator);
                return element.Displayed ? element : null;
            });
        }

        protected void Click(By locator) => WaitUntilVisible(locator).Click();

        protected void EnterText(By locator, string text)
        {
            var element = WaitUntilVisible(locator);
            element.Clear();
            element.SendKeys(text);
        }
    }
}
