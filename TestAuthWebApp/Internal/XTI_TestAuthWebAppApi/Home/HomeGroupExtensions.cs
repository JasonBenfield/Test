﻿using XTI_TestAuthWebAppApi.Home;

namespace XTI_TestAuthWebAppApi;

internal static class HomeGroupExtensions
{
    public static void AddHomeGroupServices(this IServiceCollection services)
    {
        services.AddScoped<IndexAction>();
        services.AddScoped<LoginAction>();
    }
}