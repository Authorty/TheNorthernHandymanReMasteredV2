using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheNorthernHandymanReMastered.Startup))]
namespace TheNorthernHandymanReMastered
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
