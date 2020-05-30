using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebKhoaHocUngDung.Startup))]
namespace WebKhoaHocUngDung
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
