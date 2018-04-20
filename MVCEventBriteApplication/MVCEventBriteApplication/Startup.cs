using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCEventBriteApplication.Startup))]
namespace MVCEventBriteApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
