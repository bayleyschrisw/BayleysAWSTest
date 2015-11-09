using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BayleysAWSTest.Startup))]
namespace BayleysAWSTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
