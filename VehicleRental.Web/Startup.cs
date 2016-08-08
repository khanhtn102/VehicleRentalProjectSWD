using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VehicleRental.Web.Startup))]
namespace VehicleRental.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
