using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ErrantDaydream.Startup))]
namespace ErrantDaydream
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
