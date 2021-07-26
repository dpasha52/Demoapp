using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(contactswebv1.Startup))]
namespace contactswebv1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
