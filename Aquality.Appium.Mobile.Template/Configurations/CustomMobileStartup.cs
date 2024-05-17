using System;
using Aquality.Appium.Mobile.Applications;
using Aquality.Selenium.Core.Applications;
using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace Aquality.Appium.Mobile.Template.Configurations
{
    public class CustomMobileStartup : MobileStartup
    {
        private readonly string settingsFileName;

        public CustomMobileStartup(string settingsFileName = null)
        {
            this.settingsFileName = settingsFileName ?? string.Empty;
        }

        public override IServiceCollection ConfigureServices(IServiceCollection services, Func<IServiceProvider, IApplication> applicationProvider, ISettingsFile settings = null)
        {
            if (!string.IsNullOrEmpty(settingsFileName))
            {
                settings = new JsonSettingsFile(settingsFileName);
            }
            base.ConfigureServices(services, applicationProvider, settings);
            return services;
        }
    }
}
