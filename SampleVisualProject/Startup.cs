using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleVisualProject.Startup))]
namespace SampleVisualProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
