using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstWebApp.Startup))]
namespace FirstWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
