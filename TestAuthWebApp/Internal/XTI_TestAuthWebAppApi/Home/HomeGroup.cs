namespace XTI_TestAuthWebAppApi.Home;

public sealed class HomeGroup : AppApiGroupWrapper
{
    public HomeGroup(AppApiGroup source, IServiceProvider sp)
        : base(source)
    {
        var actions = new WebAppApiActionFactory(source);
        Index = source.AddAction(actions.View(nameof(Index), () => sp.GetRequiredService<IndexAction>()));
        Login = source.AddAction
        (
            actions.Action(nameof(Login), () => sp.GetRequiredService<LoginAction>())
        );
    }

    public AppApiAction<EmptyRequest, WebViewResult> Index { get; }
    public AppApiAction<TestAuthLoginRequest, string> Login { get; }
}