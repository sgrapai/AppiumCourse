using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Elements.Interfaces;
using Aquality.Appium.Mobile.Screens;
using Aquality.Appium.Mobile.Template.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

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

        public void Hide() => AqualityServices.Application.Driver.HideKeyboard();

        public void SendEnter() => (AqualityServices.Application.Driver as AndroidDriver).PressKeyCode(AndroidKeyCode.Enter);

        public void TapSearch() => searchBtn.Click();

        public void TapOutside() => ScrollUtilities.TapCenter();
    }
}
