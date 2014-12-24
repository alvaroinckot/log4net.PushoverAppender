using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcPushoverTest.Startup))]
namespace MvcPushoverTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
