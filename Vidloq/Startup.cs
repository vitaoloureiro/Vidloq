using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidloq.Startup))]
namespace Vidloq
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
