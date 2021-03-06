using FubuMVC.Core;

namespace BootstrapDemonstrator
{
    // SAMPLE: FubuRegistry
    public class DemonstratorRegistry : FubuRegistry
    {
        public DemonstratorRegistry()
        {
            Routes.HomeIs<HomeEndpoint>(x => x.Index());

            // Registering the navigation registry
            Policies.Add<BootstrapDemonstrationNavigation>();
        }
    }
    // ENDSAMPLE
}