using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ASPNETBackend.Startup))]

namespace ASPNETBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}