using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SamuelTestMVC.Startup))]
namespace SamuelTestMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
