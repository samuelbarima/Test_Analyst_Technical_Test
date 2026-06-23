using OpenQA.Selenium;
using TMA.TestAnalyst.Stage2.Support;

namespace TMA.TestAnalyst.Stage2.Pages
{
    public class LoginPage : BasePage
    {
        private static readonly By UsernameField = By.Id("user-name");
        private static readonly By PasswordField = By.Id("password");
        private static readonly By LoginButton = By.Id("login-button");
        private static readonly By ErrorMessage = By.CssSelector("[data-test='error']");

        public LoginPage(IWebDriver driver) : base(driver) { }

        public void Open()
        {
            Driver.Navigate().GoToUrl(TestSettings.Current.BaseUrl);
        }

        public void LoginAs(string username, string password)
        {
            EnterText(UsernameField, username);
            EnterText(PasswordField, password);
            Click(LoginButton);
        }

        public string GetErrorMessage() => WaitUntilVisible(ErrorMessage).Text;
    }
}
