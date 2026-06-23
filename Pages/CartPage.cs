using OpenQA.Selenium;

namespace TMA.TestAnalyst.Stage2.Pages
{
    public class CartPage : BasePage
    {
        private static readonly By CartItem = By.CssSelector(".cart_item");
        private static readonly By CheckoutButton = By.Id("checkout");

        public CartPage(IWebDriver driver) : base(driver) { }

        public int ItemCount() => Driver.FindElements(CartItem).Count;

        public void Checkout() => Click(CheckoutButton);
    }
}
