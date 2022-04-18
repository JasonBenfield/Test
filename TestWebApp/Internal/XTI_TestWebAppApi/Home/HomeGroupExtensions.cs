using XTI_TestWebAppApi.Home;

namespace XTI_TestWebAppApi;

internal static class HomeGroupExtensions
{
    public static void AddHomeGroupServices(this IServiceCollection services)
    {
        services.AddScoped<IndexAction>();
    }
}