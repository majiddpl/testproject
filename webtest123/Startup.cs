using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webtest123.Startup))]
namespace webtest123
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
