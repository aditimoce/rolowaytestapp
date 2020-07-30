using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RolowayTestApp.Startup))]
namespace RolowayTestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
