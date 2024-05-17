using Aquality.Appium.Mobile.Screens.ScreenFactory;
using Aquality.Appium.Mobile.Template.Models;
using Aquality.Appium.Mobile.Template.Screens.WebLogin;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginScreen loginScreen;

        public LoginSteps(IScreenFactory screenFactory)
        {
            loginScreen = screenFactory.GetScreen<LoginScreen>();
        }

        [When(@"I log in Mastodon.social with '(.*)' username and '(.*)' password")]
        public void FillInLoginForm(string username, string password)
        {
            loginScreen.SetUsername(username)
                .SetPassword(password)
                .TapLogin();
        }

        [When(@"I authorize log in")]
        public void AuthorizeLogIn()
        {
            loginScreen.TapAccept();
        }

        [Then(@"Web Login Screen is opened")]
        public void IsLoginScreenOpened()
        {
            Assert.IsTrue(loginScreen.State.WaitForDisplayed(), "Login Screen is opened");
        }
    }
}
