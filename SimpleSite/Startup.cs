using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleSite.Startup))]
namespace SimpleSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
