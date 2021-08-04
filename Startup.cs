using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidOnDemand.Startup))]
namespace VidOnDemand
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
