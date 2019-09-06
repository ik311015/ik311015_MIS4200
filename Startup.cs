using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ik311015_MIS4200.Startup))]
namespace ik311015_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
