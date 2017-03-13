using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(NAPSOMIS_Webpoint.Startup))]

// Files related to ASP.NET Identity duplicate the Microsoft ASP.NET Identity file structure and contain initial Microsoft comments.

namespace NAPSOMIS_Webpoint
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}