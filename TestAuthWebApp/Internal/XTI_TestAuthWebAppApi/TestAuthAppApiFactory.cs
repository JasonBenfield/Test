namespace XTI_TestAuthWebAppApi;

public sealed class TestAuthAppApiFactory : AppApiFactory
{
    private readonly IServiceProvider sp;

    public TestAuthAppApiFactory(IServiceProvider sp)
    {
        this.sp = sp;
    }

    public new TestAuthAppApi Create(IAppApiUser user) => (TestAuthAppApi)base.Create(user);
    public new TestAuthAppApi CreateForSuperUser() => (TestAuthAppApi)base.CreateForSuperUser();

    protected override IAppApi _Create(IAppApiUser user) => new TestAuthAppApi(user, sp);
}