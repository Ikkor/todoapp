using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(todoapp.Startup))]
namespace todoapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
