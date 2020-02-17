using Microsoft.Extensions.DependencyInjection;
using WebWindows.Blazor;
using BlazorStyled;

namespace APP
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBlazorStyled();
        }

        public void Configure(DesktopApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
