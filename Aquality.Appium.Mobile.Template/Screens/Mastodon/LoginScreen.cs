using Aquality.Appium.Mobile.Elements.Interfaces;
using Aquality.Appium.Mobile.Screens;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V108.Target;

namespace Aquality.Appium.Mobile.Template.Screens.Mastodon
{
    public abstract class LoginScreen : Screen
    {
        protected readonly IButton loginBtn;
        protected readonly ITextBox serverTxb;
        protected readonly IButton serverBtn;
        protected readonly IButton nextBtn;

        protected LoginScreen(By locator):base(locator, "Mastodon log in screen")
        {
            loginBtn = ElementFactory.GetButton(LoginBtnLoc, "Login");
            serverTxb = ElementFactory.GetTextBox(ServerBoxLoc, "Server selection text box");
            serverBtn = ElementFactory.GetButton(ServerBtnLoc, "Server selection button");
            nextBtn = ElementFactory.GetButton(NextBtnLoc, "Next button");
        }

        protected abstract By LoginBtnLoc { get; }
        protected abstract By ServerBoxLoc { get; }
        protected abstract By ServerBtnLoc { get; }
        protected abstract By NextBtnLoc { get; }

        public void TapLogin() => loginBtn.Click();

        public LoginScreen SetServer(string serverName)
        {
            serverTxb.SendKeys(serverName);
            return this;
        }

        public LoginScreen SelectServer()
        {
            serverBtn.Click();
            return this;
        }

        public void TapNextButton() => nextBtn.Click();
    }
}
