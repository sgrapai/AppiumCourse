using Aquality.Appium.Mobile.Screens;
using OpenQA.Selenium;

namespace Aquality.Appium.Mobile.Template.Screens.HomeScreen
{
    public abstract class HomeScreen : Screen
    {
        protected HomeScreen(By locator) : base(locator, "Main home screen.")
        {

        }
    }
}
