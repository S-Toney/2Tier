using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2Tier.Startup))]
namespace _2Tier
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
