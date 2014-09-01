using Microsoft.Owin;
using Owin;
using Slashroll;

[assembly: OwinStartup(typeof(Startup))]
namespace Slashroll
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}