using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSPortfolio.Startup))]
namespace CSPortfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
