using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Screens.ScreenFactory;
using OpenQA.Selenium;

namespace Aquality.Appium.Mobile.Template.Screens.Mastodon
{
    [ScreenType(PlatformName.Android)]
    internal class AndroidHomeScreen : HomeScreen
    {
        public AndroidHomeScreen() : base(By.XPath("(//android.widget.TextView[@text=\"Home\"])[1]"))
        {

        }
    }
}
