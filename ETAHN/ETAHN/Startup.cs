using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ETAHN.Startup))]
namespace ETAHN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
