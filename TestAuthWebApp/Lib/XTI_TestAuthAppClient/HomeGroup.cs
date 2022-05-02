// Generated Code
namespace XTI_TestAuthAppClient;
public sealed partial class HomeGroup : AppClientGroup
{
    public HomeGroup(IHttpClientFactory httpClientFactory, XtiTokenAccessor xtiTokenAccessor, AppClientUrl clientUrl) : base(httpClientFactory, xtiTokenAccessor, clientUrl, "Home")
    {
        Actions = new HomeActions(clientUrl);
    }

    public HomeActions Actions { get; }

    public Task<string> Login(TestAuthLoginRequest model) => Post<string, TestAuthLoginRequest>("Login", "", model);
}