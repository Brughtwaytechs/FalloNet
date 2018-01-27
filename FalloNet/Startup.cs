using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FalloNet.Startup))]
namespace FalloNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
