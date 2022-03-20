using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PsdToHtml_1.Startup))]
namespace PsdToHtml_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
