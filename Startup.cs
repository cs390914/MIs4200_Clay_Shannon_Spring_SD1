using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MIs4200_Clay_Shannon_Spring_SD1.Startup))]
namespace MIs4200_Clay_Shannon_Spring_SD1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
