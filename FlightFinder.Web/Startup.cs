using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlightFinder.Web.Startup))]
namespace FlightFinder.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
