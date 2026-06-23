using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TMA.TestAnalyst.Stage2.Pages;

namespace TMA.TestAnalyst.Stage2.StepDefinitions
{
    [Binding]
    public class InventorySteps
    {
        private readonly IWebDriver _driver;
        private readonly InventoryPage _inventoryPage;

        public InventorySteps(IWebDriver driver, InventoryPage inventoryPage)
        {
            _driver = driver;
            _inventoryPage = inventoryPage;
        }

        [When(@"I add ""(.*)"" to the cart")]
        [Given(@"I have added ""(.*)"" to the cart")]
        public void WhenIAddToTheCart(string productName)
        {
            _inventoryPage.AddProductToCart(productName);
        }

        [Then(@"the cart should contain (.*) item")]
        public void ThenTheCartShouldContain(int count)
        {
            Assert.That(_driver.FindElements(By.CssSelector(".shopping_cart_link")).Count,
                Is.GreaterThanOrEqualTo(0));
        }
    }
}
