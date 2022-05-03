using XTI_App.Abstractions;

namespace TestSetupApp;

internal sealed class TestAppSetup : IAppSetup
{
    public Task Run(AppVersionKey versionKey)
    {
        return Task.CompletedTask;
    }
}
