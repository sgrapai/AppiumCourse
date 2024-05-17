using System;
using Aquality.Appium.Mobile.Screens.ScreenFactory;
using Aquality.Appium.Mobile.Template.Screens.Keyboard;
using Aquality.Appium.Mobile.Template.Screens.Mastodon;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.StepDefinitions
{
    [Binding]
    public class KeyboardSteps
    {
        private readonly ExploreScreen exploreScreen;
        private readonly Keyboard keyboard;
        private ScenarioContext _context;

        public KeyboardSteps(IScreenFactory factory, ScenarioContext context)
        {
            exploreScreen = factory.GetScreen<ExploreScreen>();
            keyboard = factory.GetScreen<Keyboard>();
            _context = context;
        }

        [When(@"I hide the keyboard")]
        public void HideKeyboard()
        {
            keyboard.Hide();
        }

        [When(@"I press enter on keyboard")]
        public void PressEnter()
        {
            keyboard.SendEnter();
        }

        [When(@"I tap outside the keyboard")]
        public void TapOutsideKeyboard()
        {
            keyboard.TapOutside();
        }

        [Then(@"The keyboard is being displayed")]
        public void IsKeyboardDisplayed()
        {
            Assert.IsTrue(keyboard.State.WaitForDisplayed(), "Keyboard is not being displayed");
        }

        [Then(@"The keyboard shouldn't be displayed")]
        public void IsKeyboardNotDisplayed()
        {
            try
            {
                Assert.IsTrue(keyboard.State.WaitForNotDisplayed(), "Keyboard is still displayed");
            }
            catch(Exception e)
            {
                Assert.Fail("The keyboard was not hidden");
            }
        }
    }
}
