using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DNCH.Startup))]
namespace DNCH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
