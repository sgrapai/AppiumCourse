using System;
using System.Text.RegularExpressions;
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
        public void IsFirstPostOpened()
        {
            Assert.IsTrue(exploreScreen.IsPostOpened(), "Post is not being displayed.");
        }

        [Then(@"There are posts displayed")]
        public void ArePostsDisplayed()
        {
            Assert.IsTrue(exploreScreen.ArePosts(), "There are no posts being displayed");
        }

        [When(@"I get the position of the searchfield and save it as '(.*)'")]
        public void GetPositionOfSearchField(string contextKey)
        {
            ElementPosition position = exploreScreen.GetSearchfieldPos();
            _context[contextKey] = position;
        }

        [When(@"I tap the searchfield by position at '(.*)'")]
        public void TapSearchfieldByPosition(string contextKey)
        {
            exploreScreen.TapByPosition(_context[contextKey]);
        }

        [When(@"Fill in '(.*)'")]
        public void FillInSearchfield(string value)
        {
            exploreScreen.SetSearchfield(value);
        }

        [Then(@"The search request should be '(.*)'")]
        public void IsRequestEqualTo(string expectedValue)
        {
            string actualValue = exploreScreen.GetSearchfieldValue();
            Assert.AreEqual(expectedValue, actualValue, "Text in searchfield is not the same as expected");
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
        public void ScrollDownToPostFour()
        {
            exploreScreen.ScrollToPost();
        }

        [When(@"I get the current context")]
        public void GetCurrentContext()
        {
            _context["currentContext"] = exploreScreen.ShowContextHandles();
        }

        [Then(@"Current context should be '(.*)'")]
        public void IsCurrentContextEqualTo(string expected)
        {
            string currentContext = _context["currentContext"].ToString();
            Assert.AreEqual(expected, currentContext, "Current context is not a native app");
        }

        [When(@"I get the position of the first post")]
        public void GetPositionOfFirstPost()
        {
            _context["firstPostText"] = exploreScreen.GetPostText();
        }

        [When(@"I scroll down to post (\d*)")]
        public void ScrollDownToPost(int number)
        {
            _context["postNumber"] = exploreScreen.ScrollToPost(number);
        }

        [When(@"Scroll back to first post")]
        public void ScrollBackUp()
        {
            exploreScreen.ScrollBackToPost(_context["firstPostText"].ToString());
        }

        [Then(@"Post (\d*) is being displayed")]
        public void IsPostDisplayed(int number)
        {
            Assert.AreEqual(number, (int)_context["postNumber"], "The post displayed is not the expected number of post");
        }

        [When(@"I tap the searchfield")]
        public void TapSearchfield()
        {
            exploreScreen.TapSearchfield();
        }
    }
}