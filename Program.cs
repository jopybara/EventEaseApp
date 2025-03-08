using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using EventEaseApp.Services;

namespace EventEaseApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<SessionStateService>();
            builder.Services.AddScoped<LocalStorageService>();
            builder.Logging.SetMinimumLevel(LogLevel.Debug);

            await builder.Build().RunAsync();
        }
    }
}
