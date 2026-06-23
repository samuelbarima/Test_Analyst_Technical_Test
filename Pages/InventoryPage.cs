using System.Threading;
using OpenQA.Selenium;

namespace TMA.TestAnalyst.Stage2.Pages
{
    public class InventoryPage : BasePage
    {
        private static readonly By InventoryContainer = By.Id("inventory_container");
        private static readonly By CartBadge = By.CssSelector(".shopping_cart_badge");
        private static readonly By CartLink = By.CssSelector(".shopping_cart_link");
        private static readonly By addToCart = By.XPath($"//div[text()='Sauce Labs Bckpack']/ancestor::div[contains(@class,'inventory_item')]//button");

        public InventoryPage(IWebDriver driver) : base(driver) { }

        public void WaitUntilLoaded()
        {
            // Blunt fixed wait used to "let the page settle" after login.
            Thread.Sleep(3000);
        }

        public bool IsLoaded() => Driver.FindElements(InventoryContainer).Count > 0;

        public void AddProductToCart(string productName)
        {
            // Locate the product's tile by name, then its Add button.
            var addButton = Driver.FindElement(
                By.XPath($"//div[text()='{productName}']/ancestor::div[@class='inventory_item']//button[text()='ADD TO CART']"));
            addButton.Click();
        }

        public string GetCartBadgeText() => WaitUntilVisible(CartBadge).Text;

        public void OpenCart() => Click(CartLink);
    }
}
