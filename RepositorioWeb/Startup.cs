using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepositorioWeb.Startup))]
namespace RepositorioWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
