using Aquality.Appium.Mobile.Screens.ScreenFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.Mastodon
{
    [ScreenType(Mobile.Applications.PlatformName.Android)]
    public sealed class AndroidLoginScreen : LoginScreen
    {
        public AndroidLoginScreen() : base(By.XPath("//android.widget.ImageView[@resource-id='org.joinmastodon.android:id/art_center_hill']"))
        {

        }

        protected override By LoginBtnLoc => MobileBy.XPath("//android.widget.Button[@resource-id='org.joinmastodon.android:id/btn_log_in']"); 
        protected override By ServerBoxLoc => MobileBy.XPath("//android.widget.EditText[@resource-id='org.joinmastodon.android:id/search_edit']");
        protected override By ServerBtnLoc => MobileBy.XPath("//android.widget.RadioButton[@resource-id='org.joinmastodon.android:id/radiobtn']");
        protected override By NextBtnLoc => MobileBy.XPath("//android.widget.Button[@resource-id='org.joinmastodon.android:id/btn_next']");    
    }
}