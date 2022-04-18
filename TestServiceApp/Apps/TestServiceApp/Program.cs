using Microsoft.Extensions.Hosting;
using TestServiceApp.Extensions;
using XTI_Core;
using XTI_HubAppClient.ServiceApp.Extensions;
using XTI_Schedule;
using XTI_TestServiceAppApi;

await XtiServiceAppHost.CreateDefault(TestInfo.AppKey, args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddTestServiceAppServices();
        services.AddAppAgenda
        (
            (sp, agenda) =>
            {
                agenda.AddScheduled<TestAppApi>
                (
                    (api, agenda) =>
                    {
                        agenda.Action(api.Home.DoSomething.Path)
                            .Interval(TimeSpan.FromMinutes(5))
                            .AddSchedule
                            (
                                Schedule.EveryDay().At(TimeRange.AllDay())
                            );
                    }
                );
            }
        );
    })
    .RunConsoleAsync();