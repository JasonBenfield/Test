using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using XTI_TestWebAppApi;
using XTI_App.Api;

namespace TestWebApp.Extensions;

public static class TestExtensions
{
    public static void AddTestWebAppServices(this IServiceCollection services)
    {
        services.AddScoped<AppApiFactory, TestAppApiFactory>();
        services.AddScoped(sp => (TestAppApi)sp.GetRequiredService<IAppApi>());
        services.AddTestAppApiServices();
    }
}