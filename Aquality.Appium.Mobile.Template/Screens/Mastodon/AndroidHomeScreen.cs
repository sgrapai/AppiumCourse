using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Screens.ScreenFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.Mastodon
{
    [ScreenType(PlatformName.Android)]
    internal class AndroidHomeScreen : HomeScreen
    {
        public AndroidHomeScreen() : base(By.XPath("(//android.widget.TextView[@text=\"Home\"])[1]"))
        {

        }

        protected override By ExploreLoc => MobileBy.XPath("//android.widget.FrameLayout[@content-desc=\"Search\"]");
        protected override By PostLoc => MobileBy.XPath("(//android.widget.TextView[@resource-id=\"org.joinmastodon.android:id/text\" and contains(@text, '')])");
        protected override By ToolbarLoc => MobileBy.XPath("//android.view.ViewGroup[@resource-id=\"org.joinmastodon.android:id/toolbar\"]");
    }
}
