using Aquality.Appium.Mobile.Screens;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Aquality.Appium.Mobile.Template.Screens.Mastodon
{
    public abstract class HomeScreen : Screen
    {
        protected HomeScreen(By locator):base(locator, "Mastodon Home screen.")
        {

        }


    }
}
