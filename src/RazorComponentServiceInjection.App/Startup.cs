using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using RazorComponentServiceInjection.Services;

namespace RazorComponentServiceInjection.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)        {
            
            services
                .AddSingleton<WeatherForecastService>() // Example of a data service
                .AddTransient<SomeService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>(nameof(app));
        }
    }
}
