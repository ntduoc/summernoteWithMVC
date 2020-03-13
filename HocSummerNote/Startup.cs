using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HocSummerNote.Startup))]
namespace HocSummerNote
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
