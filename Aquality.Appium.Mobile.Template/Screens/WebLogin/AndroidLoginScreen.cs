using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Screens.ScreenFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.WebLogin
{
    [ScreenType(PlatformName.Android)]
    public sealed class AndroidLoginScreen : LoginScreen
    {
        public AndroidLoginScreen() : base(By.XPath("//android.widget.Button[@text='Log in']"))
        {
        }

        protected override By UsernameTxbLoc => MobileBy.XPath("//android.webkit.WebView[@text='Log in - Mastodon']/android.view.View[2]/android.view.View[2]/android.view.View[2]/android.widget.EditText");
        protected override By PasswordTxbLoc => MobileBy.XPath("//android.webkit.WebView[@text='Log in - Mastodon']/android.view.View[2]/android.view.View[3]/android.view.View[2]/android.widget.EditText");
        protected override By LoginBtnLoc => MobileBy.XPath("//android.widget.Button[@text='Log in']");
        protected override By AcceptBtnLoc => MobileBy.XPath("//android.widget.Button[@text='Authorize']");
    }
}
