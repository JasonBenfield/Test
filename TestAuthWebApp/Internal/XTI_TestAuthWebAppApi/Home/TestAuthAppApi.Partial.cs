using XTI_TestAuthWebAppApi.Home;

namespace XTI_TestAuthWebAppApi;

partial class TestAuthAppApi
{
    private HomeGroup? home;

    public HomeGroup Home { get => home ?? throw new ArgumentNullException(nameof(home)); }

    partial void createHomeGroup(IServiceProvider sp)
    {
        home = new HomeGroup
        (
            source.AddGroup(nameof(Home), ResourceAccess.AllowAnonymous()),
            sp
        );
    }
}