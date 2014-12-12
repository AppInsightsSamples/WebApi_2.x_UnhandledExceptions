using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApi2WithMVC.Startup))]
namespace WebApi2WithMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
