using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Screens.ScreenFactory;
using OpenQA.Selenium;

namespace Aquality.Appium.Mobile.Template.Screens.HomeScreen
{
    [ScreenType(PlatformName.Android)]
    public sealed class AndroidHomeScreen : HomeScreen
    {
        public AndroidHomeScreen() : base(By.XPath("//android.widget.ImageView[@resource-id='org.joinmastodon.android:id/art_center_hill']"))
        {

        }
    }
}
