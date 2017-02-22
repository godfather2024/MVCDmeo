using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDmeo.Startup))]
namespace MVCDmeo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
