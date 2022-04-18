using TestWebApp.Extensions;
using XTI_HubAppClient.WebApp.Extensions;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using TestWebApp.ApiControllers;
using XTI_Core;
using XTI_TestWebAppApi;

var builder = XtiWebAppHost.CreateDefault(TestInfo.AppKey, args);
builder.Services.AddSingleton(_ => TestInfo.AppKey);
var xtiEnv = XtiEnvironment.Parse(builder.Environment.EnvironmentName);
XTI_WebApp.Extensions.CookieAndTokenAuthentication.ConfigureXtiCookieAndTokenAuthentication(builder.Services, xtiEnv, builder.Configuration);
builder.Services.AddTestWebAppServices();
builder.Services
    .AddMvc()
    .AddJsonOptions(options =>
    {
        options.SetDefaultJsonOptions();
    })
    .AddMvcOptions(options =>
    {
        options.SetDefaultMvcOptions();
    });
builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add
    (
        new AssemblyPart(typeof(HomeController).Assembly)
    );

var app = builder.Build();
XTI_WebApp.Extensions.WebAppExtensions.UseXtiDefaults(app);
await app.RunAsync();