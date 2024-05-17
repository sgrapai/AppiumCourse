using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Screens.ScreenFactory;
using Aquality.Appium.Mobile.Template.Screens.Mastodon;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.StepDefinitions
{
    [Binding]
    public class MastodonSteps
    {
        private readonly HomeScreen homeScreen;
        private readonly LoginScreen loginScreen;

        public MastodonSteps(IScreenFactory factory)
        {
            homeScreen = factory.GetScreen<HomeScreen>();
            loginScreen = factory.GetScreen<LoginScreen>();
        }

        [Given(@"Mastodon app is opened")]
        [Then(@"Mastodon app is opened")]
        public void IsMastodonAppOpened()
        {
            Assert.IsTrue(homeScreen.State.WaitForDisplayed(), "Mastodon home screen is not being displayed.");
        }

        [Given(@"Mastodon Login Screen is opened")]
        [Then(@"Mastodon Login Screen is opened")]
        public void IsMastodonLoginScreenOpened()
        {
            Assert.IsTrue(loginScreen.State.WaitForDisplayed(), "Mastodon login screen is not opened.");
        }

        [When(@"I close Mastodon app")]
        public void CloseApp()
        {
            AqualityServices.Application.Driver.TerminateApp("org.joinmastodon.android");
        }

        [When(@"I tap on log in button")]
        public void TapLogIn()
        {
            loginScreen.TapLogin();
        }

        [When(@"Select Mastodon.social server")]
        public void SelectServer()
        {
            loginScreen.SetServer("Mastodon.social")
                .SelectServer()
                .TapNextButton();
        }

        [When(@"I tap on Explore")]
        public void TapOnExplore()
        {
            homeScreen.TapExplore();
        }
    }
}
