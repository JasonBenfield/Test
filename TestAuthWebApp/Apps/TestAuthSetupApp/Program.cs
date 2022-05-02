using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TestAuthSetupApp;
using XTI_App.Abstractions;
using XTI_App.Api;
using XTI_AppSetupApp.Extensions;
using XTI_TestAuthWebAppApi;

await XtiSetupAppHost.CreateDefault(TestAuthInfo.AppKey, args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddSingleton(_ => AppVersionKey.Current);
        services.AddScoped<AppApiFactory, TestAuthAppApiFactory>();
        services.AddScoped<IAppSetup, TestAuthAppSetup>();
    })
    .RunConsoleAsync();