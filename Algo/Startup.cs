using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Algo.Startup))]
namespace Algo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
