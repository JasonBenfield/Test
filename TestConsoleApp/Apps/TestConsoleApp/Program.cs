using Microsoft.Extensions.Hosting;
using TestConsoleApp.Extensions;
using XTI_HubAppClient.ConsoleApp.Extensions;
using XTI_TestConsoleAppApi;

await XtiConsoleAppHost.CreateDefault(TestInfo.AppKey, args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddTestConsoleAppServices();
        services.AddAppAgenda
        (
            (sp, agenda) =>
            {
                agenda.AddImmediate<TestAppApi>(api => api.Home.DoSomething);
            }
        );
    })
    .RunConsoleAsync();