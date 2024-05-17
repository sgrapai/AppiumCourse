using System.Text.RegularExpressions;
using Allure.Commons;
using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Template.Applications;
using Aquality.Appium.Mobile.Template.Configurations;
using AqualityTracking.Integrations.Core;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.Hooks
{
    [Binding]
    public class PluginsHooks
    {
        private readonly ScenarioContext context;
        private readonly PlatformName platformName;

        public PluginsHooks(ScenarioContext context)
        {
            this.context = context;
            platformName = AqualityServices.ApplicationProfile.PlatformName;
        }

        [BeforeFeature]
        public static void RegisterCustomStartup()
        {
            MobileStartup customStartup = new CustomMobileStartup("settings.new.json");
            AqualityServices.SetStartup(customStartup);
            AqualityServices.Application.Driver.ActivateApp("org.joinmastodon.android");
        }
    }
}
