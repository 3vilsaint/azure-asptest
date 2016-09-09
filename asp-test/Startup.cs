using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp_test.Startup))]
namespace asp_test
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
