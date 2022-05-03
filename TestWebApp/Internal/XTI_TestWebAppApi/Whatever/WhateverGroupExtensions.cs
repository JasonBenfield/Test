using XTI_TestWebAppApi.Whatever;

namespace XTI_TestWebAppApi;

internal static class WhateverGroupExtensions
{
    public static void AddWhateverGroupServices(this IServiceCollection services)
    {
        services.AddScoped<DoSomethingAction>();
    }
}