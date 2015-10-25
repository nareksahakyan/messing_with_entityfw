using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeFirstExistingDatabaseSample.Startup))]
namespace CodeFirstExistingDatabaseSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
