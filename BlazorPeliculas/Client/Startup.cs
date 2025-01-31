using BlazorPeliculas.Client.Repositorios;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorPeliculas.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ServiciosSingleton>();
            services.AddTransient<ServiciosTransient>();
            services.AddScoped<IRepositorio, Repositorio>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
