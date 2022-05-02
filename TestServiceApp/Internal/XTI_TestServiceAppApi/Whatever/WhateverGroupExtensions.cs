using XTI_TestServiceAppApi.Whatever;

namespace XTI_TestServiceAppApi;

internal static class WhateverGroupExtensions
{
    public static void AddWhateverGroupServices(this IServiceCollection services)
    {
        services.AddScoped<DoSomethingAction>();
    }
}