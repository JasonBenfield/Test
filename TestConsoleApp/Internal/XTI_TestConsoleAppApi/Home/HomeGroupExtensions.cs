using XTI_TestConsoleAppApi.Home;

namespace XTI_TestConsoleAppApi;

internal static class HomeGroupExtensions
{
    public static void AddHomeGroupServices(this IServiceCollection services)
    {
        services.AddScoped<DoSomethingAction>();
    }
}