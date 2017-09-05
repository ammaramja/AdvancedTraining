using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myFirstWeb.Startup))]
namespace myFirstWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
