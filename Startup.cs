using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ACM_Website.Startup))]
namespace ACM_Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
