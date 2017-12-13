using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OverwatchGuides.Startup))]
namespace OverwatchGuides
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
