using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Application1.Startup))]
namespace Application1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
