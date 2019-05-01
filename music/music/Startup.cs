using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(music.Startup))]
namespace music
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
