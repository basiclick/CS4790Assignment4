using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CS4790Assignment4.Startup))]
namespace CS4790Assignment4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
