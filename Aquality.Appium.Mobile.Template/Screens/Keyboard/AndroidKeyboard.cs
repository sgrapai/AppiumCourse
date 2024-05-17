using Aquality.Appium.Mobile.Screens.ScreenFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Template.Screens.Keyboard
{
    [ScreenType(Mobile.Applications.PlatformName.Android)]
    public sealed class AndroidKeyboard : Keyboard
    {
        public AndroidKeyboard() : base(By.XPath("//android.widget.LinearLayout[@resource-id='com.google.android.inputmethod.latin:id/keyboard_holder']"))
        {

        }

        protected override By SearchBtnLoc => MobileBy.XPath("//android.widget.FrameLayout[@content-desc='Search']");
    }
}
