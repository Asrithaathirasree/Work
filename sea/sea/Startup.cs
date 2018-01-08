using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sea.Startup))]
namespace sea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
