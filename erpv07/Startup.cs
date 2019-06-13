using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(erpv07.Startup))]
namespace erpv07
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
