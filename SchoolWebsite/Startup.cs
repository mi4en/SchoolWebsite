using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolWebsite.Startup))]
namespace SchoolWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
