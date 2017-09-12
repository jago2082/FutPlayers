using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FutPlayers.Startup))]
namespace FutPlayers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
