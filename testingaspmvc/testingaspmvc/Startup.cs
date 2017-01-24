using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testingaspmvc.Startup))]
namespace testingaspmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
