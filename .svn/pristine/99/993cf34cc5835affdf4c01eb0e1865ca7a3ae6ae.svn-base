using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo.SiteWeb.Startup))]
namespace Demo.SiteWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }

    /* Ajout du middleware StaticFiles pour les assets statiques
    public void Configure(IApplicationBuilder app)
    {
        app.UseDefaultFiles();
        app.UseStaticFiles();
    }
    */
}

