using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SinExWebApp20315827.Startup))]
namespace SinExWebApp20315827
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
