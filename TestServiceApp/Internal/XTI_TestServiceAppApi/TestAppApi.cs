namespace XTI_TestServiceAppApi;

public sealed partial class TestAppApi : AppApiWrapper
{
    public TestAppApi
    (
        IAppApiUser user,
        IServiceProvider sp
    )
        : base
        (
            new AppApi
            (
                TestInfo.AppKey,
                user,
                ResourceAccess.AllowAuthenticated()
                    .WithAllowed(AppRoleName.Admin)
            )
        )
    {
        createHomeGroup(sp);
        createWhateverGroup(sp);
    }

    partial void createHomeGroup(IServiceProvider sp);

    partial void createWhateverGroup(IServiceProvider sp);
}