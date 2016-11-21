using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AllInOne_blog.Startup))]
namespace AllInOne_blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
