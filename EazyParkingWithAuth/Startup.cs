using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EazyParkingWithAuth.Startup))]
namespace EazyParkingWithAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
