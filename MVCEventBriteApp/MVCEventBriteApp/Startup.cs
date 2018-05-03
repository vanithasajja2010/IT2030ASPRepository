using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCEventBriteApp.Startup))]
namespace MVCEventBriteApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
