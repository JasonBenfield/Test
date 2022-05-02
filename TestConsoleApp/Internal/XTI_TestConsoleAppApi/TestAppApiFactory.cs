namespace XTI_TestConsoleAppApi;

public sealed class TestAppApiFactory : AppApiFactory
{
    private readonly IServiceProvider sp;

    public TestAppApiFactory(IServiceProvider sp)
    {
        this.sp = sp;
    }

    public new TestAppApi Create(IAppApiUser user) => (TestAppApi)base.Create(user);
    public new TestAppApi CreateForSuperUser() => (TestAppApi)base.CreateForSuperUser();

    protected override IAppApi _Create(IAppApiUser user) => new TestAppApi(user, sp);
}