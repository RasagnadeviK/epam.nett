using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCCRUD.Startup))]
namespace MVCCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
