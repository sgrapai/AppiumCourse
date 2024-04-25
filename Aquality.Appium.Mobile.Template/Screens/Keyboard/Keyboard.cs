using Aquality.Appium.Mobile.Elements.Interfaces;
using Aquality.Appium.Mobile.Screens;
using OpenQA.Selenium;

namespace Aquality.Appium.Mobile.Template.Screens.Keyboard
{
    public abstract class Keyboard : Screen
    {
        protected readonly IButton searchBtn;

        protected Keyboard(By locator) : base(locator, "Keyboard")
        {
            searchBtn = ElementFactory.GetButton(SearchBtnLoc, "Search button");
        }

        protected abstract By SearchBtnLoc { get; }

        public void TapSearch() => searchBtn.Click();
    }
}
