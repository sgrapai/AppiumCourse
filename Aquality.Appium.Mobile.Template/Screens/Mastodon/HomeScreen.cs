using System.Buffers;
using Aquality.Appium.Mobile.Elements.Interfaces;
using Aquality.Appium.Mobile.Screens;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Aquality.Appium.Mobile.Template.Screens.Mastodon
{
    public abstract class HomeScreen : Screen
    {
        protected readonly IButton exploreTabBtn;
        protected readonly ILabel firstPost;
        protected readonly ILabel toolbar;
        protected HomeScreen(By locator):base(locator, "Mastodon Home screen.")
        {
            exploreTabBtn = ElementFactory.GetButton(ExploreLoc, "Explore tab");
            firstPost = ElementFactory.GetLabel(PostLoc, "First post");
            toolbar = ElementFactory.GetLabel(ToolbarLoc, "Tool Bar");
        }

        protected abstract By ExploreLoc {  get; }
        protected abstract By PostLoc { get; }
        protected abstract By ToolbarLoc { get; }

        public void TapExplore() => exploreTabBtn.Click();

        public void TapFirstPost() => firstPost.Click();
        public bool IsPostOpened() => toolbar.State.WaitForDisplayed();
    }
}
