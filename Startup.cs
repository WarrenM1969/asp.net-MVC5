using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcOnTraQ2.Startup))]
namespace mvcOnTraQ2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
