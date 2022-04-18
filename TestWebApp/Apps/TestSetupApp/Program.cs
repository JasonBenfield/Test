using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TestSetupApp;
using XTI_App.Abstractions;
using XTI_App.Api;
using XTI_AppSetupApp.Extensions;
using XTI_TestWebAppApi;

await XtiSetupAppHost.CreateDefault(TestInfo.AppKey, args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddSingleton(_ => AppVersionKey.Current);
        services.AddScoped<AppApiFactory, TestAppApiFactory>();
        services.AddScoped<IAppSetup, TestAppSetup>();
    })
    .RunConsoleAsync();