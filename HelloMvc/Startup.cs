using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloMvc.Startup))]
namespace HelloMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
