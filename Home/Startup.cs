using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Home.Startup))]
namespace Home
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
