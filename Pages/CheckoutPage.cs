using System;
using OpenQA.Selenium;

namespace TMA.TestAnalyst.Stage2.Pages
{
    // =====================================================================
    // EXTENSION TASK
    // ---------------------------------------------------------------------
    // This page object is an intentional stub. Implement the three methods
    // so the "Complete a purchase" scenario in Checkout.feature passes.
    //
    // Useful SauceDemo locators (data-test attributes are stable):
    //   First name    [data-test='firstName']
    //   Last name     [data-test='lastName']
    //   Postal code   [data-test='postalCode']
    //   Continue      [data-test='continue']    (this control is an <input>)
    //   Finish        [data-test='finish']
    //   Confirmation  [data-test='complete-header']   -> "Thank you for your order!"
    // =====================================================================
    public class CheckoutPage : BasePage
    {
        public CheckoutPage(IWebDriver driver) : base(driver) { }

        public void EnterCustomerInformation(string firstName, string lastName, string postalCode)
        {
            throw new NotImplementedException("EXTENSION: enter the customer details and continue.");
        }

        public void Finish()
        {
            throw new NotImplementedException("EXTENSION: click Finish to place the order.");
        }

        public string GetConfirmationMessage()
        {
            throw new NotImplementedException("EXTENSION: return the order confirmation header text.");
        }
    }
}
