﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using XTI_ApiGeneratorApp.Extensions;
using XTI_App.Api;
using XTI_Core.Extensions;
using XTI_TestAuthWebAppApi;

await Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((hostingContext, config) =>
    {
        config.UseXtiConfiguration(hostingContext.HostingEnvironment, "", "", args);
    })
    .ConfigureServices((hostContext, services) =>
    {
        services.AddApiGenerator();
        services.AddScoped<AppApiFactory, TestAuthAppApiFactory>();
        services.AddHostedService<ApiGeneratorHostedService>();
    })
    .RunConsoleAsync();