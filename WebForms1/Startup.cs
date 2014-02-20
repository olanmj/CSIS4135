using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForms1.Startup))]
namespace WebForms1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
