using Aquality.Appium.Mobile.Applications;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.Hooks
{
    [Binding]
    public class ApplicationHooks
    {
        private readonly ScenarioContext context;

        public ApplicationHooks(ScenarioContext context)
        {
            this.context = context;
        }

        [AfterScenario]
        public void CloseApplication()
        {
            AqualityServices.Application.Driver.TerminateApp("org.joinmastodon.android");
            if (AqualityServices.IsApplicationStarted)
            {
                AqualityServices.Application.Quit();
            }
        }
    }
}
