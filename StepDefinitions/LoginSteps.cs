using NUnit.Framework;
using TechTalk.SpecFlow;
using TMA.TestAnalyst.Stage2.Pages;

namespace TMA.TestAnalyst.Stage2.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage _loginPage;
        private readonly InventoryPage _inventoryPage;

        public LoginSteps(LoginPage loginPage, InventoryPage inventoryPage)
        {
            _loginPage = loginPage;
            _inventoryPage = inventoryPage;
        }

        [Given(@"the login page is open")]
        public void GivenTheLoginPageIsOpen()
        {
            _loginPage.Open();
        }

        [When(@"I sign in as ""(.*)"" with password ""(.*)""")]
        [Given(@"I sign in as ""(.*)"" with password ""(.*)""")]
        public void WhenISignInAs(string username, string password)
        {
            _loginPage.LoginAs(username, password);
            _inventoryPage.WaitUntilLoaded();
        }

        [Then(@"the products page is displayed")]
        public void ThenTheProductsPageIsDisplayed()
        {
            Assert.That(_inventoryPage.IsLoaded(), Is.True, "Products page did not load.");
        }
    }
}
