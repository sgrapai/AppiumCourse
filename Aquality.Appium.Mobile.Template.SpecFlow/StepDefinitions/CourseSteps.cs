using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Screens.ScreenFactory;
using Aquality.Appium.Mobile.Template.Screens.HomeScreen;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.StepDefinitions
{
    [Binding]
    public class CourseSteps
    {
        private readonly HomeScreen homeScreen;

        public CourseSteps(IScreenFactory factory)
        {
            homeScreen = factory.GetScreen<HomeScreen>();
        }

        [Given(@"Connection is ok")]
        [Then(@"Home screen is open")]
        public void ConnectionIsOk()
        {
            Assert.IsTrue(homeScreen.State.WaitForDisplayed(), "Home screen is not displayed.");
        }

        [When(@"I launch '(.*)' app")]
        public void WhenILaunchApp(string appName)
        {
            AqualityServices.Application.Driver.ActivateApp("org.joinmastodon.android");
        }
    }
}
