using Aquality.Appium.Mobile.Screens.ScreenFactory;
using Aquality.Appium.Mobile.Template.Models;
using Aquality.Appium.Mobile.Template.Screens.Keyboard;
using Aquality.Appium.Mobile.Template.Screens.Mastodon;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.StepDefinitions
{
    [Binding]
    public class ExploreSteps
    {
        private readonly ExploreScreen exploreScreen;
        private readonly Keyboard keyboard;
        private ScenarioContext _context;

        public ExploreSteps(IScreenFactory factory, ScenarioContext context)
        {
            exploreScreen = factory.GetScreen<ExploreScreen>();
            keyboard = factory.GetScreen<Keyboard>();
            _context = context;
        }

        [When(@"I tap the first post")]
        public void TapOnFirstPost()
        {
            exploreScreen.TapFirstPost();
        }

        [Then(@"First post is opened")]
        public void FirstPostIsOpened()
        {
            Assert.IsTrue(exploreScreen.IsPostOpened(), "Post is not being displayed.");
        }

        [Then(@"There are posts displayed")]
        public void ArePostsDisplayed()
        {
            Assert.IsTrue(exploreScreen.ArePosts(), "There are no posts being displayed");
        }

        [When(@"I get the position of the searchfield")]
        public void GetPositionOfSearchField()
        {
            ElementPosition position = exploreScreen.GetSearchfieldPos();
            _context["searchfieldPos.X"] = position.X;
            _context["searchfieldPos.Y"] = position.Y;
        }

        [When(@"I tap the searchfield by position")]
        public void WhenITapByPosition()
        {
            exploreScreen.TapByPosition((int)_context["searchfieldPos.X"], (int)_context["searchfieldPos.Y"]);
        }

        [When(@"Fill in '(.*)'")]
        public void FillIn(string value)
        {
            exploreScreen.SetSearchfield(value);
        }

        [Then(@"The search request should be '(.*)'")]
        public void ThenRequestShouldBe(string expectedValue)
        {
            string actualValue = exploreScreen.GetSearchfieldValue();
            Assert.AreEqual(expectedValue, actualValue, "The expected value is not the same as the actual.");
        }

        [When(@"I tap on search")]
        public void TapOnSearch()
        {
            keyboard.TapSearch();
        }

        [When(@"I open first result")]
        public void TapOnFirstResult()
        {
            exploreScreen.TapFirstResult();
        }

        [When(@"I scroll down to fourth post")]
        public void WhenScrollDownTo()
        {
            exploreScreen.ScrollDownToPost();
        }
    }
}