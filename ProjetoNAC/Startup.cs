using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoNAC.Startup))]
namespace ProjetoNAC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
