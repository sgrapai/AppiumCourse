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

        public MastodonSteps(IScreenFactory factory)
        {
            homeScreen = factory.GetScreen<HomeScreen>();
        }

        [Then(@"'(.*)' app is open")]
        public void ThenAppIsOpen(string appName)
        {
            Assert.IsTrue(homeScreen.State.WaitForDisplayed(), "Mastodon home screen is not being displayed.");
        }

        [When(@"I close '(.*)' app")]
        public void WhenICloseApp(string appName)
        {
            AqualityServices.Application.Driver.TerminateApp("org.joinmastodon.android");
        }
    }
}
