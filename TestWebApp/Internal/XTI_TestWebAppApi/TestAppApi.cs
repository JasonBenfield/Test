namespace XTI_TestWebAppApi;

public sealed partial class TestAppApi : WebAppApiWrapper
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
            ),
            sp
        )
    {
        createHomeGroup(sp);
        createWhateverGroup(sp);
    }

    partial void createHomeGroup(IServiceProvider sp);

    partial void createWhateverGroup(IServiceProvider sp);
}