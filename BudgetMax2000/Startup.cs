using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BudgetMax2000.Startup))]
namespace BudgetMax2000
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
