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

        [Then(@"Mastodon app is opened")]
        public void ThenAppIsOpen()
        {
            Assert.IsTrue(homeScreen.State.WaitForDisplayed(), "Mastodon home screen is not being displayed.");
        }

        [Then(@"Mastodon Login Screen is opened")]
        public void MLSIsOpened()
        {
            Assert.IsTrue(loginScreen.State.WaitForDisplayed(), "Mastodon login screen is not opened.");
        }

        [When(@"I close Mastodon app")]
        public void WhenICloseApp()
        {
            AqualityServices.Application.Driver.TerminateApp("org.joinmastodon.android");
        }

        [When(@"I tap on log in button")]
        public void WhenILogIn()
        {
            loginScreen.TapLogin();
        }

        [When(@"Select Mastodon.social server")]
        public void WhenISelectServer()
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
