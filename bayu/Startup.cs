using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bayu.Startup))]
namespace bayu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
