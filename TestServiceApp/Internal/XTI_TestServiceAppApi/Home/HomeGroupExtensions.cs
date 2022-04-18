using XTI_TestServiceAppApi.Home;

namespace XTI_TestServiceAppApi;

internal static class HomeGroupExtensions
{
    public static void AddHomeGroupServices(this IServiceCollection services)
    {
        services.AddScoped<DoSomethingAction>();
    }
}