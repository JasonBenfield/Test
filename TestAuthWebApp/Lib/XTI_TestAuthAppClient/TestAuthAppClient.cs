// Generated Code
namespace XTI_TestAuthAppClient;
public sealed partial class TestAuthAppClient : AppClient
{
    public TestAuthAppClient(IHttpClientFactory httpClientFactory, XtiTokenAccessor xtiTokenAccessor, AppClientUrl clientUrl, TestAuthAppClientVersion version) : base(httpClientFactory, xtiTokenAccessor, clientUrl, "TestAuth", version.Value)
    {
        User = GetGroup((_clientFactory, _tokenAccessor, _url) => new UserGroup(_clientFactory, _tokenAccessor, _url));
        UserCache = GetGroup((_clientFactory, _tokenAccessor, _url) => new UserCacheGroup(_clientFactory, _tokenAccessor, _url));
        Home = GetGroup((_clientFactory, _tokenAccessor, _url) => new HomeGroup(_clientFactory, _tokenAccessor, _url));
    }

    public TestAuthRoleNames RoleNames { get; } = TestAuthRoleNames.Instance;
    public string AppName { get; } = "TestAuth";
    public UserGroup User { get; }

    public UserCacheGroup UserCache { get; }

    public HomeGroup Home { get; }
}