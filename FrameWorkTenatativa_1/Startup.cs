using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FrameWorkTenatativa_1.Startup))]
namespace FrameWorkTenatativa_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
