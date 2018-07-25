using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCHomeWorkMoneyTemplate.Startup))]
namespace MVCHomeWorkMoneyTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
