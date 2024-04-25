using Aquality.Appium.Mobile.Screens.ScreenFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.Mastodon
{
    [ScreenType(Mobile.Applications.PlatformName.Android)]
    public sealed class AndroidExploreScreen : ExploreScreen
    {
        public AndroidExploreScreen() : base(By.XPath("//android.widget.HorizontalScrollView[@resource-id=\"org.joinmastodon.android:id/tabbar\"]"))
        {

        }
        protected override By PostsLoc => MobileBy.XPath("//android.widget.LinearLayout");
        protected override By ToolbarLoc => MobileBy.XPath("//android.view.ViewGroup[@resource-id=\"org.joinmastodon.android:id/toolbar\"]");
        protected override By SearchLabelLoc => MobileBy.XPath("//android.widget.TextView[@resource-id=\"org.joinmastodon.android:id/search_text\"]");
        protected override By SearchfieldLoc => MobileBy.XPath("//android.widget.EditText[@text=\"Search Mastodon\"]");
        protected override By ResultsLoc => MobileBy.XPath("//androidx.recyclerview.widget.RecyclerView[@resource-id=\"org.joinmastodon.android:id/list\"]/android.widget.RelativeLayout");
        protected override By PostLoc => MobileBy.XPath("//android.widget.TextView[@resource-id=\"org.joinmastodon.android:id/text\" and @text=\"New release: phpstan-strict-rules 1.5.4 https://github.com/phpstan/phpstan-str…ict-rules/releases/tag/1.5.4 #phpstan\"]");
    }
}
