using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ralwey.Startup))]
namespace Ralwey
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
