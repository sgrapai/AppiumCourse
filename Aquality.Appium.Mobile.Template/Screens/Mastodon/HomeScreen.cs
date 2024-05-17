using Aquality.Appium.Mobile.Elements.Interfaces;
using Aquality.Appium.Mobile.Screens;
using OpenQA.Selenium;

namespace Aquality.Appium.Mobile.Template.Screens.Mastodon
{
    public abstract class HomeScreen : Screen
    {
        protected readonly IButton exploreTabBtn;

        protected HomeScreen(By locator) : base(locator, "Mastodon Home screen.")
        {
            exploreTabBtn = ElementFactory.GetButton(ExploreLoc, "Explore tab");
        }

        protected abstract By ExploreLoc { get; }

        public void TapExplore() => exploreTabBtn.Click();
    }
}
