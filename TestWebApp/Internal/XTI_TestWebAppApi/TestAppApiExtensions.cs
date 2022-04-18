namespace XTI_TestWebAppApi;

public static class TestAppApiExtensions
{
    public static void AddTestAppApiServices(this IServiceCollection services)
    {
        services.AddHomeGroupServices();
    }
}