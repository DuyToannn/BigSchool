using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2011061909_DoDuyToan.Startup))]
namespace _2011061909_DoDuyToan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
