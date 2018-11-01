using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aquarace.Startup))]
namespace Aquarace
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
