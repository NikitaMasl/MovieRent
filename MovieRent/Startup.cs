using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieRent.Startup))]
namespace MovieRent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
