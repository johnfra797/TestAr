using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAr.WebII.Startup))]
namespace TestAr.WebII
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
