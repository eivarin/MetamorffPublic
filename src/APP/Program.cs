    using System;
    using WebWindows.Blazor;
    using Microsoft.Extensions.DependencyInjection;
    using BlazorStyled;
    using APP.Services;
    using CommonLib.Auth;
    using CommonLib.MutexStuff;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;

    namespace APP
    {
        public class Program
        {
            static void Main(string[] args)
            {
                MyApp.AbrirApp("teste");
            }
            
        }

        public static class MyApp
        {
            public static void AbrirApp(string Mystr)
            {
                ServiceCollection Services = new ServiceCollection();
                GlobalVars vars = new GlobalVars();
                vars.mystring = Mystr;
                vars.loginInfo.IsLoggedIn = true;
                vars.loginInfo.Username = "Default User";
                Services.AddSingleton<Authorization>();
                Services.AddSingleton<GlobalVars>(vars);
                ComponentsDesktop.Run<Startup>("Metamorff", "wwwroot/index.html", Services);
            }
        }


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

