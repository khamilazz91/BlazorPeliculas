using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                .UseBlazorStartup<Startup>();


        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions(); //Sistema de autorizacion
            services.AddSingleton<ServiciosSingleton>();
        }
    }

    
}
