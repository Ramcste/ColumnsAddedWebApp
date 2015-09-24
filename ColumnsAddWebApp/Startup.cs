using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ColumnsAddWebApp.Startup))]
namespace ColumnsAddWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
