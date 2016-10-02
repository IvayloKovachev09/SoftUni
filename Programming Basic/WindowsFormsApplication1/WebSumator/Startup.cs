using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSumator.Startup))]
namespace WebSumator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
