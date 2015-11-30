using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SMSService.Startup))]
namespace SMSService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
