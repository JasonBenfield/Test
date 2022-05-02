// Generated Code
namespace XTI_TestAppClient;
public sealed partial class TestAppClient : AppClient
{
    public TestAppClient(IHttpClientFactory httpClientFactory, XtiTokenAccessor xtiTokenAccessor, AppClientUrl clientUrl, TestAppClientVersion version) : base(httpClientFactory, xtiTokenAccessor, clientUrl, "Test", version.Value)
    {
        User = GetGroup((_clientFactory, _tokenAccessor, _url) => new UserGroup(_clientFactory, _tokenAccessor, _url));
        UserCache = GetGroup((_clientFactory, _tokenAccessor, _url) => new UserCacheGroup(_clientFactory, _tokenAccessor, _url));
        Home = GetGroup((_clientFactory, _tokenAccessor, _url) => new HomeGroup(_clientFactory, _tokenAccessor, _url));
        Whatever = GetGroup((_clientFactory, _tokenAccessor, _url) => new WhateverGroup(_clientFactory, _tokenAccessor, _url));
    }

    public UserGroup User { get; }

    public UserCacheGroup UserCache { get; }

    public HomeGroup Home { get; }

    public WhateverGroup Whatever { get; }
}