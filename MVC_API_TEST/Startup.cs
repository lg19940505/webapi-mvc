using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_API_TEST.Startup))]
namespace MVC_API_TEST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
