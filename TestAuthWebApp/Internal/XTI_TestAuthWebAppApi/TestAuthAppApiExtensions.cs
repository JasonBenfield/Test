namespace XTI_TestAuthWebAppApi;

public static class TestAuthAppApiExtensions
{
    public static void AddTestAuthAppApiServices(this IServiceCollection services)
    {
        services.AddHomeGroupServices();
    }
}