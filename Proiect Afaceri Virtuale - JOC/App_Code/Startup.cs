using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proiect_Afaceri_Virtuale.Startup))]
namespace Proiect_Afaceri_Virtuale
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
