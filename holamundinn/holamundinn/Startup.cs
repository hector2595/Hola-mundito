using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(holamundinn.Startup))]
namespace holamundinn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
