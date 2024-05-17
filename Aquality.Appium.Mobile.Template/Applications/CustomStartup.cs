using System;
using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Template.Utilities;
using Aquality.Selenium.Core.Applications;
using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Localization;
using Microsoft.Extensions.DependencyInjection;

namespace Aquality.Appium.Mobile.Template.Applications
{
    public class CustomStartup : MobileStartup
    {
        public override IServiceCollection ConfigureServices(IServiceCollection services, Func<IServiceProvider, IApplication> applicationProvider, ISettingsFile settings = null)
        {
            settings = settings ?? GetSettings();
            base.ConfigureServices(services, applicationProvider, settings);
            return services;
        }
    }
}
