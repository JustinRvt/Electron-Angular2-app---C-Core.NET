using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WS_Hotline.SiteWeb.Startup))]
namespace WS_Hotline.SiteWeb
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

