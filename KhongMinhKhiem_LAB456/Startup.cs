using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KhongMinhKhiem_LAB456.Startup))]
namespace KhongMinhKhiem_LAB456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
