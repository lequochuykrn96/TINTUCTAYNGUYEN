using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TINTUCTAYNGUYEN.Startup))]
namespace TINTUCTAYNGUYEN
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
