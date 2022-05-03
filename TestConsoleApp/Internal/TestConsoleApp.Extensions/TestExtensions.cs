using Microsoft.Extensions.DependencyInjection;
using XTI_App.Api;
using XTI_TestConsoleAppApi;

namespace TestConsoleApp.Extensions;

public static class TestExtensions
{
    public static void AddTestConsoleAppServices(this IServiceCollection services)
    {
        services.AddTestAppApiServices();
        services.AddScoped<AppApiFactory, TestAppApiFactory>();
        services.AddScoped(sp => (TestAppApi)sp.GetRequiredService<IAppApi>());
    }
}