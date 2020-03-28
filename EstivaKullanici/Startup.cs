using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstivaKullanici.Startup))]
namespace EstivaKullanici
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
