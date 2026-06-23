using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TMA.TestAnalyst.Stage2.Pages;

namespace TMA.TestAnalyst.Stage2.StepDefinitions
{
    [Binding]
    public class CheckoutSteps
    {
        private readonly InventoryPage _inventoryPage;
        private readonly CartPage _cartPage;
        private readonly CheckoutPage _checkoutPage;

        public CheckoutSteps(InventoryPage inventoryPage, CartPage cartPage, CheckoutPage checkoutPage)
        {
            _inventoryPage = inventoryPage;
            _cartPage = cartPage;
            _checkoutPage = checkoutPage;
        }

        [When(@"I check out with first name ""(.*)"", last name ""(.*)"" and postal code ""(.*)""")]
        public void WhenICheckOutWith(string firstName, string lastName, string postalCode)
        {
            // EXTENSION: open the cart, start checkout, enter the details and finish.
            // Use _inventoryPage, _cartPage and _checkoutPage.
            throw new NotImplementedException("EXTENSION: implement the checkout flow.");
        }

        [Then(@"I should see the order confirmation ""(.*)""")]
        public void ThenIShouldSeeTheOrderConfirmation(string expected)
        {
            Assert.That(_checkoutPage.GetConfirmationMessage(), Is.EqualTo(expected));
        }
    }
}
