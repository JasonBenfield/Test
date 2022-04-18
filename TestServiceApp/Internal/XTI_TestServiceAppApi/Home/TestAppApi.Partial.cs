using XTI_TestServiceAppApi.Home;

namespace XTI_TestServiceAppApi;

partial class TestAppApi
{
    private HomeGroup? home;

    public HomeGroup Home { get => home ?? throw new ArgumentNullException(nameof(home)); }

    partial void createHomeGroup(IServiceProvider sp)
    {
        home = new HomeGroup
        (
            source.AddGroup(nameof(Home)),
            sp
        );
    }
}