using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(timeManager3.Startup))]
namespace timeManager3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
