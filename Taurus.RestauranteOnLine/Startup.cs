using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Taurus.RestauranteOnLine.Startup))]
namespace Taurus.RestauranteOnLine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
