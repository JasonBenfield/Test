using Microsoft.Extensions.DependencyInjection;
using XTI_App.Api;
using XTI_TestServiceAppApi;

namespace TestServiceApp.Extensions;

public static class TestExtensions
{
    public static void AddTestServiceAppServices(this IServiceCollection services)
    {
        services.AddSingleton<IAppApiUser, AppApiSuperUser>();
        services.AddTestAppApiServices();
        services.AddScoped<AppApiFactory, TestAppApiFactory>();
        services.AddScoped(sp => (TestAppApi)sp.GetRequiredService<IAppApi>());
    }
}